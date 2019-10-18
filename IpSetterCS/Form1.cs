using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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
            MessageBox.Show("This is a down and dirty way for me to change my Ip address from DHCP to STATIC and back, while working on PLC's, Cameras and other equiptment at work", "About IP Setter v0.0.1.0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }


        private void BtnSetIP_Click(object sender, EventArgs e)
        {


    

        }
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            // in order to get a wireless IPaddress use the follwoing code
            //GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            //in order to get the ethernet ip address use the following code
            //GetLocalIPv4(NetworkInterfaceType.Ethernet);
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
    }
    }