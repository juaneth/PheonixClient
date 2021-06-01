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
            //If cfg file exists
            if (File.Exists("cfg.comclient"))
            {
                string firsttime = File.ReadLines("cfg.comclient").Skip(0).Take(1).First();

                if (firsttime == "FirstTime= 1")
                {
                    this.Hide();
                    cmclient f2 = new cmclient();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("so erm commie client kinda is broke, so please delete the whole installation folder and reinstall");
            }
        }
    }
}
