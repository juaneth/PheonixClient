using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;

namespace PheonixClient
{
    public partial class cmclient : Form
    {
        public cmclient()
        {
            InitializeComponent();
        }

        private void cmclient_Load(object sender, EventArgs e)
        {
            var repo = "";
        }


        //Rounded panels stuff, idk if I want to even use it ->
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            var cfg = File.ReadAllLines("cfg.comclient");

             Graphics v = e.Graphics;
             DrawRoundRect(v, Pens.WhiteSmoke, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
             base.OnPaint(e);
        }

        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            var cfg = File.ReadAllLines("config.commie");

            if (cfg[6] == "lowsight")
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