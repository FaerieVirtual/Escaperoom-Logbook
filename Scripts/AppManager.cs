using Logbook.Properties;
using Newtonsoft.Json;
using System;
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

        private static int Ticks = 0;
        private static int PromptThreshold = 5340;
        private static int RestartThreshold = 5400;
        private static bool Restarting = false;

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
                if (CurrentUser != null)
                {
                    if ((log.author == CurrentUser.name && log.title != "Vítejte!") || CurrentUser.auth == Authorization.Admin)
                    {
                        Logbook.logbook.LogPanel.Controls.Add(log.CreateLogButton());
                    }
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
            Ticks++;

            if (Restarting) return;
            if (Ticks == PromptThreshold)
            {
                string response = Microsoft.VisualBasic.Interaction.InputBox("Čas únikovky vypršel. Pokud nechcete, aby se aplikace restartovala, zadejte heslo k Admin účtu:", "Čas vypršel");
                if (response == "ZachranteKralovnu25")
                {
                    Ticks = 0;
                }
            }

            if (Ticks >= RestartThreshold)
            {
                Restarting = true;
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}

