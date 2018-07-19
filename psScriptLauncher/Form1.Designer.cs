namespace psScriptLauncher
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
            this.button_defrag = new System.Windows.Forms.Button();
            this.button_ipconfig = new System.Windows.Forms.Button();
            this.button_SoftwareVersions = new System.Windows.Forms.Button();
            this.button_WOL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_defrag
            // 
            this.button_defrag.Location = new System.Drawing.Point(35, 27);
            this.button_defrag.Name = "button_defrag";
            this.button_defrag.Size = new System.Drawing.Size(123, 23);
            this.button_defrag.TabIndex = 0;
            this.button_defrag.Text = "Defrag All Desktops";
            this.button_defrag.UseVisualStyleBackColor = true;
            this.button_defrag.Click += new System.EventHandler(this.button_defrag_Click);
            // 
            // button_ipconfig
            // 
            this.button_ipconfig.Location = new System.Drawing.Point(36, 76);
            this.button_ipconfig.Name = "button_ipconfig";
            this.button_ipconfig.Size = new System.Drawing.Size(121, 38);
            this.button_ipconfig.TabIndex = 1;
            this.button_ipconfig.Text = "Get IP Configuration of all Desktops";
            this.button_ipconfig.UseVisualStyleBackColor = true;
            this.button_ipconfig.Click += new System.EventHandler(this.button_ipconfig_Click);
            // 
            // button_SoftwareVersions
            // 
            this.button_SoftwareVersions.Location = new System.Drawing.Point(36, 139);
            this.button_SoftwareVersions.Name = "button_SoftwareVersions";
            this.button_SoftwareVersions.Size = new System.Drawing.Size(119, 51);
            this.button_SoftwareVersions.TabIndex = 2;
            this.button_SoftwareVersions.Text = "Get list of Installed Software from all Desktops";
            this.button_SoftwareVersions.UseVisualStyleBackColor = true;
            this.button_SoftwareVersions.Click += new System.EventHandler(this.button_SoftwareVersions_Click);
            // 
            // button_WOL
            // 
            this.button_WOL.Location = new System.Drawing.Point(36, 215);
            this.button_WOL.Name = "button_WOL";
            this.button_WOL.Size = new System.Drawing.Size(118, 58);
            this.button_WOL.TabIndex = 3;
            this.button_WOL.Text = "Wake-On-LAN";
            this.button_WOL.UseVisualStyleBackColor = true;
            this.button_WOL.Click += new System.EventHandler(this.button_WOL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 355);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 379);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_WOL);
            this.Controls.Add(this.button_SoftwareVersions);
            this.Controls.Add(this.button_ipconfig);
            this.Controls.Add(this.button_defrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_defrag;
        private System.Windows.Forms.Button button_ipconfig;
        private System.Windows.Forms.Button button_SoftwareVersions;
        private System.Windows.Forms.Button button_WOL;
        private System.Windows.Forms.TextBox textBox1;
    }
}

