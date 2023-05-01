namespace rcCryptor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbX1 = new System.Windows.Forms.TextBox();
            this.txbX2 = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.txbX3 = new System.Windows.Forms.TextBox();
            this.txbHashUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbHashPwd = new System.Windows.Forms.TextBox();
            this.txbHashUserPwd = new System.Windows.Forms.TextBox();
            this.txbHashPwdUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCrpUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCrpPwd = new System.Windows.Forms.TextBox();
            this.txbCrpPwdUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbCrpUserPwd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbEncKey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txbEncText = new System.Windows.Forms.TextBox();
            this.txbDecrypt = new System.Windows.Forms.TextBox();
            this.txbUserMD5 = new System.Windows.Forms.TextBox();
            this.txbPwdMD5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rdbTypeMD5 = new System.Windows.Forms.RadioButton();
            this.rdbTypeSHA1 = new System.Windows.Forms.RadioButton();
            this.rdbTypeSHA256 = new System.Windows.Forms.RadioButton();
            this.rdbTypeSHA512 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(100, 35);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(184, 23);
            this.txbUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txbX1
            // 
            this.txbX1.Location = new System.Drawing.Point(21, 35);
            this.txbX1.Name = "txbX1";
            this.txbX1.Size = new System.Drawing.Size(73, 23);
            this.txbX1.TabIndex = 0;
            // 
            // txbX2
            // 
            this.txbX2.Location = new System.Drawing.Point(290, 35);
            this.txbX2.Name = "txbX2";
            this.txbX2.Size = new System.Drawing.Size(73, 23);
            this.txbX2.TabIndex = 2;
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(369, 35);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.Size = new System.Drawing.Size(184, 23);
            this.txbPwd.TabIndex = 4;
            // 
            // txbX3
            // 
            this.txbX3.Location = new System.Drawing.Point(559, 35);
            this.txbX3.Name = "txbX3";
            this.txbX3.Size = new System.Drawing.Size(73, 23);
            this.txbX3.TabIndex = 5;
            // 
            // txbHashUser
            // 
            this.txbHashUser.Location = new System.Drawing.Point(151, 182);
            this.txbHashUser.Multiline = true;
            this.txbHashUser.Name = "txbHashUser";
            this.txbHashUser.Size = new System.Drawing.Size(481, 40);
            this.txbHashUser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "X1+Pwd+X2+User+X3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "X1+User+X2+Pwd+X3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // txbHashPwd
            // 
            this.txbHashPwd.Location = new System.Drawing.Point(151, 228);
            this.txbHashPwd.Multiline = true;
            this.txbHashPwd.Name = "txbHashPwd";
            this.txbHashPwd.Size = new System.Drawing.Size(481, 40);
            this.txbHashPwd.TabIndex = 8;
            // 
            // txbHashUserPwd
            // 
            this.txbHashUserPwd.Location = new System.Drawing.Point(151, 274);
            this.txbHashUserPwd.Multiline = true;
            this.txbHashUserPwd.Name = "txbHashUserPwd";
            this.txbHashUserPwd.Size = new System.Drawing.Size(481, 40);
            this.txbHashUserPwd.TabIndex = 9;
            // 
            // txbHashPwdUser
            // 
            this.txbHashPwdUser.Location = new System.Drawing.Point(151, 320);
            this.txbHashPwdUser.Multiline = true;
            this.txbHashPwdUser.Name = "txbHashPwdUser";
            this.txbHashPwdUser.Size = new System.Drawing.Size(481, 40);
            this.txbHashPwdUser.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "X1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "X2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "X3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "User";
            // 
            // txbCrpUser
            // 
            this.txbCrpUser.Location = new System.Drawing.Point(151, 400);
            this.txbCrpUser.Name = "txbCrpUser";
            this.txbCrpUser.Size = new System.Drawing.Size(481, 23);
            this.txbCrpUser.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Password";
            // 
            // txbCrpPwd
            // 
            this.txbCrpPwd.Location = new System.Drawing.Point(151, 429);
            this.txbCrpPwd.Name = "txbCrpPwd";
            this.txbCrpPwd.Size = new System.Drawing.Size(481, 23);
            this.txbCrpPwd.TabIndex = 12;
            // 
            // txbCrpPwdUser
            // 
            this.txbCrpPwdUser.Location = new System.Drawing.Point(151, 487);
            this.txbCrpPwdUser.Name = "txbCrpPwdUser";
            this.txbCrpPwdUser.Size = new System.Drawing.Size(481, 23);
            this.txbCrpPwdUser.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "X1+Pwd+X2+User+X3";
            // 
            // txbCrpUserPwd
            // 
            this.txbCrpUserPwd.Location = new System.Drawing.Point(151, 458);
            this.txbCrpUserPwd.Name = "txbCrpUserPwd";
            this.txbCrpUserPwd.Size = new System.Drawing.Size(481, 23);
            this.txbCrpUserPwd.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "X1+User+X2+Pwd+X3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "----------[HASH 512]----------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "-----[CRYPTOGRAPHY]-----";
            // 
            // txbEncKey
            // 
            this.txbEncKey.Location = new System.Drawing.Point(371, 549);
            this.txbEncKey.Name = "txbEncKey";
            this.txbEncKey.Size = new System.Drawing.Size(261, 23);
            this.txbEncKey.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(371, 531);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Key/Vector";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 531);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Encrypted Text";
            // 
            // txbEncText
            // 
            this.txbEncText.Location = new System.Drawing.Point(21, 549);
            this.txbEncText.Name = "txbEncText";
            this.txbEncText.Size = new System.Drawing.Size(344, 23);
            this.txbEncText.TabIndex = 1;
            // 
            // txbDecrypt
            // 
            this.txbDecrypt.Location = new System.Drawing.Point(21, 618);
            this.txbDecrypt.Name = "txbDecrypt";
            this.txbDecrypt.Size = new System.Drawing.Size(611, 23);
            this.txbDecrypt.TabIndex = 1;
            // 
            // txbUserMD5
            // 
            this.txbUserMD5.Location = new System.Drawing.Point(151, 116);
            this.txbUserMD5.Name = "txbUserMD5";
            this.txbUserMD5.Size = new System.Drawing.Size(232, 23);
            this.txbUserMD5.TabIndex = 1;
            // 
            // txbPwdMD5
            // 
            this.txbPwdMD5.Location = new System.Drawing.Point(389, 116);
            this.txbPwdMD5.Name = "txbPwdMD5";
            this.txbPwdMD5.Size = new System.Drawing.Size(243, 23);
            this.txbPwdMD5.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "MD5";
            // 
            // rdbTypeMD5
            // 
            this.rdbTypeMD5.AutoSize = true;
            this.rdbTypeMD5.Checked = true;
            this.rdbTypeMD5.Location = new System.Drawing.Point(21, 72);
            this.rdbTypeMD5.Name = "rdbTypeMD5";
            this.rdbTypeMD5.Size = new System.Drawing.Size(50, 19);
            this.rdbTypeMD5.TabIndex = 15;
            this.rdbTypeMD5.TabStop = true;
            this.rdbTypeMD5.Text = "MD5";
            this.rdbTypeMD5.UseVisualStyleBackColor = true;
            // 
            // rdbTypeSHA1
            // 
            this.rdbTypeSHA1.AutoSize = true;
            this.rdbTypeSHA1.Location = new System.Drawing.Point(77, 72);
            this.rdbTypeSHA1.Name = "rdbTypeSHA1";
            this.rdbTypeSHA1.Size = new System.Drawing.Size(54, 19);
            this.rdbTypeSHA1.TabIndex = 15;
            this.rdbTypeSHA1.Text = "SHA1";
            this.rdbTypeSHA1.UseVisualStyleBackColor = true;
            // 
            // rdbTypeSHA256
            // 
            this.rdbTypeSHA256.AutoSize = true;
            this.rdbTypeSHA256.Location = new System.Drawing.Point(137, 72);
            this.rdbTypeSHA256.Name = "rdbTypeSHA256";
            this.rdbTypeSHA256.Size = new System.Drawing.Size(66, 19);
            this.rdbTypeSHA256.TabIndex = 15;
            this.rdbTypeSHA256.Text = "SHA256";
            this.rdbTypeSHA256.UseVisualStyleBackColor = true;
            // 
            // rdbTypeSHA512
            // 
            this.rdbTypeSHA512.AutoSize = true;
            this.rdbTypeSHA512.Location = new System.Drawing.Point(209, 72);
            this.rdbTypeSHA512.Name = "rdbTypeSHA512";
            this.rdbTypeSHA512.Size = new System.Drawing.Size(66, 19);
            this.rdbTypeSHA512.TabIndex = 15;
            this.rdbTypeSHA512.Text = "SHA512";
            this.rdbTypeSHA512.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 664);
            this.Controls.Add(this.rdbTypeSHA512);
            this.Controls.Add(this.rdbTypeSHA256);
            this.Controls.Add(this.rdbTypeSHA1);
            this.Controls.Add(this.rdbTypeMD5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbPwdMD5);
            this.Controls.Add(this.txbUserMD5);
            this.Controls.Add(this.txbDecrypt);
            this.Controls.Add(this.txbEncText);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txbEncKey);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbCrpUserPwd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbCrpPwdUser);
            this.Controls.Add(this.txbCrpPwd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbCrpUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbHashPwdUser);
            this.Controls.Add(this.txbHashUserPwd);
            this.Controls.Add(this.txbHashPwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbHashUser);
            this.Controls.Add(this.txbX3);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbX2);
            this.Controls.Add(this.txbX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbUser);
            this.Name = "Form1";
            this.Text = "rcCryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbX1;
        private System.Windows.Forms.TextBox txbX2;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.TextBox txbX3;
        private System.Windows.Forms.TextBox txbHashUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbHashPwd;
        private System.Windows.Forms.TextBox txbHashUserPwd;
        private System.Windows.Forms.TextBox txbHashPwdUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbCrpUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbCrpPwd;
        private System.Windows.Forms.TextBox txbCrpPwdUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbCrpUserPwd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbEncKey;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbEncText;
        private System.Windows.Forms.TextBox txbDecrypt;
        private System.Windows.Forms.TextBox txbUserMD5;
        private System.Windows.Forms.TextBox txbPwdMD5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdbTypeMD5;
        private System.Windows.Forms.RadioButton rdbTypeSHA1;
        private System.Windows.Forms.RadioButton rdbTypeSHA256;
        private System.Windows.Forms.RadioButton rdbTypeSHA512;
    }
}

