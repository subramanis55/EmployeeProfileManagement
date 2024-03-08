namespace EcommerceManagement.Login
{
    partial class ForgetPasswordPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordShowCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailTB = new EcommerceManagement.CustomControls.CustomTextBoxPlaceholder();
            this.NewPasswordTB = new EcommerceManagement.CustomControls.CustomTextBoxPlaceholder();
            this.ConfirmPasswordTB = new EcommerceManagement.CustomControls.CustomTextBoxPlaceholder();
            this.NewPasswordInvalidIcon = new System.Windows.Forms.PictureBox();
            this.ConfirmPasswordInvalidIcon = new System.Windows.Forms.PictureBox();
            this.EmailInvalidIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordInvalidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordInvalidIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailInvalidIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordShowCheckBox
            // 
            this.PasswordShowCheckBox.AutoSize = true;
            this.PasswordShowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordShowCheckBox.Location = new System.Drawing.Point(521, 342);
            this.PasswordShowCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordShowCheckBox.Name = "PasswordShowCheckBox";
            this.PasswordShowCheckBox.Size = new System.Drawing.Size(65, 22);
            this.PasswordShowCheckBox.TabIndex = 67;
            this.PasswordShowCheckBox.Text = "Show";
            this.PasswordShowCheckBox.UseVisualStyleBackColor = true;
            this.PasswordShowCheckBox.CheckedChanged += new System.EventHandler(this.ShowCheckedBoxChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(228, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(228, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 63;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(245, 398);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(206, 35);
            this.ConfirmBtn.TabIndex = 60;
            this.ConfirmBtn.Text = "CONFIRM";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            this.ConfirmBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmBtnClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(228, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 59;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EcommerceManagement.Properties.Resources.Password;
            this.pictureBox5.Location = new System.Drawing.Point(228, 334);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EcommerceManagement.Properties.Resources.EmailIconLogo;
            this.pictureBox4.Location = new System.Drawing.Point(228, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EcommerceManagement.Properties.Resources.Password;
            this.pictureBox3.Location = new System.Drawing.Point(228, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcommerceManagement.Properties.Resources.BirdLogo;
            this.pictureBox1.Location = new System.Drawing.Point(285, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // EmailTB
            // 
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTB.CustemUseSystemPasswordChar = false;
            this.EmailTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
            this.EmailTB.IsPlaceholder = true;
            this.EmailTB.Location = new System.Drawing.Point(285, 250);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.PaceholderText = "Enter the email";
            this.EmailTB.Size = new System.Drawing.Size(172, 22);
            this.EmailTB.TabIndex = 75;
            this.EmailTB.Text = "Enter the email";
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordTB.CustemUseSystemPasswordChar = false;
            this.NewPasswordTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
            this.NewPasswordTB.IsPlaceholder = true;
            this.NewPasswordTB.Location = new System.Drawing.Point(285, 294);
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.PaceholderText = "New Password";
            this.NewPasswordTB.Size = new System.Drawing.Size(172, 22);
            this.NewPasswordTB.TabIndex = 76;
            this.NewPasswordTB.Text = "New Password";
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordTB.CustemUseSystemPasswordChar = false;
            this.ConfirmPasswordTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(223)))));
            this.ConfirmPasswordTB.IsPlaceholder = true;
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(285, 341);
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.PaceholderText = "Confirm Password";
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(172, 22);
            this.ConfirmPasswordTB.TabIndex = 77;
            this.ConfirmPasswordTB.Text = "Confirm Password";
            // 
            // NewPasswordInvalidIcon
            // 
            this.NewPasswordInvalidIcon.Image = global::EcommerceManagement.Properties.Resources.ErrorCloud;
            this.NewPasswordInvalidIcon.Location = new System.Drawing.Point(463, 288);
            this.NewPasswordInvalidIcon.Name = "NewPasswordInvalidIcon";
            this.NewPasswordInvalidIcon.Size = new System.Drawing.Size(32, 33);
            this.NewPasswordInvalidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewPasswordInvalidIcon.TabIndex = 79;
            this.NewPasswordInvalidIcon.TabStop = false;
            this.NewPasswordInvalidIcon.Visible = false;
            // 
            // ConfirmPasswordInvalidIcon
            // 
            this.ConfirmPasswordInvalidIcon.Image = global::EcommerceManagement.Properties.Resources.ErrorCloud;
            this.ConfirmPasswordInvalidIcon.Location = new System.Drawing.Point(463, 330);
            this.ConfirmPasswordInvalidIcon.Name = "ConfirmPasswordInvalidIcon";
            this.ConfirmPasswordInvalidIcon.Size = new System.Drawing.Size(32, 33);
            this.ConfirmPasswordInvalidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfirmPasswordInvalidIcon.TabIndex = 80;
            this.ConfirmPasswordInvalidIcon.TabStop = false;
            this.ConfirmPasswordInvalidIcon.Visible = false;
            // 
            // EmailInvalidIcon
            // 
            this.EmailInvalidIcon.Image = global::EcommerceManagement.Properties.Resources.ErrorCloud;
            this.EmailInvalidIcon.Location = new System.Drawing.Point(463, 242);
            this.EmailInvalidIcon.Name = "EmailInvalidIcon";
            this.EmailInvalidIcon.Size = new System.Drawing.Size(32, 33);
            this.EmailInvalidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailInvalidIcon.TabIndex = 81;
            this.EmailInvalidIcon.TabStop = false;
            this.EmailInvalidIcon.Visible = false;
            // 
            // ForgetPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EmailInvalidIcon);
            this.Controls.Add(this.ConfirmPasswordInvalidIcon);
            this.Controls.Add(this.NewPasswordInvalidIcon);
            this.Controls.Add(this.ConfirmPasswordTB);
            this.Controls.Add(this.NewPasswordTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PasswordShowCheckBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ForgetPasswordPage";
            this.Size = new System.Drawing.Size(720, 469);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordInvalidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordInvalidIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailInvalidIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PasswordShowCheckBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.CustomTextBoxPlaceholder EmailTB;
        private CustomControls.CustomTextBoxPlaceholder NewPasswordTB;
        private CustomControls.CustomTextBoxPlaceholder ConfirmPasswordTB;
        private System.Windows.Forms.PictureBox NewPasswordInvalidIcon;
        private System.Windows.Forms.PictureBox ConfirmPasswordInvalidIcon;
        private System.Windows.Forms.PictureBox EmailInvalidIcon;
    }
}
