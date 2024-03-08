using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        int PreviousPage = -1;
        private Panel PreviousPagePanel;
        private List<List<string>> Employee_List = new List<List<string>>();
        SimpleEmployeePanel CurrentSimpleEmployeePanel = null;
        private List<SimpleEmployeePanel> SimpleEmployeePanels_List = new List<SimpleEmployeePanel>();
        private void Form_Resize(object sender, EventArgs e)
        {
            MenuPanel.Width = (this.Width/ 10) * 2;
            TopPanel.Height = (this.Height / 12) * 2;
            TopPanel.Padding = new Padding(TopPanel.Padding.Left, (this.Height / 15) * 1, TopPanel.Padding.Right, TopPanel.Padding.Bottom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void MenuPanel_Resize(object sender, EventArgs e)
        {
            MenuTopPanel.Height =(this.Height/7)*2;
            MenuBottomPanel.Height = (this.Height / 7) * 5;
        }

        private void Contacts_Btn_Click(object sender, EventArgs e)
        {
            flowLayoutShowPanel.Visible = true;

            if (PreviousPage != 0)
            {
                if (PreviousPagePanel != null)
                {
                    PreviousPagePanel.BackColor = Color.FromArgb(0,192, 192);
                }
                PreviousPagePanel = ContactPanel;
                ContactPanel.BackColor = Color.Teal;
                
               flowLayoutShowPanel.Controls.Clear();
               
                PreviousPage = 0;
                Contacs_Btn_Panel.Visible = true;
               
                for (int i = 0; i < Employee_List.Count; i++)
                {
                    SimpleEmployeePanel obj = new SimpleEmployeePanel(Employee_List[i][0], Employee_List[i][Employee_List[i].Count-1]);
                    obj.OnClick+=SimplePanelMouseClickStore;
                    obj.Dock = DockStyle.Top;
                    obj.Height = 150;
                    SimpleEmployeePanels_List.Add(obj);
                    flowLayoutShowPanel.Controls.Add(obj);
                }
                
            }
           
        }

        private void Products_Btn_Click(object sender, EventArgs e)
        {
            if (PreviousPagePanel != null)
            {
                PreviousPagePanel.BackColor = Color.FromArgb(0, 192, 192);
            }
            PreviousPagePanel = ProductsPanel;
            ProductsPanel.BackColor = Color.Teal;
            flowLayoutShowPanel.Visible = false;
            
            Contacs_Btn_Panel.Visible = false;
            for(int i = 0; i < SimpleEmployeePanels_List.Count; i++)
            {
                SimpleEmployeePanels_List[i].Dispose();
            }
            SimpleEmployeePanels_List.Clear();
            if (PreviousPage != 1)
            {
              //  flowLayoutShowPanel.Controls.Clear();
                PreviousPage = 1;
            }

            }

        private void Sales_Btn_Click(object sender, EventArgs e)
        {
            if (PreviousPagePanel != null)
            {
                PreviousPagePanel.BackColor = Color.FromArgb(0, 192, 192);
            }
            PreviousPagePanel = SalesPanel;
          SalesPanel.BackColor = Color.Teal;
            Contacs_Btn_Panel.Visible = false;
           
            flowLayoutShowPanel.Visible = false;
            SimpleEmployeePanels_List.Clear();
            for (int i = 0; i < SimpleEmployeePanels_List.Count; i++)
            {
                SimpleEmployeePanels_List[i].Dispose();
            }
            
            if (PreviousPage != 2)
            {
              //  flowLayoutShowPanel.Controls.Clear();
                PreviousPage = 2;
            }

        }
         
        private void Camera_Btn_Click(object sender, EventArgs e)
        {
            if (PreviousPagePanel != null)
            {
                PreviousPagePanel.BackColor = Color.FromArgb(0, 192, 192);
            }
            PreviousPagePanel = CameraPanel;
            CameraPanel.BackColor = Color.Teal;
            flowLayoutShowPanel.Visible = false;
           
            SimpleEmployeePanels_List.Clear();
            for (int i = 0; i < SimpleEmployeePanels_List.Count; i++)
            {
                SimpleEmployeePanels_List[i].Dispose();
            }
            Contacs_Btn_Panel.Visible = false;
            if (PreviousPage != 3)
            {
               // flowLayoutShowPanel.Controls.Clear();
                PreviousPage = 3;
            }

        }
        private void Setting_Btn_Click(object sender, EventArgs e)
        {
            if (PreviousPagePanel != null)
            {
                PreviousPagePanel.BackColor = Color.FromArgb(0, 192, 192);
            }
            PreviousPagePanel = SettingPanel;
            SettingPanel.BackColor = Color.Teal;
            Contacs_Btn_Panel.Visible = false;
            
           
            flowLayoutShowPanel.Visible= false;
            for (int i = 0; i < SimpleEmployeePanels_List.Count; i++)
            {
                SimpleEmployeePanels_List[i].Dispose();
            }
            SimpleEmployeePanels_List.Clear();
            if (PreviousPage != 4)
            {
               // flowLayoutShowPanel.Controls.Clear();
                PreviousPage = 4;
            }
        }
        private void MenuTopPanel_Resize(object sender, EventArgs e)
        {
            MenuTopPanel.Padding = new Padding(MenuTopPanel.Width/10, (MenuTopPanel.Height/10), MenuTopPanel.Width / 14, (MenuTopPanel.Height / 10));
            CompanyLogo.Height = (MenuTopPanel.Height / 6) * 2;
            CompanyLogo.Width = (MenuTopPanel.Width / 6) * 4;
            SearchBox.Width = (MenuTopPanel.Width / 6) * 4;
            SearchBox.Height = (MenuTopPanel.Height / 12) * 2;

        }

        private void BottomPanel_Resize(object sender, EventArgs e)
        {
            MenuBottomPanel.Padding = new Padding((MenuTopPanel.Width / 14), (MenuBottomPanel.Height / 16), (MenuTopPanel.Width / 14), (MenuBottomPanel.Height / 14));
        }

        public void SimplePanelMouseClickStore(object sender, EventArgs e)
        {
            CurrentSimpleEmployeePanel =(SimpleEmployeePanel) sender;
        }

        private void MenuLogo_Click(object sender, EventArgs e)
        {
            if (MenuPanel.Visible == false)
            {
               // MenuPanel.Dock = DockStyle.Left;
                MenuPanel.Visible = true;
            }
            else
            {
               // MenuPanel.Dock = DockStyle.Left;
                MenuPanel.Visible = false;
            }

        }

        private void TopPanel_Resize(object sender, EventArgs e)
        {
           

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
         
        private void AddPeople_Click(object sender, EventArgs e)
        {
         
            //   flowLayoutShowPanel.Controls.Clear();
            flowLayoutShowPanel.Visible= false;
            
            
            AddEmployeePage addEmployeePageObj = new AddEmployeePage();
            //addEmployeePageObj.Height = 122;
            addEmployeePageObj.Dock = DockStyle.Left;
            this.MainPanel.Controls.Add(addEmployeePageObj);
            addEmployeePageObj.OnSubmitBtnClick += SaveDetailsEmployeeList;
            PreviousPage = -1;
            addEmployeePageObj.OnSubmitBtnClickRefresh += Contacts_Btn_Click;
            
            Contacs_Btn_Panel.Visible = false;
        }
        private void SaveDetailsEmployeeList(object sender,List<string> e)
        {
            
            Employee_List.Add(new List<string>(e));
            Contacs_Btn_Panel.Visible = true;
           
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addEmployeePage1_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeePage1_Load_1(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (CurrentSimpleEmployeePanel != null)
            {
                for (int i = 0; i < Employee_List.Count; i++)
                {
                    if (CurrentSimpleEmployeePanel.Name== Employee_List[i][0]&& CurrentSimpleEmployeePanel.ImagePath == Employee_List[i][Employee_List[i].Count - 1])
                    {
                        Employee_List.RemoveAt(i);
                        break;
                    }
            }
                CurrentSimpleEmployeePanel.Dispose();
            SimpleEmployeePanels_List.Remove(CurrentSimpleEmployeePanel);
        }
            Contacts_Btn_Click(this,e);
        }

        private void ViewDetails_Btn_Click(object sender, EventArgs e)
        {

            flowLayoutShowPanel.Visible= false;
           
            if (CurrentSimpleEmployeePanel != null)
            {
                for (int i = 0; i < Employee_List.Count; i++)
                {
                    if (CurrentSimpleEmployeePanel.Name == Employee_List[i][0])
                    {
                        EmployeeViewPage obj = new EmployeeViewPage(Employee_List[i][0], Employee_List[i][1], Employee_List[i][2], Employee_List[i][3], Employee_List[i][4], Employee_List[i][5], Employee_List[i][6]);
                        obj.Dock = DockStyle.Fill;
                       MainPanel.Controls.Add(obj);
                    }
                }

            }
            
        }

        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Contacs_Btn_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
