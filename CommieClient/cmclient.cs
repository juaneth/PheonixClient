using System;
using System.Windows.Forms;
using System.Net;
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
            //say that its a dev test thing
            MessageBox.Show("This is a dev version with no repo, this just downloads the communist manifesto, click 'OK' to continue");
            //grab where the fuck the repo is
            string repolocation = File.ReadLines("savedrepo.comclient").Skip(0).Take(1).First();
            //grab download link from where the fuck the repo is
            string dl = File.ReadLines(repolocation).Skip(5).Take(1).First();
            //show where its downloading from for debugging
            MessageBox.Show(dl);
            //get filename from repo file too
            string filenamefromrepo = File.ReadLines(repolocation).Skip(4).Take(1).First();
            //download file from repo
            using (WebClient downloadclient = new WebClient())
            {
                downloadclient.DownloadFileAsync(
                    //download link
                    new System.Uri(dl),
                    //save to filename
                    filenamefromrepo
                );
            }
        }
    }
}
