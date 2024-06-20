namespace PABMS
{
    partial class mainpanel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainpanel1));
            panel1 = new Panel();
            btnMenu = new Button();
            button2 = new Button();
            mainpanel = new Panel();
            PanelForm = new Panel();
            sideBar = new TableLayoutPanel();
            btnDashboard = new Button();
            btnStaff = new Button();
            btnUser = new Button();
            btnBagage = new Button();
            btnVehicle = new Button();
            btnTicket = new Button();
            button4 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            btnDashboard = new Button();
            mainpanel = new Panel();
            sidbarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            mainpanel.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 44);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            panel10.Controls.Add(button3);
            panel10.Location = new Point(6, 7);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(45, 31);
            panel10.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(-3, -1);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(49, 34);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(975, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(53, 40);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(-11, -10);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(58, 59);
            button2.TabIndex = 3;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sidbar
            // 
            sidbar.BackColor = Color.FromArgb(224, 224, 224);
            sidbar.Controls.Add(panel9);
            sidbar.Controls.Add(panel8);
            sidbar.Controls.Add(panel7);
            sidbar.Controls.Add(panel6);
            sidbar.Controls.Add(panel5);
            sidbar.Controls.Add(panel4);
            sidbar.Controls.Add(panel3);
            sidbar.Dock = DockStyle.Left;
            sidbar.Location = new Point(0, 44);
            sidbar.Margin = new Padding(3, 2, 3, 2);
            sidbar.Name = "sidbar";
            sidbar.Size = new Size(233, 416);
            sidbar.TabIndex = 1;
            sidbar.Paint += panel_Paint;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnPayment);
            panel9.Controls.Add(button13);
            panel9.Location = new Point(2, 268);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(229, 40);
            panel9.TabIndex = 6;
            // 
            // PanelForm
            // 
            PanelForm.Dock = DockStyle.Fill;
            PanelForm.Location = new Point(234, 0);
            PanelForm.Name = "PanelForm";
            PanelForm.Size = new Size(945, 554);
            PanelForm.TabIndex = 6;
            PanelForm.SizeChanged += PanelForm_SizeChanged;
            // 
            // sideBar
            // 
            sideBar.ColumnCount = 1;
            sideBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sideBar.Controls.Add(btnDashboard, 0, 0);
            sideBar.Controls.Add(btnStaff, 0, 5);
            sideBar.Controls.Add(btnUser, 0, 4);
            sideBar.Controls.Add(btnBagage, 0, 1);
            sideBar.Controls.Add(btnVehicle, 0, 2);
            sideBar.Controls.Add(btnTicket, 0, 3);
            sideBar.Controls.Add(btnPayment, 0, 6);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.RowCount = 7;
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            sideBar.Size = new Size(234, 554);
            sideBar.TabIndex = 5;
            sideBar.SizeChanged += sideBar_SizeChanged;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 3);
            btnDashboard.Margin = new Padding(0, 3, 3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(231, 69);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(0, 378);
            btnStaff.Margin = new Padding(0, 3, 3, 3);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(11, 0, 0, 0);
            btnStaff.Size = new Size(231, 69);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 303);
            btnUser.Margin = new Padding(0, 3, 3, 3);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(11, 0, 0, 0);
            btnUser.Size = new Size(231, 69);
            btnUser.TabIndex = 9;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnBagage
            // 
            btnBagage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBagage.Image = (Image)resources.GetObject("btnBagage.Image");
            btnBagage.ImageAlign = ContentAlignment.MiddleLeft;
            btnBagage.Location = new Point(0, 78);
            btnBagage.Margin = new Padding(0, 3, 3, 3);
            btnBagage.Name = "btnBagage";
            btnBagage.Padding = new Padding(11, 0, 0, 0);
            btnBagage.Size = new Size(231, 69);
            btnBagage.TabIndex = 8;
            btnBagage.Text = "Bagage";
            btnBagage.UseVisualStyleBackColor = true;
            btnBagage.Click += btnBagage_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(0, 153);
            btnVehicle.Margin = new Padding(0, 3, 3, 3);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(11, 0, 0, 0);
            btnVehicle.Size = new Size(231, 69);
            btnVehicle.TabIndex = 10;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // btnTicket
            // 
            btnTicket.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTicket.Image = (Image)resources.GetObject("btnTicket.Image");
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(0, 228);
            btnTicket.Margin = new Padding(0, 3, 3, 3);
            btnTicket.Name = "btnTicket";
            btnTicket.Padding = new Padding(11, 0, 0, 0);
            btnTicket.Size = new Size(231, 69);
            btnTicket.TabIndex = 11;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-7, -10);
            button4.Margin = new Padding(0, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(237, 58);
            button4.TabIndex = 3;
            button4.Text = "Dashboard";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnDashboard);
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 40);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-4, -9);
            button1.Margin = new Padding(0, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(237, 58);
            button1.TabIndex = 4;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-7, -10);
            btnDashboard.Margin = new Padding(0, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(237, 58);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Right;
            mainpanel.Location = new Point(232, 44);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(800, 416);
            mainpanel.TabIndex = 2;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // sideBarTransition
            // 
            sidbarTransition.Interval = 10;
            sidbarTransition.Tick += timer1_Tick;
            // 
            // mainpanel1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 460);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "mainpanel1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Panel panel2;
        private Button button2;
        private Panel mainpanel;
        private Button button1;
        private Panel panel4;
        private Button btnTicket;
        private Button button4;
        private Panel panel8;
        private Button btnUser;
        private Button button11;
        private Panel panel7;
        private Button btnStaff;
        private Button btnUser;
        private Button btnBagage;
        private Button btnVehicle;
        private Button btnTicket;
        private Button btnPayment;
        private Button button13;
        private Panel panel10;
        private Button button3;
        private System.Windows.Forms.Timer sidbarTransition;
    }
}