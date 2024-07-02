namespace PABMS
{
    partial class PaymentTicketForm
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
            gridPaymentTicket = new DataGridView();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            cmbCusName = new ComboBox();
            txtCusID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTicketID = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label16 = new Label();
            txtPaymentTicketID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPaymentTicket).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPaymentTicket
            // 
            gridPaymentTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPaymentTicket.Location = new Point(315, 595);
            gridPaymentTicket.Name = "gridPaymentTicket";
            gridPaymentTicket.RowHeadersWidth = 51;
            gridPaymentTicket.RowTemplate.Height = 29;
            gridPaymentTicket.Size = new Size(1052, 291);
            gridPaymentTicket.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(315, 544);
            label14.Name = "label14";
            label14.Size = new Size(89, 29);
            label14.TabIndex = 67;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(1215, 921);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 51);
            btnNew.TabIndex = 66;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(907, 921);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 51);
            btnUpdate.TabIndex = 65;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(608, 921);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 51);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(311, 921);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 51);
            btnSave.TabIndex = 63;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(429, 544);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 34);
            txtSearch.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbCusName);
            panel1.Controls.Add(txtCusID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTicketID);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(319, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 189);
            panel1.TabIndex = 61;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(733, 120);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(529, 123);
            label4.Name = "label4";
            label4.Size = new Size(159, 29);
            label4.TabIndex = 60;
            label4.Text = "Customer Tel";
            // 
            // cmbCusName
            // 
            cmbCusName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCusName.FormattingEnabled = true;
            cmbCusName.Location = new Point(733, 72);
            cmbCusName.Name = "cmbCusName";
            cmbCusName.Size = new Size(250, 37);
            cmbCusName.TabIndex = 59;
            // 
            // txtCusID
            // 
            txtCusID.BorderStyle = BorderStyle.FixedSingle;
            txtCusID.Enabled = false;
            txtCusID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCusID.Location = new Point(733, 26);
            txtCusID.Multiline = true;
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(250, 34);
            txtCusID.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(529, 77);
            label7.Name = "label7";
            label7.Size = new Size(188, 29);
            label7.TabIndex = 56;
            label7.Text = "Customer Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(529, 29);
            label8.Name = "label8";
            label8.Size = new Size(146, 29);
            label8.TabIndex = 55;
            label8.Text = "Customer ID";
            // 
            // txtTicketID
            // 
            txtTicketID.BorderStyle = BorderStyle.FixedSingle;
            txtTicketID.Enabled = false;
            txtTicketID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTicketID.Location = new Point(207, 26);
            txtTicketID.Multiline = true;
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(250, 34);
            txtTicketID.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(207, 77);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 34);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 80);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 2;
            label3.Text = "Ticket Qty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 29);
            label6.Name = "label6";
            label6.Size = new Size(108, 29);
            label6.TabIndex = 0;
            label6.Text = "Ticket ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(807, 171);
            label2.Name = "label2";
            label2.Size = new Size(162, 29);
            label2.TabIndex = 59;
            label2.Text = "Payment Date";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(474, 233);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 34);
            txtAmount.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(319, 235);
            label16.Name = "label16";
            label16.Size = new Size(94, 29);
            label16.TabIndex = 57;
            label16.Text = "Amount";
            // 
            // txtPaymentTicketID
            // 
            txtPaymentTicketID.BackColor = SystemColors.Window;
            txtPaymentTicketID.BorderStyle = BorderStyle.FixedSingle;
            txtPaymentTicketID.Enabled = false;
            txtPaymentTicketID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentTicketID.Location = new Point(474, 171);
            txtPaymentTicketID.Multiline = true;
            txtPaymentTicketID.Name = "txtPaymentTicketID";
            txtPaymentTicketID.ReadOnly = true;
            txtPaymentTicketID.Size = new Size(250, 34);
            txtPaymentTicketID.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(315, 171);
            label11.Name = "label11";
            label11.Size = new Size(135, 29);
            label11.TabIndex = 55;
            label11.Text = "Payment ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(712, 71);
            label1.Name = "label1";
            label1.Size = new Size(335, 36);
            label1.TabIndex = 54;
            label1.Text = "Ticket Payment's Form";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(975, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(392, 34);
            dateTimePicker1.TabIndex = 69;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1215, 530);
            button1.Name = "button1";
            button1.Size = new Size(152, 56);
            button1.TabIndex = 86;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            // 
            // PaymentTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 1007);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(gridPaymentTicket);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Controls.Add(label16);
            Controls.Add(txtPaymentTicketID);
            Controls.Add(label11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentTicketForm";
            Text = "PaymentForm";
            WindowState = FormWindowState.Maximized;
            Load += PaymentTicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridPaymentTicket).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridPaymentTicket;
        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private TextBox txtSearch;
        private Panel panel1;
        private ComboBox cmDriver;
        private TextBox txtFullName;
        private Label label3;
        private Label label6;
        private TextBox txtBusNo;
        private Label label2;
        private TextBox txtAmount;
        private Label label16;
        private TextBox txtPaymentTicketID;
        private Label label11;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label4;
        private ComboBox cmbCusName;
        private TextBox txtCusID;
        private Label label7;
        private Label label8;
        private TextBox txtTicketID;
        private Button button1;
    }
}