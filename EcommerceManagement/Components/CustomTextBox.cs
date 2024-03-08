using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EcommerceManagement.Components
{
    public partial class CustomTextBox : UserControl
    {
        private Color borderColor = Color.MediumBlue;
        private int borderSize = 2;
        private int borderRadius = 0;
        private bool underLineStyle = false;
        private Color borderFocusColor = Color.DodgerBlue;
        private event EventHandler TextChanged;
        private bool isFocused;
        private Color placeholderColor=Color.DarkGray;
     
        private bool isPlaceholder;
        private string placeholderText;
        public CustomTextBox()
        {
            InitializeComponent();
        }
        [DefaultValue("CustomProperties")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
       
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public bool UnderLineStyle
        {
            get
            {
                return underLineStyle;
            }
            set
            {
                underLineStyle = value;
                Invalidate();
            }
        }

        public bool PasswordChar
        {
            get{return textBox1.UseSystemPasswordChar;}
            set{textBox1.UseSystemPasswordChar = value;Invalidate();}
        }

        public bool Multiline
        {
            get{return textBox1.Multiline;}
            set{textBox1.Multiline = value;Invalidate();}
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
                if(DesignMode){
                    UpdateControlHeight();
                }
            }
        }

        public string Texts{
          get{
                if (isPlaceholder)
                    return "";
                return textBox1.Text;
          }
          set{
                textBox1.Text = value;
                SetPlaceHolder();
          }
        }

        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }

       

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                Invalidate();
            }
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
            }
        }

        public Color PlaceholderColor
        {
            get
            {
                return placeholderColor;
            }

            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }

        public string PlaceholderText
        {
            get
            {
                return placeholderText;
            }

            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }

        private void SetPlaceHolder()
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text)&&placeholderText!=""){
                isPlaceholder = true;
                textBox1.Text = PlaceholderText;
                textBox1.ForeColor = placeholderColor;
                if (PasswordChar)
                    textBox1.UseSystemPasswordChar = false;

            }
        }
        private void RemovePlaceHolder(){
            if(isPlaceholder&&placeholderText!=""){
                isPlaceholder = false;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = PlaceholderColor;
                if (PasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }

        public GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (BorderRadius > 1)
            {
                var rectBorderout = ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderout, -borderRadius, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderout = GetFigurePath(rectBorderout, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penPathBorderOut = new Pen(Parent.BackColor, smoothSize))
                using (Pen penPathBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderout);
                    if (borderRadius > 15) setTextBoxRoundRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penPathBorder.Alignment = PenAlignment.Center;
                    if (isFocused)
                        penPathBorder.Color = borderFocusColor;
                    if(underLineStyle){
                        graph.DrawPath(penPathBorderOut, pathBorderout);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penPathBorder,0,Height-1,Width,Height-1);
                    }
                    else
                    {
                        graph.DrawPath(penPathBorderOut, pathBorderout);
                        graph.DrawPath(penPathBorder, pathBorder);
                    }

                }
            }
            else{ 
                if (isFocused)
                    borderColor = borderFocusColor;
                using (Pen penBorder = new Pen(borderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    if (underLineStyle)
                        graph.DrawLine(penBorder, 1, Height - 1, Width - 1, Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, Width -1, Height - 1);
                }

            }
        }

      private void setTextBoxRoundRegion()
        {
            GraphicsPath pathText;
            if(Multiline){
                pathText = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathText);
            }
            else{
                pathText = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathText);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
            Invalidate();
        }

        private void UpdateControlHeight(){
        if(textBox1.Multiline==true)
        {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                Height = textBox1.Height + Padding.Top + Padding.Bottom;
        }
        }
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(sender,e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void TextBoxClick(object sender, MouseEventArgs e)
        {
            OnClick(e);           
        }

        private void TextBoxMouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void TextBoxEnter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
        }

        private void TextBoxLeave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
        }

    }
}
