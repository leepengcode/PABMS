namespace PABMS
{
    partial class TicketForm
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
            panel1 = new Panel();
            cmCusID = new ComboBox();
            CusPhone = new TextBox();
            label5 = new Label();
            CusName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            StaffName = new TextBox();
            cmStaffID = new ComboBox();
            textBox10 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox9 = new TextBox();
            panel3 = new Panel();
            BusN0 = new TextBox();
            cmBusID = new ComboBox();
            BusPrice = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtID = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtDestination = new TextBox();
            label15 = new Label();
            txtOrigin = new TextBox();
            label16 = new Label();
            txtSearch = new TextBox();
            btnSave = new Button();
            btnSearch = new Button();
            button3 = new Button();
            button4 = new Button();
            label14 = new Label();
            dtpDeparture = new DateTimePicker();
            dtpPurchas = new DateTimePicker();
            DataTicket = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTicket).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmCusID);
            panel1.Controls.Add(CusPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CusName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(163, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 202);
            panel1.TabIndex = 0;
            // 
            // cmCusID
            // 
            cmCusID.FormattingEnabled = true;
            cmCusID.Location = new Point(161, 29);
            cmCusID.Name = "cmCusID";
            cmCusID.Size = new Size(178, 28);
            cmCusID.TabIndex = 31;
            cmCusID.SelectedIndexChanged += cmCusID_SelectedIndexChanged;
            // 
            // CusPhone
            // 
            CusPhone.BorderStyle = BorderStyle.FixedSingle;
            CusPhone.Location = new Point(161, 125);
            CusPhone.Multiline = true;
            CusPhone.Name = "CusPhone";
            CusPhone.ReadOnly = true;
            CusPhone.Size = new Size(178, 34);
            CusPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 139);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // CusName
            // 
            CusName.BorderStyle = BorderStyle.FixedSingle;
            CusName.Location = new Point(161, 71);
            CusName.Multiline = true;
            CusName.Name = "CusName";
            CusName.ReadOnly = true;
            CusName.Size = new Size(178, 34);
            CusName.TabIndex = 3;
            CusName.TextChanged += CusName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 37);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(StaffName);
            panel2.Controls.Add(cmStaffID);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox9);
            panel2.Location = new Point(586, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 202);
            panel2.TabIndex = 1;
            // 
            // StaffName
            // 
            StaffName.BorderStyle = BorderStyle.FixedSingle;
            StaffName.Location = new Point(142, 72);
            StaffName.Multiline = true;
            StaffName.Name = "StaffName";
            StaffName.ReadOnly = true;
            StaffName.Size = new Size(178, 34);
            StaffName.TabIndex = 30;
            // 
            // cmStaffID
            // 
            cmStaffID.FormattingEnabled = true;
            cmStaffID.Location = new Point(142, 29);
            cmStaffID.Name = "cmStaffID";
            cmStaffID.Size = new Size(178, 28);
            cmStaffID.TabIndex = 30;
            cmStaffID.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(-262, 144);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(178, 34);
            textBox10.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 86);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 6;
            label6.Text = "Staff Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 37);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 4;
            label7.Text = "Staff ID";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(-262, 63);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(178, 34);
            textBox9.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(BusN0);
            panel3.Controls.Add(cmBusID);
            panel3.Controls.Add(BusPrice);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(1014, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 202);
            panel3.TabIndex = 1;
            // 
            // BusN0
            // 
            BusN0.BorderStyle = BorderStyle.FixedSingle;
            BusN0.Location = new Point(151, 72);
            BusN0.Multiline = true;
            BusN0.Name = "BusN0";
            BusN0.ReadOnly = true;
            BusN0.Size = new Size(178, 34);
            BusN0.TabIndex = 29;
            // 
            // cmBusID
            // 
            cmBusID.FormattingEnabled = true;
            cmBusID.Location = new Point(151, 29);
            cmBusID.Name = "cmBusID";
            cmBusID.Size = new Size(178, 28);
            cmBusID.TabIndex = 28;
            cmBusID.SelectedIndexChanged += cmBusID_SelectedIndexChanged;
            // 
            // BusPrice
            // 
            BusPrice.BorderStyle = BorderStyle.FixedSingle;
            BusPrice.Location = new Point(151, 126);
            BusPrice.Multiline = true;
            BusPrice.Name = "BusPrice";
            BusPrice.ReadOnly = true;
            BusPrice.Size = new Size(178, 34);
            BusPrice.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(50, 140);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 12;
            label10.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(41, 86);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 10;
            label8.Text = "Bus N0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(41, 37);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 8;
            label9.Text = "Bus ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(710, 45);
            label1.Name = "label1";
            label1.Size = new Size(211, 44);
            label1.TabIndex = 2;
            label1.Text = "Ticket's Form";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(297, 367);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(241, 44);
            txtID.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(160, 381);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 9;
            label11.Text = "Ticket ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(583, 381);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 11;
            label12.Text = "Purchas Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1011, 381);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 13;
            label13.Text = "Departure Date";
            // 
            // txtDestination
            // 
            txtDestination.BorderStyle = BorderStyle.FixedSingle;
            txtDestination.Location = new Point(720, 437);
            txtDestination.Multiline = true;
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(241, 44);
            txtDestination.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(583, 451);
            label15.Name = "label15";
            label15.Size = new Size(87, 20);
            label15.TabIndex = 17;
            label15.Text = "Destination";
            // 
            // txtOrigin
            // 
            txtOrigin.BorderStyle = BorderStyle.FixedSingle;
            txtOrigin.Location = new Point(297, 437);
            txtOrigin.Multiline = true;
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(241, 44);
            txtOrigin.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(160, 451);
            label16.Name = "label16";
            label16.Size = new Size(52, 20);
            label16.TabIndex = 15;
            label16.Text = "Origin";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(297, 536);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(664, 47);
            txtSearch.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Location = new Point(282, 926);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(583, 926);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 50);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(870, 926);
            button3.Name = "button3";
            button3.Size = new Size(152, 50);
            button3.TabIndex = 23;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.Location = new Point(1159, 926);
            button4.Name = "button4";
            button4.Size = new Size(152, 50);
            button4.TabIndex = 24;
            button4.Text = "NEW";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(166, 548);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 25;
            label14.Text = "Search";
            // 
            // dtpDeparture
            // 
            dtpDeparture.Location = new Point(1139, 374);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(250, 27);
            dtpDeparture.TabIndex = 26;
            // 
            // dtpPurchas
            // 
            dtpPurchas.Location = new Point(720, 374);
            dtpPurchas.Name = "dtpPurchas";
            dtpPurchas.Size = new Size(241, 27);
            dtpPurchas.TabIndex = 27;
            // 
            // DataTicket
            // 
            DataTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTicket.Location = new Point(261, 599);
            DataTicket.Name = "DataTicket";
            DataTicket.RowHeadersWidth = 51;
            DataTicket.RowTemplate.Height = 29;
            DataTicket.Size = new Size(1063, 321);
            DataTicket.TabIndex = 28;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1551, 988);
            Controls.Add(DataTicket);
            Controls.Add(dtpPurchas);
            Controls.Add(dtpDeparture);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(txtDestination);
            Controls.Add(label15);
            Controls.Add(txtOrigin);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtID);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketForm";
            Text = "TicketForm";
            WindowState = FormWindowState.Maximized;
            Load += TicketForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox CusName;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox CusPhone;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox BusPrice;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox txtID;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtDestination;
        private Label label15;
        private TextBox txtOrigin;
        private Label label16;
        private TextBox txtSearch;
        private Button btnSave;
        private Button btnSearch;
        private Button button3;
        private Button button4;
        private Label label14;
        private DateTimePicker dtpDeparture;
        private DateTimePicker dtpPurchas;
        private ComboBox cmBusID;
        private ComboBox cmStaffID;
        private TextBox BusN0;
        private TextBox StaffName;
        private ComboBox cmCusID;
        private DataGridView DataTicket;
    }
}