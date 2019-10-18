using System;
using System.Management;
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

            SetStaticIP();
            lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);


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
        public void SetStaticIP()
        {
            string myDesc = "Intel(R) Ethernet Connection I217-V";
            //string gateway = "192.168.0.1";
            string subnetMask = "255.255.0.0";
            string address = "10.102.20.254";

            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        // Set DefaultGateway
                        //var newGateway = adapter.GetMethodParameters("SetGateways");
                        //newGateway["DefaultIPGateway"] = new string[] { gateway };
                        //newGateway["GatewayCostMetric"] = new int[] { 1 };

                        // Set IPAddress and Subnet Mask
                        var newAddress = adapter.GetMethodParameters("EnableStatic");
                        newAddress["IPAddress"] = new string[] { address };
                        newAddress["SubnetMask"] = new string[] { subnetMask };

                        adapter.InvokeMethod("EnableStatic", newAddress, null);
                        //adapter.InvokeMethod("SetGateways", newGateway, null);
                                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to Set IP : " + ex.Message);
                    }
                }
            }
        }
        public void SetDHCPIP()
        {
            string myDesc = "Intel(R) Ethernet Connection I217-V";
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        adapter.InvokeMethod("EnableDHCP", null);

                                            }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to Set IP : " + ex.Message);
                    }
                }
            }

        }

        private void BtnReturnDHCP_Click(object sender, EventArgs e)
        {
            SetDHCPIP();
            lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }
    }
}