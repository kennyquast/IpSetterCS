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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            this.lblCurrentIPAddress = new System.Windows.Forms.Label();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReturnDHCP = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCurrentIPAddress
            // 
            this.lblCurrentIPAddress.AutoSize = true;
            this.lblCurrentIPAddress.Location = new System.Drawing.Point(17, 12);
            this.lblCurrentIPAddress.Name = "lblCurrentIPAddress";
            this.lblCurrentIPAddress.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentIPAddress.TabIndex = 0;
            this.lblCurrentIPAddress.Text = "label1";
            // 
            // btnSetIP
            // 
            this.btnSetIP.Location = new System.Drawing.Point(12, 32);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(129, 51);
            this.btnSetIP.TabIndex = 1;
            this.btnSetIP.Text = "Set IP";
            this.btnSetIP.UseVisualStyleBackColor = true;
            this.btnSetIP.Click += new System.EventHandler(this.BtnSetIP_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 89);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(129, 51);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnReturnDHCP
            // 
            this.btnReturnDHCP.Location = new System.Drawing.Point(147, 32);
            this.btnReturnDHCP.Name = "btnReturnDHCP";
            this.btnReturnDHCP.Size = new System.Drawing.Size(129, 51);
            this.btnReturnDHCP.TabIndex = 3;
            this.btnReturnDHCP.Text = "Return to DHCP";
            this.btnReturnDHCP.UseVisualStyleBackColor = true;
            this.btnReturnDHCP.Click += new System.EventHandler(this.BtnReturnDHCP_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(147, 89);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(129, 51);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 147);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReturnDHCP);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetIP);
            this.Controls.Add(this.lblCurrentIPAddress);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPSetter";
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
    }
}

