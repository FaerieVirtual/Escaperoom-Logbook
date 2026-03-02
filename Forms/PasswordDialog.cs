using System.Windows.Input;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Logbook.Forms
{
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
            AcceptButton = OKButton;
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
            DialogResult = DialogResult.OK;

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
