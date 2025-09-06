using Logbook.Forms;
using Logbook.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class Log
{
    public string title;
    public bool locked;
    public string password;
    public string hint;
    public string author;
    public string date, time;
    public string[] content;


    public void OpenLog(object sender, EventArgs e)
    {
        Open();
    }

    public void Open()
    {
        if (locked)
        {
            PasswordDialog passwordDialog = new PasswordDialog()
            {
                log = this
            };
            passwordDialog.LogTitleBox.Text = title;
            passwordDialog.HintBox.Text = hint;
            passwordDialog.ShowDialog();
        }
        else
        {
            if (Form.ActiveForm is Logbook.Logbook logbook)
            {
                logbook.ShowLog();
                logbook.LogTitle.Text = title;
                logbook.AuthorBox.Text = "Autor: " + author;
                logbook.DateTimeBox.Text = date + ", " + time;
            }
            foreach (string i in content)
            {
                if (File.Exists(i)) 
                { 
                    string type = i.Substring(i.LastIndexOf('.'));
                    if (type == ".png" || type == ".jpeg") 
                    { 
                        
                    }
                    if (type == ".mp3" || type == ".aiff") 
                    { 
                    
                    }
                }
            }

        }
    }

    public Button CreateLogButton(string name)
    {
        Button button = new Button()
        {
            Width = 314,
            Height = 74,
            Name = name + "LogButton",
            Text = name,
            Enabled = true,
            ForeColor = Color.Black,
            UseVisualStyleBackColor = true,
            Cursor = Cursors.Hand,
            TextAlign = ContentAlignment.MiddleCenter
        };
        return button;
    }

    public Button CreateLockButton(string name, bool locked)
    {
        Button button = new Button()
        {
            Width = 74,
            Height = 74,
            Name = name + "LockButton",
            Text = "",
            Enabled = true,
            ForeColor = Color.Black,
            UseVisualStyleBackColor = true,
            Cursor = Cursors.Hand,
            BackgroundImageLayout = ImageLayout.Zoom,
            ImageAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill

        };
        if (locked) { button.BackgroundImage = Resources.locked; }
        else { button.BackgroundImage = Resources.unlocked; }

        return button;
    }
}
