using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class CreateLogdialog : Form
    {
        public CreateLogdialog()
        {
            InitializeComponent();
        }


        public void CreateLog(FlowLayoutPanel LogPanel)
        {
            Log log = new Log()
            {
                title = TitleBox.Text,
                password = PasswordBox.Text,
                hint = HintBox.Text,
                date = DateBox.Text,
                time = TimeBox.Text,
                author = AuthorBox.Text
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

            Button lockbutton = log.CreateLockButton(log.title, log.locked);
            LogPanel.Controls.Add(lockbutton);
            lockbutton.Click += log.OpenLog;

            Button logbutton = log.CreateLogButton(log.title);
            LogPanel.Controls.Add(logbutton);
            logbutton.Click += log.OpenLog;
        }

    }
}
