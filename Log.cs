using Logbook.Properties;
using Logbook.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

public class Log
{
    public string name;
    public bool locked;
    public string password;
    public string inquiry;
    public Author author;
    public string date, time;
    public string content;
    public Button button;

    public Log CreateLog(string name, bool locked, string password, string inquiry, Author author, string date, string time, string content, FlowLayoutPanel LogPanel) 
    { 
        Log log = new Log() 
        { 
            name = name, 
            locked = locked,
            password = password,
            inquiry = inquiry,
            author = author,    
            date = date,
            time = time,
            content = content
        }; 

        button = CreateButton(name);
        LogPanel.Controls.Add(button);  
        if (locked == false) { button.Image = Resources.unlocked; }
        button.Click += TryOpenLog;

        return log;
    }

    private void TryOpenLog(object sender, EventArgs e)
    {
        if (locked)
        {
            PasswordDialog passwordDialog = new PasswordDialog()
            {
                log = this,
                Inquiry = inquiry
            };
            passwordDialog.ShowDialog();
        }      
    }

    public Button CreateButton(string name)
    {
        Button button = new Button()
        {
            Width = 370,
            Height = 70,
            Name = name,
            Text = name,
            Enabled = true,
            ForeColor = Color.Black,
            UseVisualStyleBackColor = true,
            Cursor = Cursors.Hand,
            Image = Resources.locked,
            ImageAlign = ContentAlignment.MiddleLeft
        };
        return button;
    }

}

public enum Author
{ 
    Jakub,
    David,
    Sona,
    Katerina
}
