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

        private string appPath = Application.StartupPath;
        private void CommieClientHome_Load(object sender, EventArgs e)
        {
            

            //check if config file exists
            if (File.Exists("cfg.comclient"))
            {
                //take first line of config
                string firsttime = File.ReadLines("cfg.comclient").Skip(0).Take(1).First();
                //if config is true for the first line then swap this for the normal ui with alll the games and store
                if (firsttime == "FirstTime= 1")
                {
                    this.Hide();
                    cmclient f2 = new cmclient();
                    f2.ShowDialog();
                    this.Close();
                }
                //if false then let the user input the repo file location
                else
                {
                    this.Show();
                }
            }
            //if config file doesnt exist (very bad) then say to the user that its fucked and that they need to reinstall whole application, maybe could make it repair itself but too lazy rn
            else
            {
                MessageBox.Show("so erm commie client kinda is broke, so please delete the whole installation folder and reinstall");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2)
            {
                TextWriter txt = new StreamWriter("savedrepo.comclient");
                txt.Write(textBox1.Text);
                txt.Close();
            }
            else
            {
                TextWriter txt = new StreamWriter("savedrepo.comclient");
                txt.Write(appPath);
                txt.Close();
            }
        }
    }
}
