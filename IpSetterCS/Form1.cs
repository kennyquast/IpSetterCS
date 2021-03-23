using SwitchNetConfig;
using System;
using System.Collections;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace IpSetterCS
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.NotifyIcon notifyIcon1;
        //private System.Windows.Forms.ContextMenu contextMenu1;
        //private System.Windows.Forms.MenuItem menuItemExit;
        //private System.Windows.Forms.MenuItem menuItemSetIP;
        //private System.Windows.Forms.MenuItem menuItemDHCP;
        //private System.Windows.Forms.MenuItem menuItemAbout;
        //private System.Windows.Forms.MenuItem menuItemCurrentIP;
        private ArrayList _Profiles = new ArrayList();

        //private System.ComponentModel.IContainer components;

        public Form1()
        {

            //components = new System.ComponentModel.Container();
            //contextMenu1 = new System.Windows.Forms.ContextMenu();
            //menuItemExit = new System.Windows.Forms.MenuItem();
            //menuItemSetIP = new System.Windows.Forms.MenuItem();
            //menuItemDHCP = new System.Windows.Forms.MenuItem();
            //menuItemAbout = new System.Windows.Forms.MenuItem();
            //menuItemCurrentIP = new System.Windows.Forms.MenuItem();



            //// Initialize contextMenu1
            //contextMenu1.MenuItems.Add(menuItemCurrentIP);
            //contextMenu1.MenuItems.Add(menuItemSetIP);
            //contextMenu1.MenuItems.Add(menuItemDHCP);
            //contextMenu1.MenuItems.Add(menuItemAbout);
            //contextMenu1.MenuItems.Add(menuItemExit);

            //// Initialize Menu
            //menuItemCurrentIP.Index = 0;
            //menuItemCurrentIP.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //menuItemCurrentIP.Click += new System.EventHandler(MenuItemCurrentIP_Click);

            //menuItemSetIP.Index = 1;
            //menuItemSetIP.Text = "Set IP Address";
            //menuItemSetIP.Click += new System.EventHandler(MenuItemSetIP_Click);

            //menuItemDHCP.Index = 2;
            //menuItemDHCP.Text = "Return to DHCP";
            //menuItemDHCP.Click += new System.EventHandler(MenuItemDHCP_Click);

            //menuItemAbout.Index = 3;
            //menuItemAbout.Text = "About";
            //menuItemAbout.Click += new System.EventHandler(MenuItemAbout_Click);

            //menuItemExit.Index = 4;
            //menuItemExit.Text = "Exit";
            //menuItemExit.Click += new System.EventHandler(MenuItemExit_Click);





            //// Set up how the form should be displayed.
            //ClientSize = new System.Drawing.Size(292, 266);
            //Text = "Notify Icon Example";

            //// Create the NotifyIcon.
            //notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            //// The Icon property sets the icon that will appear
            //// in the systray for this application.
            //notifyIcon1.Icon = Properties.Resources.IPSetter;

            //// The ContextMenu property sets the menu that will
            //// appear when the systray icon is right clicked.
            //notifyIcon1.ContextMenu = contextMenu1;

            //// The Text property sets the text that will be displayed,
            //// in a tooltip, when the mouse hovers over the systray icon.

            //notifyIcon1.Text = "IPSetter ver. ";
            //notifyIcon1.Visible = true;

            //// Handle the DoubleClick event to activate the form.
            //notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);

            //// Set the WindowState to normal if the form is minimized.
            //if (WindowState == FormWindowState.Minimized)
            //    WindowState = FormWindowState.Normal;

            // Activate the form.
            InitializeComponent();
           
            loadNICs();
            //Activate();
        }
    

       
        
        //private void NotifyIcon1_DoubleClick(object Sender, EventArgs e)
        //{
        //    // Show the form when the user double clicks on the notify icon.

        //    // Set the WindowState to normal if the form is minimized.
        //    if (WindowState == FormWindowState.Minimized)
        //        WindowState = FormWindowState.Normal;

        //    // Activate the form.
        //    Activate();
        //}

        //private void MenuItemExit_Click(object Sender, EventArgs e)
        //{
        //    // Cleanup and close the app.
        //    shutdown();

        //}
        //private void MenuItemSetIP_Click(object Sender, EventArgs e)
        //{
        //    // Set a Static IP
        //    SetStaticIP();

        //}
       
   
  
        private void BtnQuit_Click(object sender, EventArgs e)
        {

            //Hide();
            //notifyIcon1.Visible = false;
            shutdown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // lblCurrentIPAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }


       
        //public string GetLocalIPv4(NetworkInterfaceType _type)
        //{
        //    // in order to get a wireless IPaddress use the follwoing code
        //    //GetLocalIPv4(NetworkInterfaceType.Wireless80211);

        //    //in order to get the ethernet ip address use the following code
        //    //GetLocalIPv4(NetworkInterfaceType.Ethernet);
        //    string output = "";
        //    foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
        //    {
        //        if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
        //        {
        //            foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
        //            {
        //                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
        //                {
        //                    output = ip.Address.ToString();
        //                }
        //            }
        //        }
        //    }
        //    return output;
        //}
        public void RetSettings()
        {
            // Needs work, the NicCard method needs more data sent to it?
            string[] ipAddresses;
            string[] subnets;
            string[] gateways;
            string[] dnses;

            // Load current IP configuration for the selected NIC
            string nicName = (string)CboNic.SelectedItem;
            WMIHelper.GetIP(nicName, out ipAddresses, out subnets, out gateways, out dnses);

            // if network connection is disabled, no information will be available
            if (null == ipAddresses || null == subnets || null == gateways || null == dnses)
                return;
            ////Trim up the strings to more usable formats
            string strIP = string.Join(",", ipAddresses);
            string extIP = strIP.Substring(0, strIP.LastIndexOf(","));
            TextIP.Text = extIP;

            string strSUB = string.Join(",", subnets);
            string extSUB = strSUB.Substring(0, strSUB.LastIndexOf(","));
            TextSubnet.Text = extSUB;

            //string strGATE = string.Join(",", gateways);
            //string extGATE = strGATE.Substring(0, strGATE.LastIndexOf(","));
            //TextGateway.Text = extGATE;




            // Show the setting

            //TextSubnet.Text = string.Join(",", subnets);
            TextGateway.Text = string.Join(",", gateways);
            TextDNS.Text = string.Join(",", dnses);



        }

        //public void SetStaticIP()
        //{
        //    string myDesc = "Intel(R) Ethernet Connection (2) I219-LM"; // hard coded need to find a way to choose adapter.
        //    //string gateway = "192.168.0.1";
        //    string subnetMask = "255.255.0.0";
        //    string address = "10.102.20.250";

        //    var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
        //    var networkCollection = adapterConfig.GetInstances();

        //    foreach (ManagementObject adapter in networkCollection)
        //    {
        //        string description = adapter["Description"] as string;
        //        if (string.Compare(description,
        //            myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
        //        {
        //            try
        //            {
        //                // Set DefaultGateway
        //                //var newGateway = adapter.GetMethodParameters("SetGateways");
        //                //newGateway["DefaultIPGateway"] = new string[] { gateway };
        //                //newGateway["GatewayCostMetric"] = new int[] { 1 };

        //                // Set IPAddress and Subnet Mask
        //                var newAddress = adapter.GetMethodParameters("EnableStatic");
        //                newAddress["IPAddress"] = new string[] { address };
        //                newAddress["SubnetMask"] = new string[] { subnetMask };

        //                adapter.InvokeMethod("EnableStatic", newAddress, null);
        //                //adapter.InvokeMethod("SetGateways", newGateway, null);

        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Unable to Set IP : " + ex.Message);
        //            }
        //        }
        //    }
        //}
        //public void SetDHCPIP()
        //No Longer required with WMIHelper
        //{
        //    string myDesc = "Intel(R) Ethernet Connection I217-V";
        //    var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
        //    var networkCollection = adapterConfig.GetInstances();

        //    foreach (ManagementObject adapter in networkCollection)
        //    {
        //        string description = adapter["Description"] as string;
        //        if (string.Compare(description,
        //            myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
        //        {
        //            try
        //            {
        //                adapter.InvokeMethod("EnableDHCP", null);

        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Unable to Set IP : " + ex.Message);
        //            }
        //        }
        //    }

        //}
        public void shutdown()
        {
           // notifyIcon1.Visible = false;
           //Removed Tray icon feature

            Close();
            Application.Exit();

        }
  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetSettings();
        }
        private void loadNICs()
        {
            // get the NIC names
            ArrayList nicNames = WMIHelper.GetNICNames();

            // populate the NIC list
            CboNic.Items.Clear();
            foreach (string name in nicNames)
                CboNic.Items.Add(name);

            // if NIC found, select the first one
            if (CboNic.Items.Count > 0)
            {
                CboNic.SelectedIndex = 0;
                //GrpNIC.Enabled = true;   //Not Used
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            RetSettings();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string NicName = (string)CboNic.SelectedItem;
            string IpAdd = TextIP.Text;
            string SubNet = TextSubnet.Text;
            string Gateway = TextGateway.Text;
            string dnses = TextDNS.Text;
            //MessageBox.Show(NicName + IpAdd + SubNet + Gateway + dnses);
            //need to add a try and catch here!
            
            WMIHelper.SetIP(NicName, IpAdd, SubNet, Gateway, dnses);  
        }

        private void BtnDHCP_Click(object sender, EventArgs e)
        {
            string NicName = (string)CboNic.SelectedItem;
            WMIHelper.SetDHCP(NicName);
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shutdown();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }
    }
}
