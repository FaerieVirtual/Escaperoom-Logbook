using Logbook.Properties;
using Logbook.Scripts;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class AddAccountDialog : Form
    {
        private string pic;
        public AddAccountDialog()
        {
            InitializeComponent();
            AcceptButton = OKButton;
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
                profile = pic,
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            ofd.AddExtension = true;
            ofd.Filter = "All files (*.*)|*.*|PNG soubory (*.png)|*.png|JPEG soubory (*.jpeg)|*.jpeg|JPG soubory (*.jpg)|*.jpg";
            ofd.Title = "Vyberte soubor:";

            DialogResult success = ofd.ShowDialog();

            if (success == DialogResult.Cancel) return;

            string fileName = ofd.FileName;
            string destinationPath = Path.Combine(Paths.Images, Path.GetFileName(fileName));

            File.Copy(fileName, destinationPath, true);
            PicButton.Text = Path.GetFileName(fileName);

            pic = Path.GetFileName(fileName);
        }
    }
}
