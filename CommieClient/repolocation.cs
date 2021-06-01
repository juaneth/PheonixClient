using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CommieClient
{
    public partial class repolocation : Form
    {
        public repolocation()
        {
            InitializeComponent();
        }

        private void CommieClientHome_Load(object sender, EventArgs e)
        {
            if (File.Exists("cfg.comclient"))
            {
                string firsttime = File.ReadLines("cfg.comclient").Skip(0).Take(1).First();

                if (firsttime == "FirstTime= 1")
                {
                    this.Hide();

                }
            }
            else
            {
                return;
            }
        }
    }
}
