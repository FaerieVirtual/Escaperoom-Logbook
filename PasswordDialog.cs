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
        public string Inquiry;
        public PasswordDialog()
        {
            InitializeComponent();
            passwordInquiryBox.Text = Inquiry;
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
                passwordBox.ForeColor = Color.Red;
                passwordBox.Text = "Nesprávné heslo!";
            }
        }

    }
}
