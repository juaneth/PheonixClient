using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using static System.Environment;

namespace PheonixClient
{
    public partial class Pheonix : Form
    {
        public Pheonix()
        {
            InitializeComponent();
        }

        private void cmclient_Load(object sender, EventArgs e)
        {
            var config = File.ReadAllLines("config.grosh");

            //Install fonts
            try
            {
                File.Copy("fonts/Apercu-Mono.ttf", Path.Combine(Environment.GetFolderPath(SpecialFolder.Windows), "Fonts", "Apercu-Mono.ttf"));

                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts");
                key.SetValue("Apercu-Mono - Packaged with Pheonix Client", "Apercu-Mono.tff");
                key.Close();

                File.Copy("fonts/Nexa-Regular.ttf", Path.Combine(Environment.GetFolderPath(SpecialFolder.Windows), "Fonts", "Nexa-Regular.ttf"));

                Microsoft.Win32.RegistryKey key2 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts");
                key2.SetValue("Nexa-Regular - Packaged with Pheonix Client", "Nexa-Regular.tff");
                key2.Close();
            }
            catch
            {
                //log to file using log method that fonts already installed

            }

            CheckUpdate();
            DebugLog("Error", "Test Error");

            //Load repo with default repo set in config and page size from repo
            LoadFromRepo(0, 0, config[2], Int32.Parse(config[6]));
        }

        private void CheckUpdate()
        {
            //Checks if theres any changes within the version file hosted on my server
        }

        private void DebugLog(string type, string content)
        {
            Console.WriteLine(type + ": " + content);

            if (!Directory.Exists("/Logs"))
            {
                Directory.CreateDirectory("/Logs");
                Application.Restart();
                Environment.Exit(0);
            }
            if (!File.Exists("/Logs/current.log"))
            {
                File.Create("/Logs/current.log");
                Application.Restart();
                Environment.Exit(0);
            }


            var prevlog = File.ReadLines("/Logs/current.log");
            File.WriteAllText("/Logs/current.log", prevlog + "\n" + type + ": " + content);
        }

        private void LoadFromRepo(int type, int offset, string RepoLocation, int pagelength)
        {
            if(type == 0)
            {
                var repocontent = File.ReadAllLines(RepoLocation);
                var PageCount = repocontent.Length / pagelength;

                
            }
            else if(type == 1)
            {

            }
        }


        //Rounded panels stuff, idk if I want to even use it ->
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
             Graphics v = e.Graphics;
             DrawRoundRect(v, Pens.WhiteSmoke, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 5);
             base.OnPaint(e);
        }

        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            var cfg = File.ReadAllLines("config.grosh");

            if (cfg[4] == "lowsight")
            {
                GraphicsPath gp = new GraphicsPath();
                //Upper-right arc:
                gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                //Lower-right arc:
                gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
                //Lower-left arc:
                gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                //Upper-left arc:
                gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
                gp.CloseFigure();
                g.DrawPath(p, gp);
                gp.Dispose();
            }
            else
            {
                
            }
        }
    }
}