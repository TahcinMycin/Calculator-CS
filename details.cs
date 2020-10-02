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
    public partial class details : Form
    {
        public details()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void details_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 200);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LinkLabel dynamicLinkLabel = new LinkLabel();
            //https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/
            dynamicLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LinkLabel dynamicLinkLabel = new LinkLabel();
            dynamicLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://visualstudio.microsoft.com/vs/community/");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LinkLabel dynamicLinkLabel = new LinkLabel();
            dynamicLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet-framework");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
