namespace PABMS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel2 = new Panel();
            labelUsername = new Label();
            btnMenu = new Button();
            btnExit = new Button();
            mainpanel = new Panel();
            PanelForm = new Panel();
            sideBar = new TableLayoutPanel();
            btnDashboard = new Button();
            btnUser = new Button();
            btnTicket = new Button();
            btnStaff = new Button();
            btnPackage = new Button();
            btnCustomer = new Button();
            btnBus = new Button();
            btnTruck = new Button();
            btnPayPackage = new Button();
            btnPayTicket = new Button();
            sideBarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mainpanel.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 59);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(labelUsername);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(95, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1108, 59);
            panel2.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.ForeColor = SystemColors.ButtonHighlight;
            labelUsername.Location = new Point(796, 16);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(214, 29);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Login as : example";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.ForestGreen;
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Red;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(95, 59);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.ForestGreen;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1203, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(58, 59);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(PanelForm);
            mainpanel.Controls.Add(sideBar);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 59);
            mainpanel.Margin = new Padding(3, 4, 3, 4);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1261, 761);
            mainpanel.TabIndex = 2;
            // 
            // PanelForm
            // 
            PanelForm.Dock = DockStyle.Fill;
            PanelForm.Location = new Point(319, 0);
            PanelForm.Name = "PanelForm";
            PanelForm.Size = new Size(942, 761);
            PanelForm.TabIndex = 6;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.ForestGreen;
            sideBar.ColumnCount = 1;
            sideBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideBar.Controls.Add(btnDashboard, 0, 0);
            sideBar.Controls.Add(btnUser, 0, 4);
            sideBar.Controls.Add(btnTicket, 0, 1);
            sideBar.Controls.Add(btnStaff, 0, 3);
            sideBar.Controls.Add(btnPackage, 0, 2);
            sideBar.Controls.Add(btnCustomer, 0, 5);
            sideBar.Controls.Add(btnBus, 0, 6);
            sideBar.Controls.Add(btnTruck, 0, 7);
            sideBar.Controls.Add(btnPayPackage, 0, 9);
            sideBar.Controls.Add(btnPayTicket, 0, 8);
            sideBar.Dock = DockStyle.Left;
            sideBar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.RowCount = 10;
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle());
            sideBar.RowStyles.Add(new RowStyle());
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sideBar.Size = new Size(319, 761);
            sideBar.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 3);
            btnDashboard.Margin = new Padding(0, 3, 3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(315, 69);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 303);
            btnUser.Margin = new Padding(0, 3, 3, 3);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(11, 0, 0, 0);
            btnUser.Size = new Size(315, 69);
            btnUser.TabIndex = 9;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnTicket
            // 
            btnTicket.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTicket.Image = (Image)resources.GetObject("btnTicket.Image");
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(0, 78);
            btnTicket.Margin = new Padding(0, 3, 3, 3);
            btnTicket.Name = "btnTicket";
            btnTicket.Padding = new Padding(11, 0, 0, 0);
            btnTicket.Size = new Size(315, 69);
            btnTicket.TabIndex = 11;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(0, 228);
            btnStaff.Margin = new Padding(0, 3, 3, 3);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(11, 0, 0, 0);
            btnStaff.Size = new Size(315, 69);
            btnStaff.TabIndex = 10;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnPackage
            // 
            btnPackage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPackage.Image = (Image)resources.GetObject("btnPackage.Image");
            btnPackage.ImageAlign = ContentAlignment.MiddleLeft;
            btnPackage.Location = new Point(0, 153);
            btnPackage.Margin = new Padding(0, 3, 3, 3);
            btnPackage.Name = "btnPackage";
            btnPackage.Padding = new Padding(11, 0, 0, 0);
            btnPackage.Size = new Size(315, 69);
            btnPackage.TabIndex = 8;
            btnPackage.Text = "Package";
            btnPackage.UseVisualStyleBackColor = true;
            btnPackage.Click += btnPackage_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 378);
            btnCustomer.Margin = new Padding(0, 3, 3, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(11, 0, 0, 0);
            btnCustomer.Size = new Size(315, 69);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnBus
            // 
            btnBus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBus.Image = (Image)resources.GetObject("btnBus.Image");
            btnBus.ImageAlign = ContentAlignment.MiddleLeft;
            btnBus.Location = new Point(0, 453);
            btnBus.Margin = new Padding(0, 3, 3, 3);
            btnBus.Name = "btnBus";
            btnBus.Padding = new Padding(11, 0, 0, 0);
            btnBus.Size = new Size(315, 69);
            btnBus.TabIndex = 7;
            btnBus.Text = "Bus";
            btnBus.UseVisualStyleBackColor = true;
            btnBus.Click += btnBus_Click;
            // 
            // btnTruck
            // 
            btnTruck.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTruck.Image = (Image)resources.GetObject("btnTruck.Image");
            btnTruck.ImageAlign = ContentAlignment.MiddleLeft;
            btnTruck.Location = new Point(0, 528);
            btnTruck.Margin = new Padding(0, 3, 3, 3);
            btnTruck.Name = "btnTruck";
            btnTruck.Padding = new Padding(11, 0, 0, 0);
            btnTruck.Size = new Size(315, 69);
            btnTruck.TabIndex = 5;
            btnTruck.Text = "Truck";
            btnTruck.UseVisualStyleBackColor = true;
            btnTruck.Click += btnTruck_Click;
            // 
            // btnPayPackage
            // 
            btnPayPackage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayPackage.Image = (Image)resources.GetObject("btnPayPackage.Image");
            btnPayPackage.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayPackage.Location = new Point(0, 678);
            btnPayPackage.Margin = new Padding(0, 3, 3, 3);
            btnPayPackage.Name = "btnPayPackage";
            btnPayPackage.Padding = new Padding(11, 0, 0, 0);
            btnPayPackage.Size = new Size(315, 69);
            btnPayPackage.TabIndex = 14;
            btnPayPackage.Text = "Payment Package";
            btnPayPackage.UseVisualStyleBackColor = true;
            btnPayPackage.Click += btnPayPackage_Click;
            // 
            // btnPayTicket
            // 
            btnPayTicket.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayTicket.Image = (Image)resources.GetObject("btnPayTicket.Image");
            btnPayTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayTicket.Location = new Point(0, 603);
            btnPayTicket.Margin = new Padding(0, 3, 3, 3);
            btnPayTicket.Name = "btnPayTicket";
            btnPayTicket.Padding = new Padding(11, 0, 0, 0);
            btnPayTicket.Size = new Size(315, 69);
            btnPayTicket.TabIndex = 12;
            btnPayTicket.Text = "Payment Ticket";
            btnPayTicket.UseVisualStyleBackColor = true;
            btnPayTicket.Click += btnPayTicket_Click;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 820);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mainpanel.ResumeLayout(false);
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel mainpanel;
        private System.Windows.Forms.Timer sideBarTransition;
        private TableLayoutPanel sideBar;
        private Panel PanelForm;
        private Button btnMenu;
        private Button btnExit;
        private Button btnDashboard;
        private Button btnBus;
        private Button btnUser;
        private Button btnPackage;
        private Button btnStaff;
        private Button btnTicket;
        private Button btnTruck;
        private Button btnPayTicket;
        private Button btnPayPackage;
        private Button btnCustomer;
        private Panel panel2;
        private Label labelUsername;
    }
}