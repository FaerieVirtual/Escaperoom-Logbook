using Logbook.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Logbook.Scripts
{
    public class Account
    {
        public bool logged;
        public string name;
        public string password;
        public string hint;
        public Authorization auth;

        public LogInSuccess LogIn()
        {
            if (!logged)
            {
                LogInDialog login = new();
                login.HintBox.Text = hint;
                login.NameBox.Text = name;
                login.ShowDialog();

                if (login.NameBox.Text != name) return LogInSuccess.Failure;
                if (login.passwordBox.Text != password) return LogInSuccess.IncorrectPassword;
            }
            else
            {
                PrivatizeAll();
                if (auth == Authorization.Admin)
                {
                    foreach (Log log in Logbook.logbook.logs)
                    {
                        if (log.privated)
                        {
                            FlowLayoutPanel LogPanel = Logbook.logbook.LogPanel;

                            ProduceButton(log);
                        }
                    }

                }
                else
                {
                    foreach (Log log in Logbook.logbook.logs)
                    {
                        if (log.privated && log.author == name)
                        {
                            FlowLayoutPanel LogPanel = Logbook.logbook.LogPanel;

                            ProduceButton(log);
                        }
                    }
                }
                logged = true;
                return LogInSuccess.Success;
            }

            return LogInSuccess.Success;
        }

        public void LogOut()
        {
            foreach (Log log in Logbook.logbook.logs)
            {
                if (log.author == name || log.privated)
                {
                    Button btn = log.CreateLogButton();
                    Logbook.logbook.LogPanel.Controls.Remove(btn);
                }
            }
            logged = false;
        }

        public void SaveAccount()
        {
            string JSON = JsonConvert.SerializeObject(this);
            string path = Path.Combine("Content", "Accounts");
            if (!Path.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllText(Path.Combine(path, name + ".json"), JSON);
        }

        private void PrivatizeAll()
        {
            foreach (Log log in Logbook.logbook.logs)
            {
                if (log.privated)
                {
                    foreach (Control ctrl in Logbook.logbook.LogPanel.Controls)
                    {
                        if (ctrl.Name == log.title)
                        {
                            ctrl.Visible = false;
                            ctrl.Enabled = false;
                        }
                    }
                }
            }
        }

        private void ProduceButton(Log log)
        {
            bool found = false;

            foreach (Control ctrl in Logbook.logbook.LogPanel.Controls)
            {
                if (ctrl.Name == log.title)
                {
                    ctrl.Visible = true;
                    ctrl.Enabled = true;
                    found = true;
                }
            }
            if (!found)
            {
                Logbook.logbook.LogPanel.Controls.Add(log.CreateLogButton());
            }
        }
    }

    public enum LogInSuccess
    {
        Success,
        IncorrectPassword,
        Failure
    }

    public enum Authorization
    {
        None,
        User,
        Admin
    }
}