using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook.Resources
{
    public partial class PasswordDialog : Form
    {
        public Log log;
        public PasswordDialog()
        {
            InitializeComponent();
            HintContentBox.Text = log.hint;
        }

        private void HiddenButton_Click(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !passwordBox.UseSystemPasswordChar;
            if (!passwordBox.UseSystemPasswordChar) { HiddenButton.BackColor = SystemColors.ButtonShadow; }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == log.password) 
            {
                log.locked = false;
                Close();
            }
            else 
            { 
                WarningBox.ForeColor = Color.Red;
                WarningBox.Text = "Nesprávné heslo!";
            }
        }

    }
}
