using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class CreateLogdialog : Form
    {
        public CreateLogdialog()
        {
            InitializeComponent();
            AcceptButton = OKButton;
        }
        public bool privated;
        public Log log;

        public Log CreateLog()
        {
            FlowLayoutPanel LogPanel = Logbook.logbook.LogPanel;
            log = new()
            {
                title = TitleBox.Text,
                password = PasswordBox.Text,
                hint = HintBox.Text,
                date = DateBox.Text,
                time = TimeBox.Text,
                author = AuthorBox.Text,
                privated = privated
            };

            if (PasswordBox.Text == "")
            {
                log.password = "";
                log.locked = false;
            }
            else
            {
                log.password = PasswordBox.Text;
                log.locked = true;
            }

            if (!privated)
            {
                Button logbutton = log.CreateLogButton();
                LogPanel.Controls.Add(logbutton);
            }

            return log;
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            if (TitleBox.Text == "") { WarningLabel.Text = WarningLabel.Text + "Titul nemůže být prázdný!"; return; }
            if (AuthorBox.Text == "") { WarningLabel.Text = WarningLabel.Text + "\n Autor nemůže být prázdný!"; return; }

            Log log = CreateLog();
            Logbook.logbook.logs.Add(log);
            Close();
        }

        private void PrivateButton_Click(object sender, System.EventArgs e)
        {
            if (!privated)
            {
                PrivateButton.BackColor = System.Drawing.SystemColors.ControlDark;
                privated = true;
            }
            else
            {
                PrivateButton.BackColor = System.Drawing.SystemColors.Control;
                privated = false;
            }
        }
    }
}
