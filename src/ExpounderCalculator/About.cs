using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpounderCalculator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gmail.com");
        }

        private void linklblSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.azerbaycan.ir");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
