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
            panel2 = new Panel();
            panel1.SuspendLayout();
            mainpanel.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 44);
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
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(88, 44);
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
            button2.Location = new Point(1052, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(51, 44);
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
            mainpanel.Location = new Point(0, 44);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1103, 571);
            mainpanel.TabIndex = 2;
            // 
            // PanelForm
            // 
            PanelForm.Dock = DockStyle.Fill;
            PanelForm.Location = new Point(279, 0);
            PanelForm.Margin = new Padding(3, 2, 3, 2);
            PanelForm.Name = "PanelForm";
            PanelForm.Size = new Size(824, 571);
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
            sideBar.Margin = new Padding(3, 2, 3, 2);
            sideBar.Name = "sideBar";
            sideBar.RowCount = 10;
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            sideBar.RowStyles.Add(new RowStyle());
            sideBar.RowStyles.Add(new RowStyle());
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            sideBar.Size = new Size(279, 571);
            sideBar.TabIndex = 5;
            sideBar.SizeChanged += sideBar_SizeChanged;
            sideBar.Paint += sideBar_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 2);
            btnDashboard.Margin = new Padding(0, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(276, 52);
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
            btnUser.Location = new Point(0, 226);
            btnUser.Margin = new Padding(0, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.Size = new Size(276, 52);
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
            btnTicket.Location = new Point(0, 58);
            btnTicket.Margin = new Padding(0, 2, 3, 2);
            btnTicket.Name = "btnTicket";
            btnTicket.Padding = new Padding(10, 0, 0, 0);
            btnTicket.Size = new Size(276, 52);
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
            btnVehicle.Location = new Point(0, 170);
            btnVehicle.Margin = new Padding(0, 2, 3, 2);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(10, 0, 0, 0);
            btnVehicle.Size = new Size(276, 52);
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
            btnBagage.Location = new Point(0, 114);
            btnBagage.Margin = new Padding(0, 2, 3, 2);
            btnBagage.Name = "btnBagage";
            btnBagage.Padding = new Padding(10, 0, 0, 0);
            btnBagage.Size = new Size(276, 52);
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
            btnCus.Location = new Point(0, 282);
            btnCus.Margin = new Padding(0, 2, 3, 2);
            btnCus.Name = "btnCus";
            btnCus.Padding = new Padding(10, 0, 0, 0);
            btnCus.Size = new Size(276, 52);
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
            btnStaff.Location = new Point(0, 338);
            btnStaff.Margin = new Padding(0, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(10, 0, 0, 0);
            btnStaff.Size = new Size(276, 52);
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
            btnPayment.Location = new Point(0, 394);
            btnPayment.Margin = new Padding(0, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(10, 0, 0, 0);
            btnPayment.Size = new Size(276, 52);
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
            btnPayPackage.Location = new Point(0, 506);
            btnPayPackage.Margin = new Padding(0, 2, 3, 2);
            btnPayPackage.Name = "btnPayPackage";
            btnPayPackage.Padding = new Padding(10, 0, 0, 0);
            btnPayPackage.Size = new Size(276, 52);
            btnPayPackage.TabIndex = 14;
            btnPayPackage.Text = "Payment Package";
            btnPayPackage.UseVisualStyleBackColor = true;
            btnPayPackage.Click += button4_Click;
            // 
            // btnPayTicket
            // 
            btnPayTicket.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayTicket.Image = (Image)resources.GetObject("btnPayTicket.Image");
            btnPayTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayTicket.Location = new Point(0, 450);
            btnPayTicket.Margin = new Padding(0, 2, 3, 2);
            btnPayTicket.Name = "btnPayTicket";
            btnPayTicket.Padding = new Padding(10, 0, 0, 0);
            btnPayTicket.Size = new Size(276, 52);
            btnPayTicket.TabIndex = 12;
            btnPayTicket.Text = "Payment Ticket";
            btnPayTicket.UseVisualStyleBackColor = true;
            btnPayTicket.Click += button1_Click;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.Location = new Point(94, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 44);
            panel2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 615);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Panel panel2;
    }
}