namespace EcommerceManagement
{
    partial class AlertBox
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
            this.components = new System.ComponentModel.Container();
            this.NotificationTypeLB = new System.Windows.Forms.Label();
            this.BottomLinePanel = new System.Windows.Forms.Panel();
            this.NotifypictureBox = new System.Windows.Forms.PictureBox();
            this.InformationText = new System.Windows.Forms.Label();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.ellipseControl1 = new EcommerceManagement.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.NotifypictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationTypeLB
            // 
            this.NotificationTypeLB.AutoSize = true;
            this.NotificationTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationTypeLB.Location = new System.Drawing.Point(91, 20);
            this.NotificationTypeLB.Name = "NotificationTypeLB";
            this.NotificationTypeLB.Size = new System.Drawing.Size(43, 20);
            this.NotificationTypeLB.TabIndex = 0;
            this.NotificationTypeLB.Text = "Title";
            // 
            // BottomLinePanel
            // 
            this.BottomLinePanel.Location = new System.Drawing.Point(3, 87);
            this.BottomLinePanel.Name = "BottomLinePanel";
            this.BottomLinePanel.Size = new System.Drawing.Size(31, 10);
            this.BottomLinePanel.TabIndex = 3;
            // 
            // NotifypictureBox
            // 
            this.NotifypictureBox.Location = new System.Drawing.Point(27, 20);
            this.NotifypictureBox.Name = "NotifypictureBox";
            this.NotifypictureBox.Size = new System.Drawing.Size(48, 44);
            this.NotifypictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotifypictureBox.TabIndex = 2;
            this.NotifypictureBox.TabStop = false;
            // 
            // InformationText
            // 
            this.InformationText.AutoSize = true;
            this.InformationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationText.Location = new System.Drawing.Point(91, 51);
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(45, 16);
            this.InformationText.TabIndex = 4;
            this.InformationText.Text = "label3";
            this.InformationText.Click += new System.EventHandler(this.InformationText_Click);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Tick += new System.EventHandler(this.TimerAnimationTick);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 40;
            this.ellipseControl1.TargetControl = this;
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.BottomLinePanel);
            this.Controls.Add(this.NotifypictureBox);
            this.Controls.Add(this.NotificationTypeLB);
            this.MinimumSize = new System.Drawing.Size(350, 100);
            this.Name = "AlertBox";
            this.Size = new System.Drawing.Size(366, 100);
            this.Load += new System.EventHandler(this.AlertBoxLoad);
            ((System.ComponentModel.ISupportInitialize)(this.NotifypictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationTypeLB;
        private System.Windows.Forms.PictureBox NotifypictureBox;
        private System.Windows.Forms.Panel BottomLinePanel;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Label InformationText;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}
