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
            cmCusName = new ComboBox();
            CusPhone = new TextBox();
            label5 = new Label();
            CusID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            StaffID = new TextBox();
            cmStaffName = new ComboBox();
            textBox10 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox9 = new TextBox();
            panel3 = new Panel();
            txtBusID = new TextBox();
            cmbBusNumber = new ComboBox();
            txtTicketPrice = new TextBox();
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
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTicket).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmCusName);
            panel1.Controls.Add(CusPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CusID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(124, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 202);
            panel1.TabIndex = 0;
            // 
            // cmCusName
            // 
            cmCusName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmCusName.FormattingEnabled = true;
            cmCusName.Location = new Point(218, 79);
            cmCusName.Name = "cmCusName";
            cmCusName.Size = new Size(178, 37);
            cmCusName.TabIndex = 31;
            cmCusName.SelectedIndexChanged += cmCusID_SelectedIndexChanged;
            // 
            // CusPhone
            // 
            CusPhone.BorderStyle = BorderStyle.FixedSingle;
            CusPhone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CusPhone.Location = new Point(218, 134);
            CusPhone.Multiline = true;
            CusPhone.Name = "CusPhone";
            CusPhone.Size = new Size(178, 34);
            CusPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 135);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // CusID
            // 
            CusID.BorderStyle = BorderStyle.FixedSingle;
            CusID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CusID.Location = new Point(218, 29);
            CusID.Multiline = true;
            CusID.Name = "CusID";
            CusID.Size = new Size(178, 34);
            CusID.TabIndex = 3;
            CusID.TextChanged += CusName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 82);
            label3.Name = "label3";
            label3.Size = new Size(188, 29);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 29);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 0;
            label2.Text = "Customer ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(StaffID);
            panel2.Controls.Add(cmStaffName);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox9);
            panel2.Location = new Point(595, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 202);
            panel2.TabIndex = 1;
            // 
            // StaffID
            // 
            StaffID.BorderStyle = BorderStyle.FixedSingle;
            StaffID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            StaffID.Location = new Point(175, 29);
            StaffID.Multiline = true;
            StaffID.Name = "StaffID";
            StaffID.ReadOnly = true;
            StaffID.Size = new Size(178, 34);
            StaffID.TabIndex = 30;
            // 
            // cmStaffName
            // 
            cmStaffName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmStaffName.FormattingEnabled = true;
            cmStaffName.Location = new Point(175, 79);
            cmStaffName.Name = "cmStaffName";
            cmStaffName.Size = new Size(178, 37);
            cmStaffName.TabIndex = 30;
            cmStaffName.SelectedIndexChanged += cmbStaffName_SelectedIndexChanged;
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
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(22, 83);
            label6.Name = "label6";
            label6.Size = new Size(131, 29);
            label6.TabIndex = 6;
            label6.Text = "Staff Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(22, 29);
            label7.Name = "label7";
            label7.Size = new Size(89, 29);
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
            panel3.Controls.Add(txtBusID);
            panel3.Controls.Add(cmbBusNumber);
            panel3.Controls.Add(txtTicketPrice);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(976, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 202);
            panel3.TabIndex = 1;
            // 
            // txtBusID
            // 
            txtBusID.BorderStyle = BorderStyle.FixedSingle;
            txtBusID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusID.Location = new Point(144, 25);
            txtBusID.Multiline = true;
            txtBusID.Name = "txtBusID";
            txtBusID.ReadOnly = true;
            txtBusID.Size = new Size(178, 34);
            txtBusID.TabIndex = 29;
            // 
            // cmbBusNumber
            // 
            cmbBusNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBusNumber.FormattingEnabled = true;
            cmbBusNumber.Location = new Point(144, 69);
            cmbBusNumber.Name = "cmbBusNumber";
            cmbBusNumber.Size = new Size(178, 37);
            cmbBusNumber.TabIndex = 28;
            cmbBusNumber.SelectedIndexChanged += cmBusName_SelectedIndexChanged;
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.BorderStyle = BorderStyle.FixedSingle;
            txtTicketPrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTicketPrice.Location = new Point(144, 116);
            txtTicketPrice.Multiline = true;
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.ReadOnly = true;
            txtTicketPrice.Size = new Size(178, 34);
            txtTicketPrice.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(224, 224, 224);
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(34, 118);
            label10.Name = "label10";
            label10.Size = new Size(69, 29);
            label10.TabIndex = 12;
            label10.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(34, 75);
            label8.Name = "label8";
            label8.Size = new Size(91, 29);
            label8.TabIndex = 10;
            label8.Text = "Bus N0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(34, 27);
            label9.Name = "label9";
            label9.Size = new Size(83, 29);
            label9.TabIndex = 8;
            label9.Text = "Bus ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(675, 58);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 2;
            label1.Text = "Ticket's Form";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(297, 367);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 34);
            txtID.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(149, 369);
            label11.Name = "label11";
            label11.Size = new Size(108, 29);
            label11.TabIndex = 9;
            label11.Text = "Ticket ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(695, 372);
            label12.Name = "label12";
            label12.Size = new Size(156, 29);
            label12.TabIndex = 11;
            label12.Text = "Purchas Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(695, 424);
            label13.Name = "label13";
            label13.Size = new Size(176, 29);
            label13.TabIndex = 13;
            label13.Text = "Departure Date";
            // 
            // txtDestination
            // 
            txtDestination.BorderStyle = BorderStyle.FixedSingle;
            txtDestination.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestination.Location = new Point(297, 473);
            txtDestination.Multiline = true;
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(250, 34);
            txtDestination.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(149, 478);
            label15.Name = "label15";
            label15.Size = new Size(133, 29);
            label15.TabIndex = 17;
            label15.Text = "Destination";
            // 
            // txtOrigin
            // 
            txtOrigin.BorderStyle = BorderStyle.FixedSingle;
            txtOrigin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigin.Location = new Point(297, 422);
            txtOrigin.Multiline = true;
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(250, 34);
            txtOrigin.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(149, 425);
            label16.Name = "label16";
            label16.Size = new Size(79, 29);
            label16.TabIndex = 15;
            label16.Text = "Origin";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(297, 539);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 34);
            txtSearch.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(213, 925);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 51);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(530, 925);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 51);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(841, 925);
            button3.Name = "button3";
            button3.Size = new Size(152, 51);
            button3.TabIndex = 23;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1127, 925);
            button4.Name = "button4";
            button4.Size = new Size(152, 51);
            button4.TabIndex = 24;
            button4.Text = "NEW";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(149, 541);
            label14.Name = "label14";
            label14.Size = new Size(89, 29);
            label14.TabIndex = 25;
            label14.Text = "Search";
            // 
            // dtpDeparture
            // 
            dtpDeparture.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDeparture.Location = new Point(929, 422);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(422, 34);
            dtpDeparture.TabIndex = 26;
            // 
            // dtpPurchas
            // 
            dtpPurchas.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPurchas.Location = new Point(928, 367);
            dtpPurchas.Name = "dtpPurchas";
            dtpPurchas.Size = new Size(423, 34);
            dtpPurchas.TabIndex = 27;
            // 
            // DataTicket
            // 
            DataTicket.AllowUserToAddRows = false;
            DataTicket.AllowUserToDeleteRows = false;
            DataTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTicket.Location = new Point(213, 598);
            DataTicket.Name = "DataTicket";
            DataTicket.ReadOnly = true;
            DataTicket.RowHeadersWidth = 51;
            DataTicket.RowTemplate.Height = 29;
            DataTicket.Size = new Size(1066, 287);
            DataTicket.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1127, 541);
            button1.Name = "button1";
            button1.Size = new Size(152, 51);
            button1.TabIndex = 29;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1597, 1060);
            Controls.Add(button1);
            Controls.Add(DataTicket);
            Controls.Add(dtpPurchas);
            Controls.Add(dtpDeparture);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSearch);
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
            Controls.Add(btnSave);
            ForeColor = Color.Black;
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
        private TextBox CusID;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox CusPhone;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTicketPrice;
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
        private ComboBox cmbBusNumber;
        private ComboBox cmStaffName;
        private TextBox txtBusID;
        private TextBox StaffID;
        private ComboBox cmCusName;
        private DataGridView DataTicket;
        private Button button1;
    }
}