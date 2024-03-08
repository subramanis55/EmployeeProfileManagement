namespace EcommerceManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.PictureBox Camera_Logo;
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuBottomPanel = new System.Windows.Forms.Panel();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.Setting_Button = new System.Windows.Forms.Button();
            this.CameraPanel = new System.Windows.Forms.Panel();
            this.Camera_Btn = new System.Windows.Forms.Button();
            this.SalesPanel = new System.Windows.Forms.Panel();
            this.Sales_Btn = new System.Windows.Forms.Button();
            this.SalesLogo = new System.Windows.Forms.PictureBox();
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.Products_Btn = new System.Windows.Forms.Button();
            this.Products_Logo = new System.Windows.Forms.PictureBox();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.Contacts_Btn = new System.Windows.Forms.Button();
            this.ContactsLogo = new System.Windows.Forms.PictureBox();
            this.MenuTopPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CompanyLogo = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DrawLogo = new System.Windows.Forms.PictureBox();
            this.Contacs_Btn_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.Button();
            this.AddPeople = new System.Windows.Forms.Button();
            this.ViewDetails = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.flowLayoutShowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleEmployeePanel1 = new EcommerceManagement.SimpleEmployeePanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Camera_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Camera_Logo)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.MenuBottomPanel.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.CameraPanel.SuspendLayout();
            this.SalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogo)).BeginInit();
            this.ProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Logo)).BeginInit();
            this.ContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsLogo)).BeginInit();
            this.MenuTopPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLogo)).BeginInit();
            this.Contacs_Btn_Panel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.flowLayoutShowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new System.Drawing.Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(62, 40);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Camera_Logo
            // 
            Camera_Logo.BackColor = System.Drawing.Color.Transparent;
            Camera_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Camera_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            Camera_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Camera_Logo.ErrorImage")));
            Camera_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Camera_Logo.Image")));
            Camera_Logo.ImageLocation = "";
            Camera_Logo.Location = new System.Drawing.Point(10, 10);
            Camera_Logo.Name = "Camera_Logo";
            Camera_Logo.Size = new System.Drawing.Size(62, 40);
            Camera_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Camera_Logo.TabIndex = 0;
            Camera_Logo.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MenuPanel.Controls.Add(this.MenuBottomPanel);
            this.MenuPanel.Controls.Add(this.MenuTopPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(244, 730);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Visible = false;
            this.MenuPanel.Resize += new System.EventHandler(this.MenuPanel_Resize);
            // 
            // MenuBottomPanel
            // 
            this.MenuBottomPanel.AutoSize = true;
            this.MenuBottomPanel.Controls.Add(this.SettingPanel);
            this.MenuBottomPanel.Controls.Add(this.CameraPanel);
            this.MenuBottomPanel.Controls.Add(this.SalesPanel);
            this.MenuBottomPanel.Controls.Add(this.ProductsPanel);
            this.MenuBottomPanel.Controls.Add(this.ContactPanel);
            this.MenuBottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuBottomPanel.Location = new System.Drawing.Point(0, 194);
            this.MenuBottomPanel.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.MenuBottomPanel.Name = "MenuBottomPanel";
            this.MenuBottomPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MenuBottomPanel.Size = new System.Drawing.Size(244, 536);
            this.MenuBottomPanel.TabIndex = 1;
            this.MenuBottomPanel.Resize += new System.EventHandler(this.BottomPanel_Resize);
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.Setting_Button);
            this.SettingPanel.Controls.Add(pictureBox1);
            this.SettingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingPanel.Location = new System.Drawing.Point(10, 234);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.SettingPanel.Size = new System.Drawing.Size(234, 60);
            this.SettingPanel.TabIndex = 4;
            // 
            // Setting_Button
            // 
            this.Setting_Button.BackColor = System.Drawing.Color.Transparent;
            this.Setting_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_Button.FlatAppearance.BorderSize = 0;
            this.Setting_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_Button.ForeColor = System.Drawing.Color.White;
            this.Setting_Button.Location = new System.Drawing.Point(72, 10);
            this.Setting_Button.Name = "Setting_Button";
            this.Setting_Button.Size = new System.Drawing.Size(152, 40);
            this.Setting_Button.TabIndex = 1;
            this.Setting_Button.Text = "Setting";
            this.Setting_Button.UseVisualStyleBackColor = false;
            this.Setting_Button.Click += new System.EventHandler(this.Setting_Btn_Click);
            // 
            // CameraPanel
            // 
            this.CameraPanel.Controls.Add(this.Camera_Btn);
            this.CameraPanel.Controls.Add(Camera_Logo);
            this.CameraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CameraPanel.Location = new System.Drawing.Point(10, 174);
            this.CameraPanel.Name = "CameraPanel";
            this.CameraPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.CameraPanel.Size = new System.Drawing.Size(234, 60);
            this.CameraPanel.TabIndex = 3;
            // 
            // Camera_Btn
            // 
            this.Camera_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Camera_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera_Btn.FlatAppearance.BorderSize = 0;
            this.Camera_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Camera_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_Btn.ForeColor = System.Drawing.Color.White;
            this.Camera_Btn.Location = new System.Drawing.Point(72, 10);
            this.Camera_Btn.Name = "Camera_Btn";
            this.Camera_Btn.Size = new System.Drawing.Size(152, 40);
            this.Camera_Btn.TabIndex = 1;
            this.Camera_Btn.Text = "Camera";
            this.Camera_Btn.UseVisualStyleBackColor = false;
            this.Camera_Btn.Click += new System.EventHandler(this.Camera_Btn_Click);
            // 
            // SalesPanel
            // 
            this.SalesPanel.Controls.Add(this.Sales_Btn);
            this.SalesPanel.Controls.Add(this.SalesLogo);
            this.SalesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesPanel.Location = new System.Drawing.Point(10, 114);
            this.SalesPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.SalesPanel.Size = new System.Drawing.Size(234, 60);
            this.SalesPanel.TabIndex = 2;
            // 
            // Sales_Btn
            // 
            this.Sales_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Sales_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sales_Btn.FlatAppearance.BorderSize = 0;
            this.Sales_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_Btn.ForeColor = System.Drawing.Color.White;
            this.Sales_Btn.Location = new System.Drawing.Point(72, 10);
            this.Sales_Btn.Name = "Sales_Btn";
            this.Sales_Btn.Size = new System.Drawing.Size(152, 40);
            this.Sales_Btn.TabIndex = 1;
            this.Sales_Btn.Text = "Sales";
            this.Sales_Btn.UseVisualStyleBackColor = false;
            this.Sales_Btn.Click += new System.EventHandler(this.Sales_Btn_Click);
            // 
            // SalesLogo
            // 
            this.SalesLogo.BackColor = System.Drawing.Color.Transparent;
            this.SalesLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SalesLogo.Image = ((System.Drawing.Image)(resources.GetObject("SalesLogo.Image")));
            this.SalesLogo.Location = new System.Drawing.Point(10, 10);
            this.SalesLogo.Name = "SalesLogo";
            this.SalesLogo.Size = new System.Drawing.Size(62, 40);
            this.SalesLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalesLogo.TabIndex = 0;
            this.SalesLogo.TabStop = false;
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.Controls.Add(this.Products_Btn);
            this.ProductsPanel.Controls.Add(this.Products_Logo);
            this.ProductsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsPanel.Location = new System.Drawing.Point(10, 54);
            this.ProductsPanel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ProductsPanel.Size = new System.Drawing.Size(234, 60);
            this.ProductsPanel.TabIndex = 2;
            // 
            // Products_Btn
            // 
            this.Products_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Products_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Products_Btn.FlatAppearance.BorderSize = 0;
            this.Products_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_Btn.ForeColor = System.Drawing.Color.White;
            this.Products_Btn.Location = new System.Drawing.Point(72, 10);
            this.Products_Btn.Name = "Products_Btn";
            this.Products_Btn.Size = new System.Drawing.Size(152, 40);
            this.Products_Btn.TabIndex = 1;
            this.Products_Btn.Text = "Products";
            this.Products_Btn.UseVisualStyleBackColor = false;
            this.Products_Btn.Click += new System.EventHandler(this.Products_Btn_Click);
            // 
            // Products_Logo
            // 
            this.Products_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Products_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Products_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Products_Logo.Image")));
            this.Products_Logo.Location = new System.Drawing.Point(10, 10);
            this.Products_Logo.Name = "Products_Logo";
            this.Products_Logo.Size = new System.Drawing.Size(62, 40);
            this.Products_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Products_Logo.TabIndex = 0;
            this.Products_Logo.TabStop = false;
            // 
            // ContactPanel
            // 
            this.ContactPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ContactPanel.Controls.Add(this.Contacts_Btn);
            this.ContactPanel.Controls.Add(this.ContactsLogo);
            this.ContactPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactPanel.Location = new System.Drawing.Point(10, 0);
            this.ContactPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ContactPanel.Size = new System.Drawing.Size(234, 54);
            this.ContactPanel.TabIndex = 1;
            // 
            // Contacts_Btn
            // 
            this.Contacts_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Contacts_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contacts_Btn.FlatAppearance.BorderSize = 0;
            this.Contacts_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contacts_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacts_Btn.ForeColor = System.Drawing.Color.White;
            this.Contacts_Btn.Location = new System.Drawing.Point(72, 10);
            this.Contacts_Btn.Name = "Contacts_Btn";
            this.Contacts_Btn.Size = new System.Drawing.Size(152, 34);
            this.Contacts_Btn.TabIndex = 1;
            this.Contacts_Btn.Text = "Contacts";
            this.Contacts_Btn.UseVisualStyleBackColor = false;
            this.Contacts_Btn.Click += new System.EventHandler(this.Contacts_Btn_Click);
            // 
            // ContactsLogo
            // 
            this.ContactsLogo.BackColor = System.Drawing.Color.Transparent;
            this.ContactsLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContactsLogo.Image = ((System.Drawing.Image)(resources.GetObject("ContactsLogo.Image")));
            this.ContactsLogo.Location = new System.Drawing.Point(10, 10);
            this.ContactsLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ContactsLogo.Name = "ContactsLogo";
            this.ContactsLogo.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ContactsLogo.Size = new System.Drawing.Size(62, 34);
            this.ContactsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContactsLogo.TabIndex = 0;
            this.ContactsLogo.TabStop = false;
            // 
            // MenuTopPanel
            // 
            this.MenuTopPanel.Controls.Add(this.panel3);
            this.MenuTopPanel.Controls.Add(this.CompanyLogo);
            this.MenuTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuTopPanel.Name = "MenuTopPanel";
            this.MenuTopPanel.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.MenuTopPanel.Size = new System.Drawing.Size(244, 194);
            this.MenuTopPanel.TabIndex = 1;
            this.MenuTopPanel.Resize += new System.EventHandler(this.MenuTopPanel_Resize);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.SearchBox);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 136);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel3.Size = new System.Drawing.Size(214, 48);
            this.panel3.TabIndex = 1;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchBox.Location = new System.Drawing.Point(51, 7);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(156, 34);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = "    Search";
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::EcommerceManagement.Properties.Resources.download__1_;
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.BackColor = System.Drawing.Color.White;
            this.CompanyLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompanyLogo.Location = new System.Drawing.Point(20, 10);
            this.CompanyLogo.Name = "CompanyLogo";
            this.CompanyLogo.Size = new System.Drawing.Size(214, 74);
            this.CompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyLogo.TabIndex = 1;
            this.CompanyLogo.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TopPanel.Controls.Add(this.DrawLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(244, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(983, 99);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.Resize += new System.EventHandler(this.TopPanel_Resize);
            // 
            // DrawLogo
            // 
            this.DrawLogo.Image = ((System.Drawing.Image)(resources.GetObject("DrawLogo.Image")));
            this.DrawLogo.Location = new System.Drawing.Point(37, 32);
            this.DrawLogo.Name = "DrawLogo";
            this.DrawLogo.Size = new System.Drawing.Size(36, 34);
            this.DrawLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DrawLogo.TabIndex = 1;
            this.DrawLogo.TabStop = false;
            this.DrawLogo.Click += new System.EventHandler(this.MenuLogo_Click);
            // 
            // Contacs_Btn_Panel
            // 
            this.Contacs_Btn_Panel.BackColor = System.Drawing.Color.White;
            this.Contacs_Btn_Panel.Controls.Add(this.panel2);
            this.Contacs_Btn_Panel.Controls.Add(this.Remove);
            this.Contacs_Btn_Panel.Controls.Add(this.AddPeople);
            this.Contacs_Btn_Panel.Controls.Add(this.ViewDetails);
            this.Contacs_Btn_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Contacs_Btn_Panel.Location = new System.Drawing.Point(244, 99);
            this.Contacs_Btn_Panel.Name = "Contacs_Btn_Panel";
            this.Contacs_Btn_Panel.Size = new System.Drawing.Size(983, 136);
            this.Contacs_Btn_Panel.TabIndex = 0;
            this.Contacs_Btn_Panel.Visible = false;
            this.Contacs_Btn_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Contacs_Btn_Panel_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 136);
            this.panel2.TabIndex = 3;
            // 
            // Remove
            // 
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.Black;
            this.Remove.Location = new System.Drawing.Point(624, 48);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(149, 53);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // AddPeople
            // 
            this.AddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPeople.ForeColor = System.Drawing.Color.Black;
            this.AddPeople.Location = new System.Drawing.Point(802, 48);
            this.AddPeople.Name = "AddPeople";
            this.AddPeople.Size = new System.Drawing.Size(149, 53);
            this.AddPeople.TabIndex = 0;
            this.AddPeople.Text = "AddPeople";
            this.AddPeople.UseVisualStyleBackColor = true;
            this.AddPeople.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // ViewDetails
            // 
            this.ViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetails.ForeColor = System.Drawing.Color.Black;
            this.ViewDetails.Location = new System.Drawing.Point(458, 48);
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(149, 53);
            this.ViewDetails.TabIndex = 2;
            this.ViewDetails.Text = "ViewDetails";
            this.ViewDetails.UseVisualStyleBackColor = true;
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Btn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.flowLayoutShowPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(244, 235);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.MainPanel.Size = new System.Drawing.Size(983, 617);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // flowLayoutShowPanel
            // 
            this.flowLayoutShowPanel.AutoScroll = true;
            this.flowLayoutShowPanel.AutoSize = true;
            this.flowLayoutShowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutShowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutShowPanel.Controls.Add(this.simpleEmployeePanel1);
            this.flowLayoutShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutShowPanel.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutShowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutShowPanel.Name = "flowLayoutShowPanel";
            this.flowLayoutShowPanel.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutShowPanel.Size = new System.Drawing.Size(943, 577);
            this.flowLayoutShowPanel.TabIndex = 0;
            this.flowLayoutShowPanel.Visible = false;
            // 
            // simpleEmployeePanel1
            // 
            this.simpleEmployeePanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.simpleEmployeePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleEmployeePanel1.Location = new System.Drawing.Point(9, 9);
            this.simpleEmployeePanel1.Name = "simpleEmployeePanel1";
            this.simpleEmployeePanel1.Padding = new System.Windows.Forms.Padding(60, 10, 50, 10);
            this.simpleEmployeePanel1.Size = new System.Drawing.Size(825, 94);
            this.simpleEmployeePanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 730);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Contacs_Btn_Panel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Camera_Logo)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.MenuBottomPanel.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.CameraPanel.ResumeLayout(false);
            this.SalesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogo)).EndInit();
            this.ProductsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Products_Logo)).EndInit();
            this.ContactPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsLogo)).EndInit();
            this.MenuTopPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawLogo)).EndInit();
            this.Contacs_Btn_Panel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.flowLayoutShowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox CompanyLogo;
        private System.Windows.Forms.Panel MenuBottomPanel;
        private System.Windows.Forms.Panel ContactPanel;
        private System.Windows.Forms.Button Contacts_Btn;
        private System.Windows.Forms.PictureBox ContactsLogo;
        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.Button Products_Btn;
        private System.Windows.Forms.PictureBox Products_Logo;
        private System.Windows.Forms.Panel CameraPanel;
        private System.Windows.Forms.Button Camera_Btn;
        private System.Windows.Forms.Panel SalesPanel;
        private System.Windows.Forms.Button Sales_Btn;
        private System.Windows.Forms.PictureBox SalesLogo;
        private System.Windows.Forms.Panel MenuTopPanel;
        private System.Windows.Forms.PictureBox DrawLogo;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Button Setting_Button;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Contacs_Btn_Panel;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button AddPeople;
        private System.Windows.Forms.Button ViewDetails;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutShowPanel;
        private SimpleEmployeePanel simpleEmployeePanel1;
    }
}

