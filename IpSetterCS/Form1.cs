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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a down and dirty way for me to change my Ip address from DHCP to STATIC and back, while working on PLC's, Cameras and other equiptment at work", "About IP Setter v0.0.0.1");
        }
    }



}

