using Logbook.Scripts;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class LogInDialog : Form
    {
        public LogInDialog()
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
            foreach (Account acc in Logbook.logbook.accounts) 
            {
                if (acc.name == NameBox.Text && acc.password == passwordBox.Text)
                {
                    acc.logged = true;
                    PrivatizeAll();
                    if (acc.auth == Authorization.Admin)
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
                            if (log.privated && log.author == acc.name)
                            {
                                FlowLayoutPanel LogPanel = Logbook.logbook.LogPanel;

                                ProduceButton(log);
                            }
                        }
                    }
                    break;
                }
            }

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

        private void PrivatizeAll() 
        { 
            foreach(Log log in Logbook.logbook.logs)
            {
                if(log.privated)
                {
                    foreach(Control ctrl in Logbook.logbook.LogPanel.Controls)
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

            foreach(Control ctrl in Logbook.logbook.LogPanel.Controls)
            {
                if(ctrl.Name == log.title)
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
}
