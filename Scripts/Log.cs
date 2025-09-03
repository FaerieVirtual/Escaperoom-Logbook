using Logbook;
using Logbook.Properties;
using Logbook.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

public class Log
{
    public string title;
    public bool locked;
    public string password;
    public string hint;
    public Author author;
    public string date, time;
    public string content;


    public void TryOpenLog(object sender, EventArgs e)
    {
        if (locked)
        {
            PasswordDialog passwordDialog = new PasswordDialog()
            {
                log = this,
            };
            passwordDialog.ShowDialog();
        }      
    }

    public Button CreateLogButton(string name)
    {

        Button button = new Button()
        {
            Width = 350,
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
