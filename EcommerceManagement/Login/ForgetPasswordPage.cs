using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceManagement.Login
{
    public partial class ForgetPasswordPage : UserControl
    {
         
        private string emailPaceholder = "Enter the Email";
        private string newPasswordPaceholder = "New Password";
        private string confirmPasswordPaceholder = "Confirm Password";
        private string email;
        private bool isemailPaceholder = true;
        private bool isnewPasswordPaceholder = true;
        private bool isconfirmPasswordPaceholder = true;
        public event EventHandler<List<string>> ForgetPasswordPageDetailsGet;
        private Timer timer;

        public ForgetPasswordPage()
        {
            InitializeComponent();
        }
        public ForgetPasswordPage(string loginEmail)
        {
            InitializeComponent();
            email = loginEmail;
        }
        
        private void EmailTBChanged(object sender, EventArgs e)
        {

        }

        private void NewPasswordTBChanged(object sender, EventArgs e)
        {
          
        }

        private void ConfirmTextBoxChanged(object sender, EventArgs e)
        {
           

        }

        private void ShowCheckedBoxChanged(object sender, EventArgs e)
        {
            if (PasswordShowCheckBox.Checked == true)
            {
                NewPasswordTB.UseSystemPasswordChar = false;
                ConfirmPasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                if (NewPasswordTB.Text != newPasswordPaceholder)
                    NewPasswordTB.UseSystemPasswordChar = true;
                if (ConfirmPasswordTB.Text != confirmPasswordPaceholder)
                    ConfirmPasswordTB.UseSystemPasswordChar = true;
            }
        }

        private void ConfirmBtnClick(object sender, MouseEventArgs e)
        {
            if(ConfirmPasswordTB.Text==NewPasswordTB.Text&& ConfirmPasswordTB.Text!=" "&&email==EmailTB.Text){
                ForgetPasswordPageDetailsGet?.Invoke(this, new List<string> { ConfirmPasswordTB.Text });
            }
             else{
               
                if (EmailTB.Text !=email)
                {
                    EmailInvalidIcon.Visible = true;
                }
                if (NewPasswordTB.Text != ConfirmPasswordTB.Text || ConfirmPasswordTB.Text == "")
                {
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
            
            EmailInvalidIcon.Visible = false;
            NewPasswordInvalidIcon.Visible = false;
            ConfirmPasswordInvalidIcon.Visible = false;
            timer.Stop();
            timer.Dispose();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
