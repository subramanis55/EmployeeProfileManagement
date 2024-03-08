namespace EcommerceManagement
{
    partial class SimpleEmployeePanel
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
            this.Panel1 = new EcommerceManagement.CustomControls.CustomPanel();
            this.Name_Label = new System.Windows.Forms.Label();
            this.ProfilePhoto = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.AllBorderRadius = 30;
            this.Panel1.BorderColor = System.Drawing.Color.Black;
            this.Panel1.BorderMarginSize = 4;
            this.Panel1.BottomLeftRadius = 30;
            this.Panel1.BottomRight = 30;
            this.Panel1.Controls.Add(this.Name_Label);
            this.Panel1.Controls.Add(this.ProfilePhoto);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Panel1.Size = new System.Drawing.Size(767, 91);
            this.Panel1.TabIndex = 0;
            this.Panel1.TopLeftRadius = 30;
            this.Panel1.TopRightRadius = 30;
            this.Panel1.Click += new System.EventHandler(this.SimpleEmployeePanelClick);
            this.Panel1.DoubleClick += new System.EventHandler(this.SimpleEmployeePanelClick);
            this.Panel1.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.Panel1.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(20, 10);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(65, 24);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Name";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Name_Label.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // ProfilePhoto
            // 
            this.ProfilePhoto.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePhoto.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProfilePhoto.Image = global::EcommerceManagement.Properties.Resources.icons8_customer_96;
            this.ProfilePhoto.Location = new System.Drawing.Point(634, 10);
            this.ProfilePhoto.Name = "ProfilePhoto";
            this.ProfilePhoto.Size = new System.Drawing.Size(113, 71);
            this.ProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePhoto.TabIndex = 0;
            this.ProfilePhoto.TabStop = false;
            this.ProfilePhoto.MouseHover += new System.EventHandler(this.ProfilePhoto_Mouse_Hover);
            // 
            // SimpleEmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel1);
            this.Name = "SimpleEmployeePanel";
            this.Size = new System.Drawing.Size(767, 91);
            this.Click += new System.EventHandler(this.SimpleEmployeePanelClick);
            this.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.MouseHover += new System.EventHandler(this.Mouse_Hover);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private CustomControls.CustomPanel Panel1;
        private System.Windows.Forms.PictureBox ProfilePhoto;
        private System.Windows.Forms.Label Name_Label;
    }
}
