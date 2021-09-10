using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.IO.Compression;

namespace CommieClient
{
    public partial class cmclient : Form
    {
        public cmclient()
        {
            InitializeComponent();
        }

        private void cmclient_Load(object sender, EventArgs e)
        {
            //App Startup Path
            string appPath = Application.StartupPath;
            //grab where the fuck the repo is
            try
            {
                string repolocation = File.ReadLines("savedrepo.comclient").Skip(0).Take(1).First();
                File.Copy(repolocation, appPath + "activerepo.zip");
                if (!File.Exists(appPath + "0001"))
                {
                    ZipFile.ExtractToDirectory(appPath + "activerepo.zip", appPath + "activerepo");
                }
                else
                {
                    Directory.Delete(appPath + "activerepo");
                    ZipFile.ExtractToDirectory(appPath + "activerepo.zip", appPath + "activerepo");
                }
            }
            catch
            {
                MessageBox.Show("repofile not found");
            }
        }

        private void cmclient_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button_woc3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}