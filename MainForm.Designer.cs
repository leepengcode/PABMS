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
            btnMenu = new Button();
            button2 = new Button();
            mainpanel = new Panel();
            PanelForm = new Panel();
            sideBar = new TableLayoutPanel();
            btnDashboard = new Button();
            btnUser = new Button();
            btnTicket = new Button();
            btnVehicle = new Button();
            btnBagage = new Button();
            btnCus = new Button();
            btnStaff = new Button();
            btnPayment = new Button();
            btnPayPackage = new Button();
            btnPayTicket = new Button();
            sideBarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            mainpanel.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 59);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Red;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(101, 59);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1203, 0);
            button2.Name = "button2";
            button2.Size = new Size(58, 59);
            button2.TabIndex = 3;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            PanelForm.SizeChanged += PanelForm_SizeChanged;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.CornflowerBlue;
            sideBar.ColumnCount = 1;
            sideBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideBar.Controls.Add(btnDashboard, 0, 0);
            sideBar.Controls.Add(btnUser, 0, 4);
            sideBar.Controls.Add(btnTicket, 0, 1);
            sideBar.Controls.Add(btnVehicle, 0, 3);
            sideBar.Controls.Add(btnBagage, 0, 2);
            sideBar.Controls.Add(btnCus, 0, 5);
            sideBar.Controls.Add(btnStaff, 0, 6);
            sideBar.Controls.Add(btnPayment, 0, 7);
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
            sideBar.SizeChanged += sideBar_SizeChanged;
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
            btnDashboard.Size = new Size(316, 69);
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
            btnUser.Size = new Size(316, 69);
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
            btnTicket.Size = new Size(316, 69);
            btnTicket.TabIndex = 11;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(0, 228);
            btnVehicle.Margin = new Padding(0, 3, 3, 3);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(11, 0, 0, 0);
            btnVehicle.Size = new Size(316, 69);
            btnVehicle.TabIndex = 10;
            btnVehicle.Text = "Staff";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // btnBagage
            // 
            btnBagage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBagage.Image = (Image)resources.GetObject("btnBagage.Image");
            btnBagage.ImageAlign = ContentAlignment.MiddleLeft;
            btnBagage.Location = new Point(0, 153);
            btnBagage.Margin = new Padding(0, 3, 3, 3);
            btnBagage.Name = "btnBagage";
            btnBagage.Padding = new Padding(11, 0, 0, 0);
            btnBagage.Size = new Size(316, 69);
            btnBagage.TabIndex = 8;
            btnBagage.Text = "Package";
            btnBagage.UseVisualStyleBackColor = true;
            btnBagage.Click += btnBagage_Click;
            // 
            // btnCus
            // 
            btnCus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCus.Image = (Image)resources.GetObject("btnCus.Image");
            btnCus.ImageAlign = ContentAlignment.MiddleLeft;
            btnCus.Location = new Point(0, 378);
            btnCus.Margin = new Padding(0, 3, 3, 3);
            btnCus.Name = "btnCus";
            btnCus.Padding = new Padding(11, 0, 0, 0);
            btnCus.Size = new Size(316, 69);
            btnCus.TabIndex = 14;
            btnCus.Text = "Customer";
            btnCus.UseVisualStyleBackColor = true;
            btnCus.Click += button3_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(0, 453);
            btnStaff.Margin = new Padding(0, 3, 3, 3);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(11, 0, 0, 0);
            btnStaff.Size = new Size(316, 69);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Bus";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(0, 528);
            btnPayment.Margin = new Padding(0, 3, 3, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(11, 0, 0, 0);
            btnPayment.Size = new Size(316, 69);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "Truck";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
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
            btnPayPackage.Size = new Size(316, 69);
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
            btnPayTicket.Size = new Size(316, 69);
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
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            SizeChanged += MainPanel_SizeChanged;
            panel1.ResumeLayout(false);
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
        private Button button2;
        private Button btnDashboard;
        private Button btnStaff;
        private Button btnUser;
        private Button btnBagage;
        private Button btnVehicle;
        private Button btnTicket;
        private Button btnPayment;
        private Button btnPayTicket;
        private Button btnPayPackage;
        private Button btnCus;
    }
}