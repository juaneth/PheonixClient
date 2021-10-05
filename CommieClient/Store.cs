using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PheonixClient
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private int offset;

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void button_woc5_Click(object sender, EventArgs e)
        {
            offset++;
        }

        private void button_woc6_Click(object sender, EventArgs e)
        {
            offset--;
        }
    }
}
