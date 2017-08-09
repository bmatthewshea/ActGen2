using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActGen
{
    public partial class ActGenAboutForm : Form
    {
        public ActGenAboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_about_contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //linkLabel_about_contact.Links.Add(0, 20, "");
            System.Diagnostics.Process.Start("mailto:actgen@holylinux.net");
        }

        private void button_about_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_about_donate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=MD9LTWS5DAXBG&lc=US&item_name=Shea%20Computers%20%26%20Networking&item_number=actgen&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donate_LG%2egif%3aNonHosted");
        }

        private void linkLabel_about_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.holylinux.net/code/actgen");
        }
    }
}
