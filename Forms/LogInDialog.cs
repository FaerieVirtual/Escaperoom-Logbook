using Logbook.Scripts;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class LogInDialog : Form
    {
        private Account account;

        public LogInDialog(Account acc)
        {
            InitializeComponent();
            account = acc;
            AcceptButton = OKButton;
        }
        public void OnLoad(object sender, EventArgs e)
        {
            string path = Path.Combine(Paths.Images, account.profile);
            if (account != null && path != null)
            {
                Profilebox.Image = Image.FromFile(path);
            }
            NameBox.Text = account.name;
            HintBox.Text = account.hint;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == account.password)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                WarningLabel.Text = "Toto heslo nesedí k tomuto účtu. Zkontrolujte si kapitalizaci.";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void HiddenButton_Click(object sender, EventArgs e)
        {
            if (!passwordBox.UseSystemPasswordChar)
            {
                passwordBox.UseSystemPasswordChar = true;
                passwordBox.BackColor = SystemColors.Control;
            }
            else 
            {
                passwordBox.UseSystemPasswordChar = false;
                passwordBox.BackColor = SystemColors.ControlDark;
            }
        }
    }
}
