using Logbook.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Logbook
{
    public partial class Logbook : Form
    {
        public Logbook()
        {
            InitializeComponent();
        }

        #region Object methods
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        #endregion

        #region Auxilliary methods

        public void SaveLog(string logName, Log log)
        {
            string savePath = Path.Combine("Content", logName);

            string LogJSON = JsonConvert.SerializeObject(log, Formatting.Indented);
            File.WriteAllText(savePath, LogJSON);
    }
        public void LoadLog(string filePath)
        {
            Log log = JsonConvert.DeserializeObject<Log>(filePath);
            log.Init();
        }

        #endregion

    }
}
