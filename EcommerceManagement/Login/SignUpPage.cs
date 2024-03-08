using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcommerceManagement.CustomControls;

namespace EcommerceManagement.Login
{
    public partial class SignUpPage : UserControl
    {
    public event EventHandler<List<string>> SignUpDeatailsGet;
        private string userNamePaceholder = "Username";
        private string emailPaceholder = "Enter the Email";
        private string newPasswordPaceholder = "New Password";
        private string confirmPasswordPaceholder = "Confirm Password";
        private bool isUserNamePaceholder = true;
        private bool isemailPaceholder = true;
        private bool isnewPasswordPaceholder = true;
        private bool isconfirmPasswordPaceholder = true;
        private Timer timer;

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpBtnClick(object sender, EventArgs e)
        {   if(ConfirmPasswordTB.Text==NewPasswordTB.Text&& ConfirmPasswordTB.Text!=""&&EmailTB.Text!=""&&UsernameTB.Text!=""){
                SignUpDeatailsGet?.Invoke(this, new List<string> { UsernameTB.Text, EmailTB.Text, ConfirmPasswordTB.Text });
                this.Dispose();
            }
            else{
                if(UsernameTB.Text == ""){
                    UsernameInvalidIcon.Visible = true;
                }
                if(EmailTB.Text == ""){
                    EmailInvalidIcon.Visible = true;
                }
                if(NewPasswordTB.Text!=ConfirmPasswordTB.Text|| ConfirmPasswordTB.Text == ""){
                    NewPasswordInvalidIcon.Visible = true;
                    ConfirmPasswordInvalidIcon.Visible = true;
                }
                timer = new Timer();
                timer.Interval = 6000;
                timer.Tick += InvalidIconStop;
                timer.Start();
            }
        }

        public void InvalidIconStop(object sender, EventArgs e)
        {
            UsernameInvalidIcon.Visible = false;
            EmailInvalidIcon.Visible = false;
            NewPasswordInvalidIcon.Visible = false;
            ConfirmPasswordInvalidIcon.Visible = false;
            timer.Stop();
            timer.Dispose();
        }

        private void EmailTBClick(object sender, MouseEventArgs e)
        {
            isemailPaceholder = false;
            EmailTB.Text = "";

        }

        private void UsernameTBClick(object sender, MouseEventArgs e)
        {
            isUserNamePaceholder = false;
            UsernameTB.Text = "";
        }

        private void NewPasswordTBClick(object sender, MouseEventArgs e)
        {
            isnewPasswordPaceholder = true;
            NewPasswordTB.Text = "";
        }

        private void ConfirmPasswordChanged(object sender, EventArgs e)
        {
             
       
         //   ShowCheckBoxChanged(sender, e);
        }

        private void NewPasswordTBChanged(object sender, EventArgs e)
        {
            
        }

        private void ConfirmPasswordTBClick(object sender, MouseEventArgs e)
        {
            isconfirmPasswordPaceholder = false;
            ConfirmPasswordTB.Text = "";
        }

        private void PasswordShowcheckBox(object sender, EventArgs e)
        {
          if(PasswordShowCB.Checked){
                if (NewPasswordTB.Text != NewPasswordTB.PaceholderText)
                {
                    NewPasswordTB.UseSystemPasswordChar = false;
                }
                if (ConfirmPasswordTB.Text != ConfirmPasswordTB.PaceholderText)
                {
                    ConfirmPasswordTB.UseSystemPasswordChar = false;
                }
            }
            else{
                if (NewPasswordTB.Text != NewPasswordTB.PaceholderText)
                {
                    NewPasswordTB.UseSystemPasswordChar = true;
                }
                if (ConfirmPasswordTB.Text != ConfirmPasswordTB.PaceholderText)
                {
                    ConfirmPasswordTB.UseSystemPasswordChar = true;
                }
            }
        }

        private void TBMouseEnter(object sender, EventArgs e)
        {

        }

        private void TBMouseLeave(object sender, EventArgs e)
        {

        }

        private void TBLeave(object sender, EventArgs e)
        {

        }

        private void TBEnter(object sender, EventArgs e)
        {

        }

        private void PasswordEnter(object sender, EventArgs e)
        {

        }
    }
}
