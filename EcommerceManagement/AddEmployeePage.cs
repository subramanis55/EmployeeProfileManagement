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
    public partial class AddEmployeePage : UserControl
    {
        public EventHandler OnSubmitBtnClickRefresh;
        public EventHandler<List<string>> OnSubmitBtnClick;
        List<string> EmployeeDetails = new List<string>();
        String ImagePath = "";
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            
            EmployeeDetails.Add(Name_TextBox.Text);
            EmployeeDetails.Add(Age_TextBox.Text);
            EmployeeDetails.Add(Gender_TextBox.Text);
            EmployeeDetails.Add(Phone_TextBox.Text);
            EmployeeDetails.Add(EmployeeId_TextBox.Text);
            EmployeeDetails.Add(Email_TextBox.Text);
            EmployeeDetails.Add(ImagePath);
            OnSubmitBtnClick?.Invoke(this,EmployeeDetails);
            Name_TextBox.Text = "";
            Age_TextBox.Text = "";
            Gender_TextBox.Text = "";
            Phone_TextBox.Text = "";
            EmployeeId_TextBox.Text = "";
            Email_TextBox.Text = "";
            OnSubmitBtnClickRefresh?.Invoke(this, e);
            this.Dispose();
           
        }
       
        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = dialog.FileName;
                }
                if (ImagePath != null&& ImagePath !="")
                {
                    PhotoUploadBtn.BackColor = Color.ForestGreen;
                   // SuccessIamgeUploadTick.InitialImage=Properties.Resources.TickAnimationIcon;
                    SuccessIamgeUploadTick.Image= Properties.Resources.TickAnimationIcon; 

                }
            }
            catch(Exception ex)
            {
              
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
