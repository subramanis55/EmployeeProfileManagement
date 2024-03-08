namespace EcommerceManagement
{
    partial class ConfirmationForm
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
            this.FormText = new System.Windows.Forms.Label();
            this.ellipseButton1 = new EcommerceManagement.CustomControls.EllipseButton();
            this.ellipseButton2 = new EcommerceManagement.CustomControls.EllipseButton();
            this.SuspendLayout();
            // 
            // FormText
            // 
            this.FormText.AutoSize = true;
            this.FormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormText.Location = new System.Drawing.Point(40, 36);
            this.FormText.Name = "FormText";
            this.FormText.Size = new System.Drawing.Size(51, 16);
            this.FormText.TabIndex = 0;
            this.FormText.Text = "label1";
            this.FormText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ellipseButton1
            // 
            this.ellipseButton1.BackColor = System.Drawing.Color.Red;
            this.ellipseButton1.BackgroudColor = System.Drawing.Color.Red;
            this.ellipseButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ellipseButton1.BorderRadius1 = 12;
            this.ellipseButton1.BorderSize1 = 0;
            this.ellipseButton1.FlatAppearance.BorderSize = 0;
            this.ellipseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseButton1.ForeColor = System.Drawing.Color.White;
            this.ellipseButton1.Location = new System.Drawing.Point(146, 77);
            this.ellipseButton1.Name = "ellipseButton1";
            this.ellipseButton1.Size = new System.Drawing.Size(60, 30);
            this.ellipseButton1.TabIndex = 1;
            this.ellipseButton1.Text = "No";
            this.ellipseButton1.TextColor = System.Drawing.Color.White;
            this.ellipseButton1.UseVisualStyleBackColor = false;
            this.ellipseButton1.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // ellipseButton2
            // 
            this.ellipseButton2.BackColor = System.Drawing.Color.Green;
            this.ellipseButton2.BackgroudColor = System.Drawing.Color.Green;
            this.ellipseButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ellipseButton2.BorderRadius1 = 15;
            this.ellipseButton2.BorderSize1 = 0;
            this.ellipseButton2.FlatAppearance.BorderSize = 0;
            this.ellipseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseButton2.ForeColor = System.Drawing.Color.White;
            this.ellipseButton2.Location = new System.Drawing.Point(54, 77);
            this.ellipseButton2.Name = "ellipseButton2";
            this.ellipseButton2.Size = new System.Drawing.Size(60, 30);
            this.ellipseButton2.TabIndex = 2;
            this.ellipseButton2.Text = "Yes";
            this.ellipseButton2.TextColor = System.Drawing.Color.White;
            this.ellipseButton2.UseVisualStyleBackColor = false;
            this.ellipseButton2.Click += new System.EventHandler(this.YesButtonClick);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 146);
            this.Controls.Add(this.ellipseButton2);
            this.Controls.Add(this.ellipseButton1);
            this.Controls.Add(this.FormText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormText;
        private CustomControls.EllipseButton ellipseButton1;
        private CustomControls.EllipseButton ellipseButton2;
    }
}