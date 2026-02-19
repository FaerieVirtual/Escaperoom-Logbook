using Logbook.Forms;
using Logbook.Properties;
using Logbook.Scripts;
using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logbook
{
    public partial class Logbook : Form
    {
        public Logbook()
        {
            InitializeComponent();
            if (logbook != null) { Dispose(); }
            if (logbook == null) { logbook = this; }
        }

        public static Logbook logbook;

        public Account currentAccount;
        public List<Account> accounts = new();
        public Log selectedLog;
        public List<Log> logs = new();

        public WaveOutEvent output;
        public AudioFileReader audioFile;

        private ContextMenuStrip contentItemMenu;
        private ContextMenuStrip contentPanelMenu;
        public ContextMenuStrip logItemMenu;
        private ContextMenuStrip logPanelMenu;

        private Log clipboardLog;
        private LogItem clipboardItem;

        private readonly Stack<string> undoStack = new();
        private readonly Stack<string> redoStack = new();

        private void OnLoad(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.Dpi;
            WindowState = FormWindowState.Maximized;

            InitializeContentItemMenu();
            InitializeContentPanelMenu();
            InitializeLogItemMenu();
            InitializeLogPanelMenu();
            LoadAllLogs();
            LoadAllAccounts();

            SetHomeDisplay();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var log = selectedLog;
            if (log != null)
            {
                log.SaveFromUI();
                log.WriteToDisk();
            }

            base.OnFormClosing(e);
        }

        #region Log Management

        public void AddLog()
        {
            CreateLogdialog create = new();
            create.ShowDialog();
        }

        public void SetLogDisplay()
        {
            foreach (Control control in Controls)
            {
                if (control.Tag is string controlTag && controlTag == "HomeDisplay")
                {
                    control.Hide();
                }
                if (control.Tag is string ctrlTag && ctrlTag == "LogDisplay")
                {
                    control.Show();
                }
                ContentPanel.Show();
            }
        }
        public void SetHomeDisplay()
        {
            foreach (Control control in Controls)
            {
                if (control.Tag is string controlTag && controlTag == "HomeDisplay")
                {
                    control.Show();
                }
                if (control.Tag is string ctrlTag && ctrlTag == "LogDisplay")
                {
                    control.Hide();
                }
                ContentPanel.Hide();
            }
        }


        private void LoadAllLogs()
        {
            foreach (var file in Directory.GetFiles(Paths.Logs, "*.json"))
            {
                string json = File.ReadAllText(file);
                Log log = JsonConvert.DeserializeObject<Log>(json);

                logs.Add(log);

                Button btn = log.CreateLogButton();

                if (!log.privated)
                {
                    LogPanel.Controls.Add(btn);
                }
                else
                {
                    btn.Visible = false;
                    btn.Enabled = false;
                    LogPanel.Controls.Add(btn);
                }
            }
        }

        public void ResizeOnClientSizeChanged(object sender, EventArgs e)
        {
            if (selectedLog != null)
            {
                selectedLog.Open();
            }
            MainPanel.RowStyles.Clear();
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, ToolStrip.Height));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        }

        #endregion

        #region Account Management
        private void LoadAllAccounts()
        {
            foreach (var file in Directory.GetFiles(Paths.Accounts, "*.json"))
            {
                string json = File.ReadAllText(file);
                Account acc = JsonConvert.DeserializeObject<Account>(json);
                ToolStripMenuItem button = new()
                {
                    Image = Resources.pass,
                    Name = acc.name + "Button",
                    Size = new Size(332, 26),
                    Text = acc.name,
                };

                button.Click += (sender, e) => LogInAccount(acc);

                Account_button.DropDownItems.Insert(0, button);

                accounts.Add(acc);
            }
        }

        private void AddAccount()
        {
            AddAccountDialog dialog = new();
            dialog.Show();
        }

        public void LogInAccount(Account account)
        {
            LogInSuccess success = account.LogIn();

            if (success == LogInSuccess.Success)
            {
                Account_button.Text = account.name;
                currentAccount = account;
                MessageBox.Show($"Přihlášený účet: {account.name} \nAutorizace: {currentAccount.auth} \n\nNačítám protokoly uživatele...", "Přihlášení úspěšné!");
                Refresh();
            }
        }
        #endregion

        #region Undo/redo
        private void PushUndoState()
        {
            if (selectedLog == null) return;

            selectedLog.SaveFromUI();

            undoStack.Push(JsonConvert.SerializeObject(selectedLog));
            redoStack.Clear();
        }

        private void RestoreLogState(string json)
        {
            Log restored = JsonConvert.DeserializeObject<Log>(json);
            selectedLog = restored;

            ContentPanel.Controls.Clear();
            restored.Open(); // už umíš
        }


        #endregion

        #region Content Item Menu
        private void InitializeContentItemMenu()
        {
            contentItemMenu = new ContextMenuStrip();

            contentItemMenu.Items.Add("Kopírovat", null, Content_Copy_Click);
            contentItemMenu.Items.Add("Vložit", null, Content_Paste_Click);
            contentItemMenu.Items.Add("Odstranit", null, Content_Delete_Click);

            contentItemMenu.Items.Add(new ToolStripSeparator());

            contentItemMenu.Items.Add("Zrušit výběr", null, (sender, e) => ActiveControl = null);
            ContentPanel.MouseUp += ContentPanel_MouseUp;
        }

        private void InitializeContentPanelMenu()
        {
            contentPanelMenu = new ContextMenuStrip();

            contentPanelMenu.Items.Add("Vložit", null, Log_Paste_Click);
            ContentPanel.MouseUp += ContentPanel_MouseUp;
        }

        private void ContentPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (currentAccount.auth != Authorization.Admin) return;

            Control clicked = ContentPanel.GetChildAtPoint(e.Location);

            if (clicked == null)
            {
                contentPanelMenu.Show(ContentPanel, e.Location);
            }
            else
            {
                contentItemMenu.Show(clicked, e.Location);
            }
        }

        private void Content_Delete_Click(object sender, EventArgs e)
        {
            if (contentItemMenu.SourceControl is Control ctrl)
            {
                PushUndoState();
                ctrl.Parent.Controls.Remove(ctrl);
            }
        }

        private void Content_Copy_Click(object sender, EventArgs e)
        {
            if (contentItemMenu.SourceControl?.Tag is LogItem item)
            {
                clipboardItem = JsonConvert.DeserializeObject<LogItem>(
                    JsonConvert.SerializeObject(item));
            }
        }
        private void Content_Paste_Click(object sender, EventArgs e)
        {
            if (clipboardItem == null) return;

            PushUndoState();

            switch (clipboardItem.Type)
            {
                case LogItemType.Text:
                    AddTextfield(clipboardItem.Data);
                    break;

                case LogItemType.Image:
                    AddImage(clipboardItem.Data);
                    break;

                case LogItemType.Audio:
                    AddAudioRecording(clipboardItem.Data);
                    break;
            }
        }
        #endregion

        #region Log Item Menu
        private void InitializeLogItemMenu()
        {
            logItemMenu = new ContextMenuStrip();

            logItemMenu.Items.Add("Přejmenovat", null, Log_Rename_Click);
            logItemMenu.Items.Add("Kopírovat", null, Log_Copy_Click);
            logItemMenu.Items.Add("Odstranit", null, Log_Delete_Click);
            LogPanel.MouseUp += LogPanel_MouseUp;
        }
        private void Log_Copy_Click(object sender, EventArgs e)
        {
            if (logItemMenu.SourceControl?.Tag is Log log)
                clipboardLog = log;
        }

        private void Log_Delete_Click(object sender, EventArgs e)
        {
            if (logItemMenu.SourceControl?.Tag is Log log)
            {
                PushUndoState();
                logs.Remove(log);
                File.Delete(Path.Combine("Content", "Logs", log.title + ".json"));
                LogPanel.Controls.Remove(logItemMenu.SourceControl);
            }
        }

        private void Log_Rename_Click(object sender, EventArgs e)
        {
            if (logItemMenu.SourceControl?.Tag is Log log)
            {
                PushUndoState();
                string newName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nový název protokolu:", "Přejmenovat", log.title);

                if (string.IsNullOrWhiteSpace(newName)) return;

                File.Delete(Path.Combine("Content", "Logs", log.title + ".json"));
                log.title = log.locked ? $"[🔒] {newName}" : $"[🔓] {newName}";
                log.WriteToDisk();

                ((Button)logItemMenu.SourceControl).Text = newName;
            }
        }

        private void InitializeLogPanelMenu()
        {
            logPanelMenu = new ContextMenuStrip();
            logPanelMenu.Items.Add("Vložit", null, Log_Paste_Click);
            LogPanel.MouseUp += LogPanel_MouseUp;
        }
        private void Log_Paste_Click(object sender, EventArgs e)
        {
            if (clipboardLog == null) return;

            Log clone = JsonConvert.DeserializeObject<Log>(
                JsonConvert.SerializeObject(clipboardLog));

            clone.title += " kopie";
            clone.WriteToDisk();

            logs.Add(clone);
            LogPanel.Controls.Add(clone.CreateLogButton());
        }
        private void LogPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (currentAccount.auth != Authorization.Admin) return;

            Control clicked = LogPanel.GetChildAtPoint(e.Location);

            if (clicked == null)
            {
                logPanelMenu.Show(LogPanel, e.Location);
            }
            else
            {
                logItemMenu.Show(clicked, e.Location);
            }
        }

        #endregion

        #region Adding elements
        public void AddImage(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Soubor neexistuje.");
                return;
            }

            Image img = Image.FromFile(filePath);

            PictureBox pb = new()
            {
                Name = filePath,
                Tag = "LogDisplay",
                Image = img,
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = ContentPanel.ClientSize.Width - 25,
                MaximumSize = new Size((int)img.HorizontalResolution * 10, (int)img.VerticalResolution) * 10,
                Height = (int)((ContentPanel.ClientSize.Width - 25) * (img.Height / (double)img.Width)),
                Margin = new Padding(10, 10, 10, 10),
                ContextMenuStrip = contentItemMenu
            };

            ContentPanel.Controls.Add(pb);
        }

        public void AddTextfield(string content = null)
        {
            TextBox textBox = new()
            {
                Tag = "LogDisplay",
                Multiline = true,
                BorderStyle = BorderStyle.None,
                WordWrap = true,
                Width = ContentPanel.ClientSize.Width - 25,
                Margin = new Padding(10, 10, 10, 10),
                Font = new Font("Courier New", 14),
                ForeColor = Color.Black,
                ContextMenuStrip = contentItemMenu
            };

            textBox.TextChanged += (s, e) =>
            {
                var size = TextRenderer.MeasureText(
                    textBox.Text + " ",
                    textBox.Font,
                    new Size(textBox.Width, int.MaxValue),
                    TextFormatFlags.WordBreak);

                textBox.Height = Math.Max(size.Height + 10, 40);
            };

            if (content != null)
                textBox.Text = content;

            ContentPanel.Controls.Add(textBox);
        }

        public void AddAudioRecording(string filepath)
        {
            if (File.Exists(filepath))
            {
                AudioRecordingStrip strip = new(filepath)
                {
                    Name = filepath,
                    Tag = "LogDisplay",
                    ContextMenuStrip = contentItemMenu
                };
                ContentPanel.Controls.Add(strip);
            }
            else
            {
                MessageBox.Show("Vložení souboru selhalo z neznámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Toolbar
        private void Home_button_Click(object sender, EventArgs e)
        {
            SetHomeDisplay();
        }
        private void Add_TextClick(object sender, EventArgs e)
        {
            if (currentAccount != null && currentAccount.auth == Authorization.Admin)
            {
                PushUndoState();
                AddTextfield();
            }
            else
            {
                MessageBox.Show("Nemáte dostatečná práva k přidání textového pole. Pokud chcete přidávat a upravovat protokoly, přihlaste se k účtu admina.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Add_AudioClick(object sender, EventArgs e)
        {
            if (currentAccount != null && currentAccount.auth == Authorization.Admin)
            {
                PushUndoState();

                using OpenFileDialog ofd = new();
                ofd.AddExtension = true;
                ofd.Filter = "All files (*.*)|*.*|MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav|AIFF files (*.aiff)|*.aiff";
                ofd.Title = "Choose a file:";

                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.Cancel) return;

                AudioFileReader reader;

                string filePath = ofd.FileName;
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine("Content", fileName);
                if (File.Exists(filePath))
                {
                    reader = new(ofd.FileName);
                    try
                    {
                        if (!Directory.Exists("Content")) { Directory.CreateDirectory("Content"); }
                        File.Copy(filePath, destinationPath, true);
                    }
                    catch
                    {
                        MessageBox.Show("Vložení souboru selhalo z neznámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vložení souboru selhalo z neznámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AddAudioRecording(destinationPath);
            }
            else
            {
                MessageBox.Show("Nemáte dostatečná práva k přidání audio nahrávky. Pokud chcete přidávat a upravovat protokoly, přihlaste se k účtu admina.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Add_ImageClick(object sender, EventArgs e)
        {
            if (currentAccount != null && currentAccount.auth == Authorization.Admin)
            {
                PushUndoState();

                using OpenFileDialog ofd = new();

                ofd.AddExtension = true;
                ofd.Filter = "All files (*.*)|*.*|PNG soubory (*.png)|*.png|JPEG soubory (*.jpeg)|*.jpeg|JPG soubory (*.jpg)|*.jpg";
                ofd.Title = "Vyberte soubor:";

                DialogResult success = ofd.ShowDialog();

                if (success == DialogResult.Cancel) return;

                string filePath = ofd.FileName;
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine("Content", fileName);
                if (File.Exists(filePath))
                {
                    try
                    {
                        if (!Directory.Exists("Content")) { Directory.CreateDirectory("Content"); }
                        File.Copy(filePath, destinationPath, true);
                    }
                    catch
                    {
                        MessageBox.Show("Vložení souboru selhalo z neznámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vložení souboru selhalo z neznámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                AddImage(destinationPath);
            }
            else
            {
                MessageBox.Show("Nemáte dostatečná práva k přidání obrázku. Pokud chcete přidávat a upravovat protokoly, přihlaste se k účtu admina.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Del_button_Click(object sender, EventArgs e)
        {
            //if (currentAccount.auth == authentication)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void Paste_button_Click(object sender, EventArgs e)
        {
            //if (mode == LogMode.Edit)
            //{
            //}
            //else
            //{
            //    MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            //if (mode == LogMode.Edit)
            //{
            //}
            //else
            //{
            //    MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (currentAccount != null && currentAccount.auth == Authorization.Admin)
            {
                PushUndoState();
                string newName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nový název protokolu:", "Přejmenovat", selectedLog.title);

                if (string.IsNullOrWhiteSpace(newName)) return;

                File.Delete(Path.Combine("Content", "Logs", selectedLog.title + ".json"));
                selectedLog.title = selectedLog.locked ? $"[🔒] {newName}" : $"[🔓] {newName}";
                selectedLog.WriteToDisk();

                ((System.Windows.Forms.Button)logItemMenu.SourceControl).Text = newName;
            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Undo_button_Click(object sender, EventArgs e)
        {
            if (currentAccount.auth == Authorization.Admin)
            {
                if (undoStack.Count == 0) return;

                redoStack.Push(JsonConvert.SerializeObject(selectedLog));
                RestoreLogState(undoStack.Pop());
            }
        }

        private void Redo_button_Click(object sender, EventArgs e)
        {
            if (currentAccount.auth == Authorization.Admin)
            {
                if (redoStack.Count == 0) return;

                undoStack.Push(JsonConvert.SerializeObject(selectedLog));
                RestoreLogState(redoStack.Pop());
            }
        }

        private void AddAccButton_Click(object sender, EventArgs e)
        {
            AddAccount();
        }


        private void Add_LogButton_Click(object sender, EventArgs e)
        {
            if (currentAccount != null && currentAccount.auth == Authorization.Admin)
            {
                AddLog();
            }
            else
            {
                MessageBox.Show("Nemáte dostatečná práva k přidání protokolu. Pokud chcete přidávat a upravovat protokoly, přihlaste se k účtu admina.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void ClockUpdater_Tick(object sender, EventArgs e)
        {
            string displayDate = "";
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": displayDate = "Pondělí "; break;
                case "Tuesday": displayDate = "Úterý "; break;
                case "Wednesday": displayDate = "Středa "; break;
                case "Thursday": displayDate = "Čtvrtek "; break;
                case "Friday": displayDate = "Pátek "; break;
                case "Saturday": displayDate = "Sobota "; break;
                case "Sunday": displayDate = "Neděle "; break;
            }

            displayDate += DateTime.Now.Date.Day.ToString() + "." + DateTime.Now.Date.Month.ToString() + "." + DateTime.Now.Date.Year.ToString();

            DateLabel.Text = displayDate;
            TimeLabel.Text = DateTime.Now.TimeOfDay.Hours.ToString("00") + ":" + DateTime.Now.TimeOfDay.Minutes.ToString("00") + ":" + Math.Round((double)DateTime.Now.TimeOfDay.Seconds).ToString("00");
        }

    }
}

