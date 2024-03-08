namespace EcommerceManagement
{
    partial class EmployeeViewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeViewPage));
            this.EmployeePhoto = new System.Windows.Forms.PictureBox();
            this.EmployeeViewToppanel = new System.Windows.Forms.Panel();
            this.Name_Value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Email_Value = new System.Windows.Forms.Label();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.Employee_Label = new System.Windows.Forms.Label();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Age_Value = new System.Windows.Forms.Label();
            this.Gender_Value = new System.Windows.Forms.Label();
            this.Phone_Value = new System.Windows.Forms.Label();
            this.EmployeeId_Value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhoto)).BeginInit();
            this.EmployeeViewToppanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeePhoto
            // 
            this.EmployeePhoto.BackColor = System.Drawing.Color.White;
            this.EmployeePhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeePhoto.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePhoto.Image")));
            this.EmployeePhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("EmployeePhoto.InitialImage")));
            this.EmployeePhoto.Location = new System.Drawing.Point(30, 30);
            this.EmployeePhoto.Name = "EmployeePhoto";
            this.EmployeePhoto.Size = new System.Drawing.Size(250, 242);
            this.EmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePhoto.TabIndex = 0;
            this.EmployeePhoto.TabStop = false;
            // 
            // EmployeeViewToppanel
            // 
            this.EmployeeViewToppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.EmployeeViewToppanel.Controls.Add(this.Name_Value);
            this.EmployeeViewToppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeViewToppanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeViewToppanel.Name = "EmployeeViewToppanel";
            this.EmployeeViewToppanel.Padding = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.EmployeeViewToppanel.Size = new System.Drawing.Size(907, 86);
            this.EmployeeViewToppanel.TabIndex = 1;
            // 
            // Name_Value
            // 
            this.Name_Value.AutoSize = true;
            this.Name_Value.Dock = System.Windows.Forms.DockStyle.Left;
            this.Name_Value.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Value.ForeColor = System.Drawing.Color.Snow;
            this.Name_Value.Location = new System.Drawing.Point(30, 20);
            this.Name_Value.Name = "Name_Value";
            this.Name_Value.Size = new System.Drawing.Size(0, 37);
            this.Name_Value.TabIndex = 0;
            this.Name_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.EmployeePhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(597, 86);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(310, 556);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 556);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.Email_Value, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Age_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Email_Label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Gender_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Employee_Label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Phone_Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Age_Value, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Gender_Value, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Phone_Value, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeId_Value, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 293);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // Email_Value
            // 
            this.Email_Value.AutoSize = true;
            this.Email_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email_Value.Location = new System.Drawing.Point(216, 229);
            this.Email_Value.Name = "Email_Value";
            this.Email_Value.Size = new System.Drawing.Size(306, 59);
            this.Email_Value.TabIndex = 10;
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Label.Location = new System.Drawing.Point(8, 5);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(202, 56);
            this.Age_Label.TabIndex = 1;
            this.Age_Label.Text = "     Age     ";
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Label.Location = new System.Drawing.Point(8, 229);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(202, 59);
            this.Email_Label.TabIndex = 5;
            this.Email_Label.Text = "     Email";
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_Label.Location = new System.Drawing.Point(8, 61);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(202, 56);
            this.Gender_Label.TabIndex = 2;
            this.Gender_Label.Text = "     Gender";
            // 
            // Employee_Label
            // 
            this.Employee_Label.AutoSize = true;
            this.Employee_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Employee_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Label.Location = new System.Drawing.Point(8, 173);
            this.Employee_Label.Name = "Employee_Label";
            this.Employee_Label.Size = new System.Drawing.Size(202, 56);
            this.Employee_Label.TabIndex = 4;
            this.Employee_Label.Text = "     Employee Id";
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Label.Location = new System.Drawing.Point(8, 117);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(202, 56);
            this.Phone_Label.TabIndex = 3;
            this.Phone_Label.Text = "     Phone";
            // 
            // Age_Value
            // 
            this.Age_Value.AutoSize = true;
            this.Age_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Age_Value.Location = new System.Drawing.Point(216, 5);
            this.Age_Value.Name = "Age_Value";
            this.Age_Value.Size = new System.Drawing.Size(306, 56);
            this.Age_Value.TabIndex = 6;
            // 
            // Gender_Value
            // 
            this.Gender_Value.AutoSize = true;
            this.Gender_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender_Value.Location = new System.Drawing.Point(216, 61);
            this.Gender_Value.Name = "Gender_Value";
            this.Gender_Value.Size = new System.Drawing.Size(306, 56);
            this.Gender_Value.TabIndex = 7;
            // 
            // Phone_Value
            // 
            this.Phone_Value.AutoSize = true;
            this.Phone_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone_Value.Location = new System.Drawing.Point(216, 117);
            this.Phone_Value.Name = "Phone_Value";
            this.Phone_Value.Size = new System.Drawing.Size(306, 56);
            this.Phone_Value.TabIndex = 8;
            // 
            // EmployeeId_Value
            // 
            this.EmployeeId_Value.AutoSize = true;
            this.EmployeeId_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeId_Value.Location = new System.Drawing.Point(216, 173);
            this.EmployeeId_Value.Name = "EmployeeId_Value";
            this.EmployeeId_Value.Size = new System.Drawing.Size(306, 56);
            this.EmployeeId_Value.TabIndex = 9;
            // 
            // EmployeeViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmployeeViewToppanel);
            this.Name = "EmployeeViewPage";
            this.Size = new System.Drawing.Size(907, 642);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePhoto)).EndInit();
            this.EmployeeViewToppanel.ResumeLayout(false);
            this.EmployeeViewToppanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EmployeePhoto;
        private System.Windows.Forms.Panel EmployeeViewToppanel;
        private System.Windows.Forms.Label Name_Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Gender_Label;
        private System.Windows.Forms.Label Employee_Label;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Label Age_Value;
        private System.Windows.Forms.Label Gender_Value;
        private System.Windows.Forms.Label Phone_Value;
        private System.Windows.Forms.Label EmployeeId_Value;
        private System.Windows.Forms.Label Email_Value;
    }
}
