namespace Ciphering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cesarbtn = new System.Windows.Forms.Button();
            this.vigenerebtn = new System.Windows.Forms.Button();
            this.desbtn = new System.Windows.Forms.Button();
            this.playfairbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cesarbtn
            // 
            this.cesarbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cesarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cesarbtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.cesarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cesarbtn.Location = new System.Drawing.Point(463, 206);
            this.cesarbtn.Name = "cesarbtn";
            this.cesarbtn.Size = new System.Drawing.Size(344, 80);
            this.cesarbtn.TabIndex = 0;
            this.cesarbtn.Text = "Caesar";
            this.cesarbtn.UseVisualStyleBackColor = false;
            this.cesarbtn.Click += new System.EventHandler(this.cesarbtn_Click);
            // 
            // vigenerebtn
            // 
            this.vigenerebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vigenerebtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.vigenerebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vigenerebtn.Location = new System.Drawing.Point(463, 324);
            this.vigenerebtn.Name = "vigenerebtn";
            this.vigenerebtn.Size = new System.Drawing.Size(344, 80);
            this.vigenerebtn.TabIndex = 1;
            this.vigenerebtn.Text = "Vigenere";
            this.vigenerebtn.UseVisualStyleBackColor = true;
            this.vigenerebtn.Click += new System.EventHandler(this.vigenerebtn_Click);
            // 
            // desbtn
            // 
            this.desbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.desbtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.desbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.desbtn.Location = new System.Drawing.Point(463, 575);
            this.desbtn.Name = "desbtn";
            this.desbtn.Size = new System.Drawing.Size(344, 80);
            this.desbtn.TabIndex = 2;
            this.desbtn.Text = "Data Encryption Standard";
            this.desbtn.UseVisualStyleBackColor = true;
            this.desbtn.Click += new System.EventHandler(this.desbtn_Click);
            // 
            // playfairbtn
            // 
            this.playfairbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playfairbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playfairbtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.playfairbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.playfairbtn.Location = new System.Drawing.Point(463, 450);
            this.playfairbtn.Name = "playfairbtn";
            this.playfairbtn.Size = new System.Drawing.Size(344, 80);
            this.playfairbtn.TabIndex = 3;
            this.playfairbtn.Text = "Playfair";
            this.playfairbtn.UseVisualStyleBackColor = false;
            this.playfairbtn.Click += new System.EventHandler(this.playfairbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 54F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1213, 109);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the encryption method";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 793);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playfairbtn);
            this.Controls.Add(this.desbtn);
            this.Controls.Add(this.vigenerebtn);
            this.Controls.Add(this.cesarbtn);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cesarbtn;
        private System.Windows.Forms.Button vigenerebtn;
        private System.Windows.Forms.Button desbtn;
        private System.Windows.Forms.Button playfairbtn;
        private System.Windows.Forms.Label label1;
    }
}

