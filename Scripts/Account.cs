using Logbook.Forms;
using Logbook.Properties;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logbook.Scripts
{
    public class Account
    {
        public bool locked;
        public string name;
        public string password;
        public string hint;
        public Authorization auth;
        public string profile;

        public void LogIn()
        {
            if (locked)
            {
                var dialog = new LogInDialog(this);

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                locked = false;
            }

            AppManager.SetCurrentUser(this);

            AppManager.SwitchUser(this);
        }
        public void SaveAccount()
        {
            string JSON = JsonConvert.SerializeObject(this);

            string file = Path.Combine(Paths.Accounts, name + ".json");

            File.WriteAllText(file, JSON);
        }
    }

    public enum Authorization
    {
        None,
        User,
        Admin
    }
}