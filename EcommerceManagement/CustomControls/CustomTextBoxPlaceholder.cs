using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceManagement.CustomControls
{
    class CustomTextBoxPlaceholder : TextBox
    {
        private bool isPlaceholder = false;
        private string placeholderText;
        private bool custemUseSystemPasswordChar;
          public CustomTextBoxPlaceholder():base(){

           
              MouseEnter += TBMouseEnter;
           MouseLeave += TBMouseLeave;
            Leave += TBLeave;
            Enter += TBEnter;
          }
        public bool IsPlaceholder
        {
            get
            {
                return isPlaceholder;
            }
            set
            {
                isPlaceholder = value;
                if (isPlaceholder)
                    Text = placeholderText;
                Invalidate();
            }
        }

        public string PaceholderText
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                if (isPlaceholder)
                    Text = placeholderText;
                Invalidate();
            }
        }

        public bool CustemUseSystemPasswordChar
        {
            get
            {
                return custemUseSystemPasswordChar;
            }

            set
            {
                custemUseSystemPasswordChar = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (isPlaceholder)
            {
                using (var brush = new SolidBrush(SystemColors.GrayText))
                {
                    e.Graphics.DrawString(placeholderText, this.Font, brush, new PointF(0, 0));
                }
            }
         
        }
        private void Load(object sender,EventArgs e){
            //custemUseSystemPasswordChar = UseSystemPasswordChar;
        }
        private void TBMouseEnter(object sender, EventArgs e)
        {
            if (Text ==PaceholderText && isPlaceholder)
            {
                Text = "";
                isPlaceholder = false;
                if (CustemUseSystemPasswordChar)
                UseSystemPasswordChar = true;

            }
          
        }

        private void TBMouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text) && !Focused)
            {
                Text = PaceholderText;
                isPlaceholder = true;
                if (CustemUseSystemPasswordChar)
                    UseSystemPasswordChar = false;
            }
            
        }

        private void TBLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = placeholderText;
                isPlaceholder = true;
                if (CustemUseSystemPasswordChar)
                    UseSystemPasswordChar = false;
            }
        }

        private void TBEnter(object sender, EventArgs e)
        {
            if (Text == placeholderText &&isPlaceholder)
            {
                Text = "";
                isPlaceholder = false;
                if (CustemUseSystemPasswordChar)
                    UseSystemPasswordChar = true;
            }
        }
        

    }
}
