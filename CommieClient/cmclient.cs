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
            //Download Testing:
            //say that its a dev test thing
            MessageBox.Show("This is a dev version with no repo, this just downloads the communist manifesto, click 'OK' to continue");
            //grab where the fuck the repo is
            string repolocation = File.ReadLines("savedrepo.comclient").Skip(0).Take(1).First();
            //grab download link from where the fuck the repo is
            string dl = File.ReadLines(repolocation).Skip(5).Take(1).First();
            //show where its downloading from for debugging
            MessageBox.Show(dl);
            //get filename from repo file too
            string filenamefromrepo = ("downloads/" + File.ReadLines(repolocation).Skip(4).Take(1).First());
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

            //Load UI
            //First Panel's shite
            string itemname = File.ReadLines(repolocation).Skip(0).Take(1).First();
            name1.Text = itemname;
            string itemid = "Item ID: " + File.ReadLines(repolocation).Skip(3).Take(1).First();
            idtext1.Text = itemid;

            //Second Panel's shite
            string itemname2 = File.ReadLines(repolocation).Skip(7).Take(1).First();
            name2.Text = itemname2;
            string itemid2 = "Item ID: " + File.ReadLines(repolocation).Skip(10).Take(1).First();
            idtext2.Text = itemid2;

            //Third Panel's shite
            string itemname3 = File.ReadLines(repolocation).Skip(14).Take(1).First();
            name3.Text = itemname3;
            string itemid3 = "Item ID: " + File.ReadLines(repolocation).Skip(17).Take(1).First();
            idtext3.Text = itemid3;

            //Fourth Panel's shite
            string itemname4 = File.ReadLines(repolocation).Skip(21).Take(1).First();
            name4.Text = itemname4;
            string itemid4 = "Item ID: " + File.ReadLines(repolocation).Skip(24).Take(1).First();
            idtext4.Text = itemid4;

            //Fifth Panel's shite
            string itemname5 = File.ReadLines(repolocation).Skip(28).Take(1).First();
            name5.Text = itemname5;
            string itemid5 = "Item ID: " + File.ReadLines(repolocation).Skip(31).Take(1).First();
            idtext5.Text = itemid5;

            //Second Panel's shite
            string itemname6 = File.ReadLines(repolocation).Skip(35).Take(1).First();
            name6.Text = itemname6;
            string itemid6 = "Item ID: " + File.ReadLines(repolocation).Skip(38).Take(1).First();
            idtext6.Text = itemid6;

            //Third Panel's shite
            string itemname7 = File.ReadLines(repolocation).Skip(42).Take(1).First();
            name7.Text = itemname7;
            string itemid7 = "Item ID: " + File.ReadLines(repolocation).Skip(45).Take(1).First();
            idtext7.Text = itemid7;

            //Fourth Panel's shite
            string itemname8 = File.ReadLines(repolocation).Skip(49).Take(1).First();
            name8.Text = itemname8;
            string itemid8 = "Item ID: " + File.ReadLines(repolocation).Skip(52).Take(1).First();
            idtext8.Text = itemid8;
        }
    }
}
