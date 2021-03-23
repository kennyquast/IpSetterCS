
namespace IpSetterCS
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.button1 = new System.Windows.Forms.Button();
            this.AboutTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnGithub = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AboutTextBox1
            // 
            this.AboutTextBox1.Location = new System.Drawing.Point(12, 55);
            this.AboutTextBox1.Name = "AboutTextBox1";
            this.AboutTextBox1.ReadOnly = true;
            this.AboutTextBox1.Size = new System.Drawing.Size(485, 198);
            this.AboutTextBox1.TabIndex = 1;
            this.AboutTextBox1.Text = "";
            // 
            // BtnGithub
            // 
            this.BtnGithub.Location = new System.Drawing.Point(298, 271);
            this.BtnGithub.Name = "BtnGithub";
            this.BtnGithub.Size = new System.Drawing.Size(112, 39);
            this.BtnGithub.TabIndex = 2;
            this.BtnGithub.Text = "GitHub Source";
            this.BtnGithub.UseVisualStyleBackColor = true;
            this.BtnGithub.Click += new System.EventHandler(this.BtnGithub_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(12, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(76, 17);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "IPSetterCS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coded by : Kenny Quast 2021";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(9, 271);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(46, 17);
            this.LblVersion.TabIndex = 5;
            this.LblVersion.Text = "label1";
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 322);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnGithub);
            this.Controls.Add(this.AboutTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox AboutTextBox1;
        private System.Windows.Forms.Button BtnGithub;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVersion;
    }
}