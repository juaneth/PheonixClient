using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CommieClient
{
    public partial class CommieClientHome : Form
    {
        public CommieClientHome()
        {
            InitializeComponent();
        }

        private void CommieClientHome_Load(object sender, EventArgs e)
        {
            if (File.Exists("cfg.comclient"))
            {
                string cfg = File.ReadLines("cfg.comclient").Skip(0).Take(1).First();
            }
            else
            {
                return;
            }
        }
    }
}
