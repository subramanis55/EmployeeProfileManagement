using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcommerceManagement.Login;
namespace EcommerceManagement
{
    public partial class LoginForm : Form
    {
        private String email = "a";
        private String password = "a";
        private String username;
        bool isEmailTextExist = false;
        bool isPasswordTextExist = false;
        Color rgpBlueColor = Color.FromArgb(0, 117, 214);
        Color rgpWhiteColor = Color.FromArgb(255, 255, 255);
        public int ForgetPasswordLinkLabelX { get; set; }
        public int ForgetPasswordLinkLabelY { get; set; }
        private bool isPasswordPaceholder = true;
        private string passwordPaceholder = "Enter the password";
        private bool isEmailPaceholder = true;
        private string emailPaceholder = "Enter the email";
        private Timer timer;
        public LoginForm()
        {
            InitializeComponent();
            /// EmailTB.SelectionStart = 0;
            // PasswordTB.SelectionStart = 0;
    
            
        }
        private void button1_Hover(object sender, EventArgs e)
        {
            LoginBtn.BackColor = rgpWhiteColor;
            LoginBtn.ForeColor = rgpBlueColor;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            LoginBtn.BackColor = rgpBlueColor;
            LoginBtn.ForeColor = rgpWhiteColor;
        }
        public void InvalidIconStop(object sender, EventArgs e)
        {
            PasswordInvalidIcon.Visible = false;
            EmailInvalidIcon.Visible = false;
            timer.Stop();
            timer.Dispose();
        }
        private void LoginBtnClick(object sender, EventArgs e)
        {
            if (EmailTB.Text == email && PasswordTB.Text == password && PasswordTB.Text != null)
            {
                this.Hide() ;
                Form1 obj = new Form1();
                obj.Show();
            }
            else{
            if(EmailTB.Text != email){
                    PasswordInvalidIcon.Visible = true;
                    EmailInvalidIcon.Visible = true;
                }
               else{ 
                    PasswordInvalidIcon.Visible = true;
                }
               
                timer = new Timer();
                timer.Interval = 6000;
                timer.Tick += InvalidIconStop;
               timer.Start();
                EmailTB.Clear();
                PasswordTB.Clear();
                EmailTBLeave(sender,e);
                PasswordTBLeave(sender, e);
            }
        }
        public void InformationGet(object sender, List<string> args)
        {
            LoginpagePanel.Visible = true;

            if (sender is ForgetPasswordPage)
            {
                password = args[0];
            }
            if (sender is SignUpPage)
            {
                username = args[0];
                email = args[1];
                password = args[2];
            }
        }
        private void SignUpBtnClick(object sender, EventArgs e)
        {
            SignUpPage obj = new SignUpPage();
            obj.SignUpDeatailsGet += InformationGet;
            obj.Dock = DockStyle.Fill;
            this.Controls.Add(obj);
            obj.Location = LoginpagePanel.Location;
            obj.BringToFront();
        }

        private void ForgetPasswordLinkHover(object sender, EventArgs e)
        {
            ForgetPassWordLinkLabel.Font = new System.Drawing.Font(ForgetPassWordLinkLabel.Font.FontFamily, 12, ForgetPassWordLinkLabel.Font.Style);
            ForgetPassWordLinkLabel.Location = new System.Drawing.Point(ForgetPassWordLinkLabel.Location.X- 5, ForgetPassWordLinkLabel.Location.Y - 1);
        }

        private void ForgetPasswordLinkLeave(object sender, EventArgs e)
        {
            ForgetPassWordLinkLabel.Font = new System.Drawing.Font(ForgetPassWordLinkLabel.Font.FontFamily, 10, ForgetPassWordLinkLabel.Font.Style);
            ForgetPassWordLinkLabel.Location = new System.Drawing.Point(ForgetPassWordLinkLabel.Location.X + 5, ForgetPassWordLinkLabel.Location.Y + 1);
        }

        private void PasswordShowCBChanged(object sender, EventArgs e)
        {
            if (PasswordTB.Text != passwordPaceholder)
            {
                if (PasswordShowcheckBox.Checked == true)
                {
                    PasswordTB.UseSystemPasswordChar = false;
                }
                else
                {
                    PasswordTB.UseSystemPasswordChar = true;
                }
            }
        }

        private void EmailTBChanged(object sender, MouseEventArgs e)
        {
            if (isEmailTextExist == false)
            {
                EmailTB.Clear();
                isEmailTextExist = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ForgetPassWordLinkClicked(object sender, EventArgs e)
        {
            
            ForgetPasswordPage obj = new ForgetPasswordPage();
            obj.ForgetPasswordPageDetailsGet += InformationGet;
            obj.Dock = DockStyle.Fill;
            this.Controls.Add(obj);
            obj.Location = LoginpagePanel.Location;
            obj.BringToFront();
        }

        private void PasswordTBChanged(object sender, EventArgs e)
        {
           
        }

        private void EmailTBTextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTBEnter(object sender, EventArgs e)
        {    
                if (EmailTB.Text == emailPaceholder&&isEmailPaceholder){
                EmailTB.Text = "";
                isEmailPaceholder = false;
            }
        }
        private void EmailTBMouseEnterd(object sender, EventArgs e)
        {
            if (EmailTB.Text == emailPaceholder && isEmailPaceholder)
            {
                EmailTB.Text = "";
                isEmailPaceholder = false;
            }
              
        }

        private void EmailTBMouseLeaved(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTB.Text) && !EmailTB.Focused)
            {
                EmailTB.Text = emailPaceholder;
                isEmailPaceholder = true;
            }
               
        }

        private void EmailTBLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTB.Text)){
                EmailTB.Text = emailPaceholder;
                isEmailPaceholder = true;
            }
               
        }

        private void PasswordTBMouseEnter(object sender, EventArgs e)
        {
            if (PasswordTB.Text == passwordPaceholder && isPasswordPaceholder)
            {
                PasswordTB.Text = "";
                PasswordTB.UseSystemPasswordChar = true;
                isPasswordPaceholder = false;
            }

        }

        private void PasswordTBMouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTB.Text) && !PasswordTB.Focused)
            {
                PasswordTB.Text = passwordPaceholder;
                PasswordTB.UseSystemPasswordChar = false;
                isPasswordPaceholder = true;
            }

        }

        private void PasswordTBLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTB.Text))
            {
                PasswordTB.UseSystemPasswordChar = false;
                PasswordTB.Text = passwordPaceholder;
                isPasswordPaceholder = true;
            }
        }

        private void PasswordTBEnter(object sender, EventArgs e)
        {
            if (PasswordTB.Text == passwordPaceholder && isPasswordPaceholder)
            {
                PasswordTB.Text = "";
                PasswordTB.UseSystemPasswordChar = true;
                isPasswordPaceholder = false;
            }
        }
    }
}
