﻿using System;
using System.Drawing;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace IpSetterCS
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
      //private System.ComponentModel.IContainer components;

        public Form1()
        {

            this.components = new System.ComponentModel.Container();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            this.contextMenu1.MenuItems.AddRange(
            new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Text = "Notify Icon Example";

            // Create the NotifyIcon.
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            notifyIcon1.Icon = Properties.Resources.IPSetter;

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenu = this.contextMenu1;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "Form1 (NotifyIcon example)";
            notifyIcon1.Visible = true;

            // Handle the DoubleClick event to activate the form.
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            InitializeComponent();
        }



        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
           
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a down and dirty way for me to change my Ip address from DHCP to STATIC and back, while working on PLC's, Cameras and other equiptment at work", "About IP Setter v0.0.1.1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }


        private void BtnSetIP_Click(object sender, EventArgs e)
        {

            SetStaticIP();
           // lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);


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
            //lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }
    }
}