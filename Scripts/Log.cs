using Logbook.Forms;
using Logbook.Scripts;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class Log
{
    public string title = "";
    public bool locked = false;
    public string password = "";
    public string hint = "";
    public string author = "";
    public string date, time;
    public bool privated = false;

    public List<LogItem> Content = new();

    public void SaveFromUI()
    {
        var logbook = Logbook.Logbook.logbook;

        if (logbook.selectedLog != this)
            return;

        Content.Clear();

        foreach (Control c in logbook.ContentPanel.Controls)
        {
            LogItem item = new();

            switch (c)
            {
                case TextBox tb:
                    item.Type = LogItemType.Text;
                    item.Data = tb.Text;
                    break;

                case PictureBox pb:
                    item.Type = LogItemType.Image;
                    item.Data = pb.Name;
                    break;

                case AudioRecordingStrip ars:
                    item.Type = LogItemType.Audio;
                    item.Data = ars.Name;
                    break;
            }

            Content.Add(item);
        }
    }

    public void WriteToDisk()
    {
        bool wasLocked = locked;

        if (!string.IsNullOrEmpty(password))
            locked = true;

        string json = JsonConvert.SerializeObject(this, Formatting.Indented);

        string file = Path.Combine(Paths.Logs, title + ".json");

        File.WriteAllText(file, json);

        locked = wasLocked;
    }

    public void LoadToUI()
    {
        var logbook = Logbook.Logbook.logbook;

        logbook.LogTitle.Text = title;
        logbook.AuthorBox.Text = "Autor: " + author;
        logbook.DateTimeBox.Text = date + ", " + time;

        foreach (Account acc in logbook.accounts)
        {
            if (author == acc.name)
            {
                if (acc.profile != null) logbook.ProfileBox.BackgroundImage = acc.profile;
            }
        }

        logbook.ContentPanel.Controls.Clear();

        foreach (var item in Content)
        {
            switch (item.Type)
            {
                case LogItemType.Text:
                    logbook.AddTextfield(item.Data);
                    break;

                case LogItemType.Image:
                    logbook.AddImage(item.Data);
                    break;

                case LogItemType.Audio:
                    logbook.AddAudioRecording(item.Data);
                    break;
            }
        }
    }

    public void Open()
    {
        var logbook = Logbook.Logbook.logbook;

        if (logbook.selectedLog != null)
        {
            logbook.selectedLog.SaveFromUI();
            logbook.selectedLog.WriteToDisk();
        }

        logbook.selectedLog = this;

        if (locked)
        {
            PasswordDialog dlg = new() { log = this };
            dlg.LogTitleBox.Text = title;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            locked = false;
        }

        logbook.SetLogDisplay();
        LoadToUI();
    }

    public Button CreateLogButton()
    {
        Button btn = new()
        {
            Text = locked ? $"[🔒] {title}" : $"[🔓] {title}",
            Height = 80,
            Width = Logbook.Logbook.logbook.LogPanel.ClientSize.Width - 20,
            Font = new Font("Courier New", 18),
            Name = title,
            ContextMenuStrip = Logbook.Logbook.logbook.logItemMenu,
            Tag = this
        };

        btn.Click += (s, e) => Open();
        return btn;
    }
}
