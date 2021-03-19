namespace IpSetterCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            // Clean up any components being used.
            if (disposing)
                if (components != null)
                    components.Dispose();

            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCurrentIPAddress = new System.Windows.Forms.Label();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReturnDHCP = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CboNic = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextIP = new System.Windows.Forms.TextBox();
            this.TextSubnet = new System.Windows.Forms.TextBox();
            this.TextGateway = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentIPAddress
            // 
            this.lblCurrentIPAddress.AutoSize = true;
            this.lblCurrentIPAddress.Location = new System.Drawing.Point(29, 379);
            this.lblCurrentIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentIPAddress.Name = "lblCurrentIPAddress";
            this.lblCurrentIPAddress.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentIPAddress.TabIndex = 0;
            this.lblCurrentIPAddress.Text = "label1";
            // 
            // btnSetIP
            // 
            this.btnSetIP.Location = new System.Drawing.Point(22, 403);
            this.btnSetIP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(172, 63);
            this.btnSetIP.TabIndex = 1;
            this.btnSetIP.Text = "Set IP";
            this.btnSetIP.UseVisualStyleBackColor = true;
            this.btnSetIP.Click += new System.EventHandler(this.BtnSetIP_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(22, 474);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(172, 63);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnReturnDHCP
            // 
            this.btnReturnDHCP.Location = new System.Drawing.Point(202, 403);
            this.btnReturnDHCP.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnDHCP.Name = "btnReturnDHCP";
            this.btnReturnDHCP.Size = new System.Drawing.Size(172, 63);
            this.btnReturnDHCP.TabIndex = 3;
            this.btnReturnDHCP.Text = "Return to DHCP";
            this.btnReturnDHCP.UseVisualStyleBackColor = true;
            this.btnReturnDHCP.Click += new System.EventHandler(this.BtnReturnDHCP_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(202, 474);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(172, 63);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CboNic
            // 
            this.CboNic.FormattingEnabled = true;
            this.CboNic.Location = new System.Drawing.Point(22, 49);
            this.CboNic.Name = "CboNic";
            this.CboNic.Size = new System.Drawing.Size(387, 24);
            this.CboNic.TabIndex = 5;
            this.CboNic.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(307, 184);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(102, 32);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Update IP";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ip Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gateway";
            // 
            // TextIP
            // 
            this.TextIP.Location = new System.Drawing.Point(100, 91);
            this.TextIP.Name = "TextIP";
            this.TextIP.Size = new System.Drawing.Size(309, 22);
            this.TextIP.TabIndex = 11;
            // 
            // TextSubnet
            // 
            this.TextSubnet.Location = new System.Drawing.Point(100, 118);
            this.TextSubnet.Name = "TextSubnet";
            this.TextSubnet.Size = new System.Drawing.Size(309, 22);
            this.TextSubnet.TabIndex = 12;
            // 
            // TextGateway
            // 
            this.TextGateway.Location = new System.Drawing.Point(100, 147);
            this.TextGateway.Name = "TextGateway";
            this.TextGateway.Size = new System.Drawing.Size(309, 22);
            this.TextGateway.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Retreive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choose an adapter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextGateway);
            this.Controls.Add(this.TextSubnet);
            this.Controls.Add(this.TextIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.CboNic);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReturnDHCP);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetIP);
            this.Controls.Add(this.lblCurrentIPAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPSetter";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentIPAddress;
        private System.Windows.Forms.Button btnSetIP;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnReturnDHCP;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox CboNic;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextIP;
        private System.Windows.Forms.TextBox TextSubnet;
        private System.Windows.Forms.TextBox TextGateway;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

