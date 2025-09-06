using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook.Forms
{
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == log.password) 
            {
                log.locked = false;
                log.OpenLog();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
