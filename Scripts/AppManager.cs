using Logbook.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logbook.Scripts
{
    public static class AppManager
    {
        public static Account CurrentUser = null;
        public static List<Account> Accounts = [];
        public static bool IsAdmin => CurrentUser?.auth == Authorization.Admin;


        public static Log CurrentLog = null;
        public static List<Log> Logs = [];

        public static int Ticks;

        public static void Initialize()
        {
            LoadAllAccounts();
            LoadAllLogs();
        }

        public static void SetCurrentUser(Account acc)
        {
            CurrentUser = acc;
        }

        public static void SwitchUser(Account newUser)
        {
            if (CurrentLog != null)
            {
                CurrentLog.SaveFromUI();
                CurrentLog.WriteToDisk();
            }

            ClearScreen();
            SetCurrentLog(null);
            Logbook.logbook.SetHomeDisplay();

            SetCurrentUser(newUser);

            ReloadLogs();

            Logbook.logbook.Account_button.Text = newUser.name;
        }

        public static void SetCurrentLog(Log log)
        {
            CurrentLog = log;
        }

        public static void ClearScreen()
        {
            Logbook logbook = Logbook.logbook;
            logbook.LogPanel.Controls.Clear();
            logbook.ContentPanel.Controls.Clear();
            logbook.AuthorBox.Text = "";
            logbook.DateTimeBox.Text = "";
            logbook.LogTitle.Text = "";
            logbook.ProfileBox.Image = Resources.pass;
        }

        public static void ResetApp()
        {
            ClearScreen();
            Logbook.logbook.SetHomeDisplay();
            Logbook.logbook.Account_button.Text = "Přihlásit se";
            CurrentLog = null;
            CurrentUser = null;

            foreach(Log log in Logs)
            {
                log.locked = true;
            }
            foreach(Account account in Accounts)
            {
                account.locked = true;
            }
            ReloadLogs();
            Logbook.logbook.LogPanel.Controls.Add(Logs.Find(log => log.title == "Vítejte!").CreateLogButton());
        }

        public static void LoadAllLogs()
        {
            foreach (var file in Directory.GetFiles(Paths.Logs, "*.json"))
            {
                string json = File.ReadAllText(file);
                Log log = JsonConvert.DeserializeObject<Log>(json);

                Logs.Add(log);
            }
        }
        public static void ReloadLogs()
        {
            foreach (Log log in Logs)
            {
                if ((log.author == CurrentUser.name && log.title != "Vítejte!") || CurrentUser.auth == Authorization.Admin)
                {
                    Logbook.logbook.LogPanel.Controls.Add(log.CreateLogButton());
                }
            }
        }

        public static void LoadAllAccounts()
        {
            foreach (var file in Directory.GetFiles(Paths.Accounts, "*.json"))
            {
                string json = File.ReadAllText(file);
                Account acc = JsonConvert.DeserializeObject<Account>(json);

                Accounts.Add(acc);
                ToolStripMenuItem button = new()
                {
                    Image = Resources.pass,
                    Name = acc.name + "Button",
                    Size = new Size(332, 26),
                    Text = acc.name,
                };

                button.Click += (sender, e) => acc.LogIn();
            }
        }
        public static void Tick() 
        {
            Ticks += 1;

            if (Ticks >= 5400)
            {
                ResetApp();
            }
        }
    }
}

