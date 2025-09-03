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
            };

            switch (AuthorBox.Text) 
            {
                case "Kateřina Havránková": log.author = Author.Katerina; break;
                case "Soňa Zahradníková": log.author = Author.Sona; break;
                case "David Vykukal": log.author = Author.David; break;
                case "Jakub Beránek": log.author = Author.Jakub; break;
            }

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

            Button button = log.CreateLogButton(log.title);
            if (log.locked == false) { }
            LogPanel.Controls.Add(button);
            button.Click += log.TryOpenLog;
        }

    }
}
