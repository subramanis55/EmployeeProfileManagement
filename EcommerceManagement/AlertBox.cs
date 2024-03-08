using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceManagement
{
    public partial class AlertBox : UserControl
    {
        public AlertBox()
        {
            InitializeComponent();
        }
        public Color BackColorAlertBox
        {
            get { return BackColor; }
            set { BackColor = value; }
        }
        public Color ColorAlertBox
        {
            get { return BottomLinePanel.BackColor; }
            set { BottomLinePanel.BackColor = InformationText.ForeColor = NotificationTypeLB.ForeColor = value; }
        }
        public Image NotifyPicture
        {
            get { return NotifypictureBox.Image; }
            set { NotifypictureBox.Image = value;
              
            }
        }
        public string NotificationTypeText
        {
            get { return NotificationTypeLB.Text; }
            set { NotificationTypeLB.Text = value; }
        }
        public string NotificationInformationText
        {
            get { return InformationText.Text; }
            set { InformationText.Text = value; }
        }
        private void PositionAlertBox()
        {
            int xPos = 0, yPos = 0;
            xPos = this.ClientSize.Width;
            yPos = this.ClientSize.Height;
            //     xPos = Screen.GetWorkingArea(this).Width;
            //    yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);

        }
        private void TimerAnimationTick(object sender, EventArgs e)
        {
            BottomLinePanel.Width = BottomLinePanel.Width + 4;
            if (BottomLinePanel.Width >= 500)
            {      
                this.Dispose();
            }
        }

        private void AlertBoxLoad(object sender, EventArgs e)
        {
            PositionAlertBox();
            for (int i = 0; i < 500; i++)
            {
                AnimationTimer.Start();
            }
        }

        private void BottomLinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformationText_Click(object sender, EventArgs e)
        {

        }
    }
}
