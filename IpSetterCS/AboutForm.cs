using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpSetterCS
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            LblVersion.Text = "version: " + Application.ProductVersion.ToString();
            String AboutInfo = "A tool to adjust IP Address and Subnet mask I use for working with PLC's and Cameras at work. \n\nFind the source code on GitHub : https://github.com/kennyquast/IpSetterCS \n\nClick the GitHub Button below to access the source code.";
            AboutTextBox1.Text = AboutInfo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }



        private void BtnGithub_Click(object sender, EventArgs e)
        {
            GotoGitHub();
            Hide();
        }
        private void GotoGitHub()
        {
            string target = "https://github.com/kennyquast/IpSetterCS";
            System.Diagnostics.Process.Start(target);

        }


    }
}
