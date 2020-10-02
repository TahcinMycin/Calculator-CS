//https://youtu.be/K7l1OGHNfeE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class About2 : Form
    {
        public About2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 200);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LinkLabel dynamicLinkLabel = new LinkLabel();
            //https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/
            dynamicLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/");
        }
    }
}
