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
            panel10 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            sidbar = new Panel();
            panel9 = new Panel();
            btnPayment = new Button();
            button13 = new Button();
            panel8 = new Panel();
            btnUser = new Button();
            button11 = new Button();
            panel7 = new Panel();
            btnStaff = new Button();
            button9 = new Button();
            panel6 = new Panel();
            btnVehicle = new Button();
            button7 = new Button();
            panel5 = new Panel();
            btnBagage = new Button();
            button5 = new Button();
            panel4 = new Panel();
            btnTicket = new Button();
            button4 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            btnDashboard = new Button();
            mainpanel = new Panel();
            sidbarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            sidbar.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 44);
            panel1.TabIndex = 0;
            // 
            // panel10
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
            button2.Size = new Size(78, 58);
            button2.TabIndex = 3;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
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
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(-4, -9);
            btnPayment.Margin = new Padding(0, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(10, 0, 0, 0);
            btnPayment.Size = new Size(237, 58);
            btnPayment.TabIndex = 4;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(-7, -10);
            button13.Margin = new Padding(0, 2, 3, 2);
            button13.Name = "button13";
            button13.Padding = new Padding(10, 0, 0, 0);
            button13.Size = new Size(237, 58);
            button13.TabIndex = 3;
            button13.Text = "Dashboard";
            button13.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnUser);
            panel8.Controls.Add(button11);
            panel8.Location = new Point(2, 224);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(229, 40);
            panel8.TabIndex = 6;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(-4, -9);
            btnUser.Margin = new Padding(0, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.Size = new Size(237, 58);
            btnUser.TabIndex = 4;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(-7, -10);
            button11.Margin = new Padding(0, 2, 3, 2);
            button11.Name = "button11";
            button11.Padding = new Padding(10, 0, 0, 0);
            button11.Size = new Size(237, 58);
            button11.TabIndex = 3;
            button11.Text = "Dashboard";
            button11.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnStaff);
            panel7.Controls.Add(button9);
            panel7.Location = new Point(3, 180);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(229, 40);
            panel7.TabIndex = 6;
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-4, -9);
            btnStaff.Margin = new Padding(0, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(10, 0, 0, 0);
            btnStaff.Size = new Size(237, 58);
            btnStaff.TabIndex = 4;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-7, -10);
            button9.Margin = new Padding(0, 2, 3, 2);
            button9.Name = "button9";
            button9.Padding = new Padding(10, 0, 0, 0);
            button9.Size = new Size(237, 58);
            button9.TabIndex = 3;
            button9.Text = "Dashboard";
            button9.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnVehicle);
            panel6.Controls.Add(button7);
            panel6.Location = new Point(2, 136);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(229, 40);
            panel6.TabIndex = 6;
            // 
            // btnVehicle
            // 
            btnVehicle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(-4, -9);
            btnVehicle.Margin = new Padding(0, 2, 3, 2);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(10, 0, 0, 0);
            btnVehicle.Size = new Size(237, 58);
            btnVehicle.TabIndex = 4;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-7, -10);
            button7.Margin = new Padding(0, 2, 3, 2);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(237, 58);
            button7.TabIndex = 3;
            button7.Text = "Dashboard";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBagage);
            panel5.Controls.Add(button5);
            panel5.Location = new Point(1, 92);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 40);
            panel5.TabIndex = 6;
            // 
            // btnBagage
            // 
            btnBagage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBagage.Image = (Image)resources.GetObject("btnBagage.Image");
            btnBagage.ImageAlign = ContentAlignment.MiddleLeft;
            btnBagage.Location = new Point(-4, -9);
            btnBagage.Margin = new Padding(0, 2, 3, 2);
            btnBagage.Name = "btnBagage";
            btnBagage.Padding = new Padding(10, 0, 0, 0);
            btnBagage.Size = new Size(237, 58);
            btnBagage.TabIndex = 4;
            btnBagage.Text = "Bagage";
            btnBagage.UseVisualStyleBackColor = true;
            btnBagage.Click += btnBagage_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-7, -10);
            button5.Margin = new Padding(0, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(237, 58);
            button5.TabIndex = 3;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTicket);
            panel4.Controls.Add(button4);
            panel4.Location = new Point(1, 46);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 40);
            panel4.TabIndex = 5;
            // 
            // btnTicket
            // 
            btnTicket.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTicket.Image = (Image)resources.GetObject("btnTicket.Image");
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(-4, -9);
            btnTicket.Margin = new Padding(0, 2, 3, 2);
            btnTicket.Name = "btnTicket";
            btnTicket.Padding = new Padding(10, 0, 0, 0);
            btnTicket.Size = new Size(237, 58);
            btnTicket.TabIndex = 4;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += button3_Click;
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
            // sidbarTransition
            // 
            sidbarTransition.Interval = 10;
            sidbarTransition.Tick += timer1_Tick;
            // 
            // mainpanel1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 460);
            Controls.Add(mainpanel);
            Controls.Add(sidbar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "mainpanel1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            sidbar.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel sidbar;
        private Panel panel3;
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
        private Button button9;
        private Panel panel6;
        private Button btnVehicle;
        private Button button7;
        private Panel panel5;
        private Button btnBagage;
        private Button button5;
        private Panel panel9;
        private Button btnPayment;
        private Button button13;
        private Panel panel10;
        private Button button3;
        private System.Windows.Forms.Timer sidbarTransition;
    }
}