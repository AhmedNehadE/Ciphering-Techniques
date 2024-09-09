namespace Ciphering
{
    partial class PlayFairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayFairForm));
            this.label4 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.matrixRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(18, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 41);
            this.label4.TabIndex = 29;
            this.label4.Text = "Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Tahoma", 20F);
            this.keyTextBox.Location = new System.Drawing.Point(363, 496);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(257, 48);
            this.keyTextBox.TabIndex = 28;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.Location = new System.Drawing.Point(914, 662);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(288, 86);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.decryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decryptBtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.decryptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.decryptBtn.Location = new System.Drawing.Point(486, 662);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(288, 86);
            this.decryptBtn.TabIndex = 26;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.encryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encryptBtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.encryptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.encryptBtn.Location = new System.Drawing.Point(48, 662);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(288, 86);
            this.encryptBtn.TabIndex = 25;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(18, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 41);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cipher text";
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Font = new System.Drawing.Font("Tahoma", 20F);
            this.cipherTextBox.Location = new System.Drawing.Point(231, 363);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(518, 48);
            this.cipherTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(18, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 41);
            this.label2.TabIndex = 22;
            this.label2.Text = "Plain text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 54F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(467, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 109);
            this.label1.TabIndex = 21;
            this.label1.Text = "Playfair";
            // 
            // plainTextBox
            // 
            this.plainTextBox.Font = new System.Drawing.Font("Tahoma", 20F);
            this.plainTextBox.Location = new System.Drawing.Point(231, 236);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(518, 48);
            this.plainTextBox.TabIndex = 20;
            // 
            // matrixRichTextBox
            // 
            this.matrixRichTextBox.Font = new System.Drawing.Font("Tahoma", 20F);
            this.matrixRichTextBox.Location = new System.Drawing.Point(837, 236);
            this.matrixRichTextBox.Name = "matrixRichTextBox";
            this.matrixRichTextBox.Size = new System.Drawing.Size(380, 350);
            this.matrixRichTextBox.TabIndex = 30;
            this.matrixRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(907, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 41);
            this.label5.TabIndex = 31;
            this.label5.Text = "playfair matrix";
            // 
            // PlayFairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 793);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrixRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainTextBox);
            this.Name = "PlayFairForm";
            this.Text = "PlayFairForm";
            this.Load += new System.EventHandler(this.PlayFairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.RichTextBox matrixRichTextBox;
        private System.Windows.Forms.Label label5;
    }
}