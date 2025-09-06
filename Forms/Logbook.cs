using Logbook.Forms;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace Logbook
{
    public partial class Logbook : Form
    {
        public Logbook()
        {
            InitializeComponent();
        }

        public Account CurrentAccount;
        public LogMode mode;

        public Control selectedControl;
        public Log selectedLog;

        #region Log Management

        public void SaveLog(string logName, Log log)
        {
            string savePath = Path.Combine("Content", logName);

            string LogJSON = JsonConvert.SerializeObject(log, Formatting.Indented);
            File.WriteAllText(savePath, LogJSON);
        }
        public void LoadLog(string filePath)
        {
            Log log = JsonConvert.DeserializeObject<Log>(filePath);

            Button button = log.CreateLogButton(log.title);
            LogPanel.Controls.Add(button);
            if (log.locked == false) { button.Image = Properties.Resources.unlocked; }
            button.Click += log.OpenLog;
        }

        public void AddLog()
        {

        }

        public void ShowLog()
        {
            foreach (Control control in Controls)
            {
                if (control != null && ((string)control.Tag == "MessageDisplay" || (string)control.Tag == "HomeDisplay"))
                {
                    control.Enabled = false;
                    control.Visible = false;
                }
                if (control != null && (string)control.Tag == "LogDisplay")
                {
                    control.Enabled = true;
                    control.Visible = true;
                }
            }
        }

        public void AddImage(string filePath)
        {
            if (File.Exists(filePath))
            {
                PictureBox pictureBox = new PictureBox()
                {
                    BackgroundImage = Image.FromFile(filePath),
                    BackgroundImageLayout = ImageLayout.Zoom
                };
                ContentPanel.Controls.Add(pictureBox);
            }
            else
            {
                MessageBox.Show("Vložení souboru selhalo z nenámých důvodů.Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddTextfield(string content = null)
        {
            TextBox textBox = new TextBox()
            {
                Multiline = true,
                BorderStyle = BorderStyle.None,
                Font = new Font("Courier New", 14),
                ReadOnly = false
            };

            if (content != null) 
            { 
                textBox.Text = content;
            }
            ContentPanel.Controls.Add(textBox);
        }

        public void AddAudioRecording() 
        {
            }

        }

        #endregion

        #region Toolbar
        private void Home_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control != null && ((string)control.Tag == "LogDisplay" || (string)control.Tag == "MessageDisplay"))
                {
                    control.Enabled = false;
                    control.Visible = false;
                }
                if (control != null && (string)control.Tag == "HomeDisplay")
                {
                    control.Enabled = true;
                    control.Visible = true;
                }
            }
        }
        private void Add_TextClick(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {
                AddTextfield();
            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Add_AudioClick(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {
                string filePath;
                string fileName;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.AddExtension = true;
                    ofd.Filter = "MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav|AIFF files (*.aiff)|*.aiff";
                    ofd.Title = "Choose a file:";

                    DialogResult success = ofd.ShowDialog();

                    if (success == DialogResult.Cancel) return;

                    AudioFileReader reader;

                    filePath = ofd.FileName;
                    fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(@"..\..\..\songs", fileName);
                    if (File.Exists(filePath))
                    {
                        reader = new(ofd.FileName);
                        try
                        {
                            if (!Directory.Exists(@"..\..\..\songs")) { Directory.CreateDirectory(@"..\..\..\songs"); }
                            File.Copy(filePath, destinationPath);
                            MessageBox.Show($"File was imported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch
                        {
                            MessageBox.Show("File import failed for unknown reasons.", "Something went wrong! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The path to this file could not be found.", "Something went wrong! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Button button = CreateButton(fileName);
                    Song newSong = new(destinationPath, fileName, button);

                    songs.Add(newSong);
                    songLayoutPanel.Controls.Add(button);
                    newSong.button.Click += AudioButton_Click;

                }



            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Add_ImageClick(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {
                string filePath;
                string fileName;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.AddExtension = true;
                    ofd.Filter = "PNG soubory (*.png)|*.png|JPEG soubory (*.jpeg)|*.jpeg";
                    ofd.Title = "Vyberte soubor:";

                    DialogResult success = ofd.ShowDialog();

                    if (success == DialogResult.Cancel) return;

                    filePath = ofd.FileName;
                    fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine("Content", fileName);
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            if (!Directory.Exists("Content")) { Directory.CreateDirectory("Content"); }
                            File.Move(filePath, destinationPath);
                        }
                        catch
                        {
                            MessageBox.Show("Vložení souboru selhalo z nenámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vložení souboru selhalo z nenámých důvodů. Ujistěte se, že vybíráte správný typ souboru.", "Něco se pokazilo! :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                AddImage(filePath);
            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Del_button_Click(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {

            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Paste_button_Click(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {
            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {
            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (mode == LogMode.Edit)
            {
            }
            else
            {
                MessageBox.Show("Nelze upravit protokol v režimu čtení. Pokud chcete přidávat a upravovat protokoly, přihlaste se a zapněte režim úprav.", "Úprava v režimu čtení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            Read_button.BackColor = SystemColors.ControlDark;
            Edit_button.BackColor = SystemColors.ControlLight;

            mode = LogMode.Read;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (CurrentAccount.authorization == Authorization.Admin)
            {
                Read_button.BackColor = SystemColors.ControlLight;
                Edit_button.BackColor = SystemColors.ControlDark;

                mode = LogMode.Edit;
            }
            else
            {
                MessageBox.Show("Nelze přepnout do režimu úprav. Nemáte dostatečné oprávnění. Obraťte se na správce systému.", "Nedostatečné oprávnění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void Mail_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control != null && ((string)control.Tag == "LogDisplay" || (string)control.Tag == "HomeDisplay"))
                {
                    control.Enabled = false;
                    control.Visible = false;
                }
                if (control != null && (string)control.Tag == "MessageDisplay")
                {
                    control.Enabled = true;
                    control.Visible = true;
                }
            }

        }
        private void KaterinaAccButton_Click(object sender, EventArgs e)
        {
            LogInDialog login = new LogInDialog();
            login.NameBox.Text = "Kateřina Havránková";

        }

        private void SonaAccButton_Click(object sender, EventArgs e)
        {

        }

        private void DavidAccButton_Click(object sender, EventArgs e)
        {

        }

        private void JakubAccButton_Click(object sender, EventArgs e)
        {

        }

        private void AddAccButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        public void Clock_Update()
        {

        }







        private void Logbook_Load(object sender, EventArgs e)
        {

        }


    }
}

public enum Authorization
{
    None,
    Scientist,
    Admin
}

public enum LogMode
{
    Read,
    Edit
}
