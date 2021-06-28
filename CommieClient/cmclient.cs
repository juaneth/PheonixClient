using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

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
            string repolocation = File.ReadLines("savedrepo.comclient").Skip(0).Take(1).First();

            //Unpack repo file
            //rename
            File.Move(repolocation, appPath + "repofile.zip");
        }
    }
}
