using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace EcommerceManagement
{
    public partial class SimpleEmployeePanel : UserControl
    {
        Color hoverGray = Color.FromArgb(255, 245, 249, 248);
        Color SelectColor = Color.FromArgb(255, 218, 219, 222);
        public string Name { set; get; }
        public string ImagePath { set; get; }
        [Category("Custom Category")]
        public int CornerRadius{ set; get; }
        public Color FocusColor{
           set{
                Panel1.BorderColor = value;
           }
           get{
                return Panel1.BorderColor;
           }
           
        }
        public SimpleEmployeePanel()
        {
            InitializeComponent();
        }
        public EventHandler OnClick;
        public SimpleEmployeePanel(string name,String ImagePath)
        {
            InitializeComponent();
            Name_Label.Text = name;
            ProfilePhoto.ImageLocation = ImagePath;
            this.ImagePath = ImagePath;
            Name = name;
            this.Region = Panel1.Region;
            Name_Label.ForeColor = Color.Black;
        }
  
        private void ProfilePhoto_Mouse_Hover(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
            
        }

        private void ProfilePhoto_Mouse_Leave(object sender, EventArgs e)
        {
         //   Leave();
        }

        private void Panel_Leave(object sender, EventArgs e)
        {
          //  Leave();
        }


        bool isUp = false;
        private void Mouse_Hover(object sender, EventArgs e)
        {           
                     
                   DoubleBuffered = true;
                    Panel1.BackColor = SelectColor;                          
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {               
                    Panel1.BackColor = Color.White;                      
        }
        
        
        private void SimpleEmployeePanelClick(object sender, EventArgs e)
        {
            OnClick?.Invoke(this, e); ;
        }
    }
}
