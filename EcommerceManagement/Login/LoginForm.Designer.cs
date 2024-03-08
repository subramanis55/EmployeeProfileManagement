namespace EcommerceManagement
{
    partial class LoginForm
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
            this.LoginpagePanel = new System.Windows.Forms.Panel();
            this.PasswordShowcheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ForgetPassWordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordInvalidIcon = new System.Windows.Forms.PictureBox();
            this.EmailInvalidIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginpagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordInvalidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailInvalidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginpagePanel
            // 
            this.LoginpagePanel.BackColor = System.Drawing.Color.White;
            this.LoginpagePanel.Controls.Add(this.pictureBox1);
            this.LoginpagePanel.Controls.Add(this.PasswordInvalidIcon);
            this.LoginpagePanel.Controls.Add(this.EmailInvalidIcon);
            this.LoginpagePanel.Controls.Add(this.PasswordShowcheckBox);
            this.LoginpagePanel.Controls.Add(this.button2);
            this.LoginpagePanel.Controls.Add(this.ForgetPassWordLinkLabel);
            this.LoginpagePanel.Controls.Add(this.PasswordTB);
            this.LoginpagePanel.Controls.Add(this.EmailTB);
            this.LoginpagePanel.Controls.Add(this.LoginBtn);
            this.LoginpagePanel.Controls.Add(this.panel2);
            this.LoginpagePanel.Controls.Add(this.panel1);
            this.LoginpagePanel.Controls.Add(this.pictureBox3);
            this.LoginpagePanel.Controls.Add(this.label1);
            this.LoginpagePanel.Controls.Add(this.LogoPictureBox);
            this.LoginpagePanel.Location = new System.Drawing.Point(27, 22);
            this.LoginpagePanel.Name = "LoginpagePanel";
            this.LoginpagePanel.Size = new System.Drawing.Size(720, 469);
            this.LoginpagePanel.TabIndex = 31;
            // 
            // PasswordShowcheckBox
            // 
            this.PasswordShowcheckBox.AutoSize = true;
            this.PasswordShowcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordShowcheckBox.Location = new System.Drawing.Point(512, 277);
            this.PasswordShowcheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordShowcheckBox.Name = "PasswordShowcheckBox";
            this.PasswordShowcheckBox.Size = new System.Drawing.Size(60, 20);
            this.PasswordShowcheckBox.TabIndex = 28;
            this.PasswordShowcheckBox.Text = "Show";
            this.PasswordShowcheckBox.UseVisualStyleBackColor = true;
            this.PasswordShowcheckBox.CheckedChanged += new System.EventHandler(this.PasswordShowCBChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(237, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "SIGN UP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SignUpBtnClick);
            // 
            // ForgetPassWordLinkLabel
            // 
            this.ForgetPassWordLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
            this.ForgetPassWordLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ForgetPassWordLinkLabel.AutoSize = true;
            this.ForgetPassWordLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassWordLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(224)))));
            this.ForgetPassWordLinkLabel.Location = new System.Drawing.Point(275, 438);
            this.ForgetPassWordLinkLabel.Name = "ForgetPassWordLinkLabel";
            this.ForgetPassWordLinkLabel.Size = new System.Drawing.Size(117, 16);
            this.ForgetPassWordLinkLabel.TabIndex = 26;
            this.ForgetPassWordLinkLabel.TabStop = true;
            this.ForgetPassWordLinkLabel.Text = "Forget Password?";
            this.ForgetPassWordLinkLabel.Click += new System.EventHandler(this.ForgetPassWordLinkClicked);
            this.ForgetPassWordLinkLabel.MouseLeave += new System.EventHandler(this.ForgetPasswordLinkLeave);
            this.ForgetPassWordLinkLabel.MouseHover += new System.EventHandler(this.ForgetPasswordLinkHover);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
            this.PasswordTB.HideSelection = false;
            this.PasswordTB.Location = new System.Drawing.Point(268, 275);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(185, 22);
            this.PasswordTB.TabIndex = 18;
            this.PasswordTB.TabStop = false;
            this.PasswordTB.Text = "Enter the password";
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTBChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTBEnter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTBLeave);
            this.PasswordTB.MouseEnter += new System.EventHandler(this.PasswordTBMouseEnter);
            this.PasswordTB.MouseLeave += new System.EventHandler(this.PasswordTBMouseLeave);
            // 
            // EmailTB
            // 
            this.EmailTB.BackColor = System.Drawing.Color.White;
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
            this.EmailTB.HideSelection = false;
            this.EmailTB.Location = new System.Drawing.Point(268, 211);
            this.EmailTB.Multiline = true;
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EmailTB.Size = new System.Drawing.Size(185, 27);
            this.EmailTB.TabIndex = 0;
            this.EmailTB.TabStop = false;
            this.EmailTB.Text = "Enter the email";
            this.EmailTB.CursorChanged += new System.EventHandler(this.EmailTBTextChanged);
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTBTextChanged);
            this.EmailTB.Enter += new System.EventHandler(this.EmailTBEnter);
            this.EmailTB.Leave += new System.EventHandler(this.EmailTBLeave);
            this.EmailTB.MouseEnter += new System.EventHandler(this.EmailTBMouseEnterd);
            this.EmailTB.MouseLeave += new System.EventHandler(this.EmailTBMouseLeaved);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(237, 356);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(190, 38);
            this.LoginBtn.TabIndex = 25;
            this.LoginBtn.Text = "LOG IN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtnClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(221, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 3);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(221, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 3);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(300, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "LOG IN";
            // 
            // PasswordInvalidIcon
            // 
            this.PasswordInvalidIcon.Image = global::EcommerceManagement.Properties.Resources.ErrorCloud;
            this.PasswordInvalidIcon.Location = new System.Drawing.Point(459, 266);
            this.PasswordInvalidIcon.Name = "PasswordInvalidIcon";
            this.PasswordInvalidIcon.Size = new System.Drawing.Size(32, 33);
            this.PasswordInvalidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordInvalidIcon.TabIndex = 30;
            this.PasswordInvalidIcon.TabStop = false;
            this.PasswordInvalidIcon.Visible = false;
            // 
            // EmailInvalidIcon
            // 
            this.EmailInvalidIcon.Image = global::EcommerceManagement.Properties.Resources.ErrorCloud;
            this.EmailInvalidIcon.Location = new System.Drawing.Point(459, 205);
            this.EmailInvalidIcon.Name = "EmailInvalidIcon";
            this.EmailInvalidIcon.Size = new System.Drawing.Size(32, 33);
            this.EmailInvalidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailInvalidIcon.TabIndex = 29;
            this.EmailInvalidIcon.TabStop = false;
            this.EmailInvalidIcon.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EcommerceManagement.Properties.Resources.Password;
            this.pictureBox3.Location = new System.Drawing.Point(221, 269);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::EcommerceManagement.Properties.Resources.BirdLogo;
            this.LogoPictureBox.Location = new System.Drawing.Point(278, 15);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(124, 128);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 19;
            this.LogoPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcommerceManagement.Properties.Resources.EmailIconLogo;
            this.pictureBox1.Location = new System.Drawing.Point(221, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 522);
            this.Controls.Add(this.LoginpagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.LoginpagePanel.ResumeLayout(false);
            this.LoginpagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordInvalidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailInvalidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel LoginpagePanel;
        private System.Windows.Forms.CheckBox PasswordShowcheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel ForgetPassWordLinkLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox EmailInvalidIcon;
        private System.Windows.Forms.PictureBox PasswordInvalidIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}