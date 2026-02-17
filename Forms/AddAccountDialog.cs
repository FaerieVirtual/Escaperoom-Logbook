using Logbook.Properties;
using Logbook.Scripts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class AddAccountDialog : Form
    {
        public AddAccountDialog()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                WarningLabel.Text += "Jméno nemůže být prázdné\n";
                return;
            }
            if (passwordBox.Text == "")
            {
                WarningLabel.Text += "Heslo nemůže být prázdné\n";
                return;
            }

            Account account = new()
            {
                name = NameBox.Text,
                password = passwordBox.Text,
                hint = hintBox.Text,
                auth = Authorization.User,
                logged = false,

            };

            ToolStripMenuItem button = new()
            {
                Image = Resources.pass,
                Name = account.name + "Button",
                Size = new Size(332, 26),
                Text = account.name,
            };

            button.Click += (sender, e) => Logbook.logbook.LogInAccount(account);

            Logbook.logbook.accounts.Insert(0, account);
            Logbook.logbook.Account_button.DropDownItems.Add(button);

            account.SaveAccount();

            Close();
        }

        private void HiddenButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == true)
            {
                passwordBox.UseSystemPasswordChar = false;
                Refresh();
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
                Refresh();
            }
        }
    }
}
