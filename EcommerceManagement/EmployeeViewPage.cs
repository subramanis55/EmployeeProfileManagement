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
    public partial class EmployeeViewPage : UserControl
    {
        public EmployeeViewPage()
        {
            InitializeComponent();
        }
        
        public EmployeeViewPage(string name,string age, string sex,string Phone,string employeeId,string email,string ImagePath)
        {
            InitializeComponent();
            Name_Value.Text = name;
            Age_Value.Text =""+ age;
            Gender_Value.Text = sex;
            Phone_Value.Text = Phone;
            EmployeeId_Value.Text = employeeId;
            Email_Value.Text = email;
            EmployeePhoto.ImageLocation = ImagePath;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
