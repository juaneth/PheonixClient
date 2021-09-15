using System;
using System.IO;
using System.Windows.Forms;

namespace PheonixClient
{
    public partial class repolocation : Form
    {
        public repolocation()
        {
            InitializeComponent();
        }

        public string[] config = { };
        public string repofile = "";

        private void CommieClientHome_Load(object sender, EventArgs e)
        {
            try
            {
                config = File.ReadAllLines("config.commie");
            }
            catch
            { 
                MessageBox.Show("Config file not available, this could be due to an issue of where CM is installed, file permissions or our server where our backup config is located. Please reinstall CM to get this issue fixed.\n\nSorry for this inconvenience"); 
            }
        }

		private void button_woc1_Click(object sender, EventArgs e)
		{
            if (textBox1.Text.Length > 2)
            {
                TextWriter txt = new StreamWriter("savedrepo.comclient");
                txt.Write(textBox1.Text);
                txt.Close();

                TextWriter s = new StreamWriter("cfg.comclient");
                s.Write("FirstTime= 1");
                s.Close();

                this.Hide();
                cmclient f2 = new cmclient();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                TextWriter txt = new StreamWriter("savedrepo.comclient");
                txt.Write("testgame1.comclient");
                txt.Close();

                //Write to config
                TextWriter s = new StreamWriter("cfg.comclient");
                s.Write("FirstTime= 1");
                s.Close();

                //Open Main Page
                this.Hide();
                cmclient f2 = new cmclient();
                f2.ShowDialog();
                this.Close();
            }
        }
    }
}
