using Logbook.Properties;
using System;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
        }
        
        private void OnLoad(object sender, EventArgs e) 
        {
            HintBox.Text = log.hint;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text != log.password)
            {
                WarningLabel.Text = "Heslo není správné.";
                return;
            }

            log.locked = false;
            Logbook.logbook.SetLogDisplay();
            log.LoadToUI();

            Close();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HiddenButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
                Refresh();
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
                Refresh();
            }
        }
    }
}
