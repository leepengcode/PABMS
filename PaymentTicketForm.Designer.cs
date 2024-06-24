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
            DataBus = new DataGridView();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmDriver = new ComboBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label16 = new Label();
            txtPayID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataBus).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataBus
            // 
            DataBus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBus.Location = new Point(170, 468);
            DataBus.Margin = new Padding(3, 2, 3, 2);
            DataBus.Name = "DataBus";
            DataBus.RowHeadersWidth = 51;
            DataBus.RowTemplate.Height = 29;
            DataBus.Size = new Size(936, 218);
            DataBus.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(204, 445);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 67;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Location = new Point(974, 691);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(133, 38);
            btnNew.TabIndex = 66;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Location = new Point(700, 691);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 38);
            btnUpdate.TabIndex = 65;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(417, 691);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 38);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Location = new Point(170, 691);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 38);
            btnSave.TabIndex = 63;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(288, 424);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(486, 36);
            txtSearch.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmDriver);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(196, 258);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 130);
            panel1.TabIndex = 61;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(641, 77);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 26);
            textBox1.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(473, 88);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 60;
            label4.Text = "Ticket Qty";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(641, 22);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 59;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(641, 47);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 26);
            textBox2.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(473, 58);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 56;
            label7.Text = "Customer Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(473, 28);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 55;
            label8.Text = "Customer ID";
            // 
            // cmDriver
            // 
            cmDriver.FormattingEnabled = true;
            cmDriver.Location = new Point(214, 22);
            cmDriver.Margin = new Padding(3, 2, 3, 2);
            cmDriver.Name = "cmDriver";
            cmDriver.Size = new Size(208, 23);
            cmDriver.TabIndex = 53;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(214, 47);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(208, 26);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 58);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Ticket Qty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(46, 28);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "Ticket ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(708, 138);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 59;
            label2.Text = "Payment Date";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(316, 175);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(262, 34);
            txtAmount.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(196, 186);
            label16.Name = "label16";
            label16.Size = new Size(51, 15);
            label16.TabIndex = 57;
            label16.Text = "Amount";
            // 
            // txtPayID
            // 
            txtPayID.BorderStyle = BorderStyle.FixedSingle;
            txtPayID.Location = new Point(316, 127);
            txtPayID.Margin = new Padding(3, 2, 3, 2);
            txtPayID.Multiline = true;
            txtPayID.Name = "txtPayID";
            txtPayID.ReadOnly = true;
            txtPayID.Size = new Size(262, 34);
            txtPayID.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(196, 138);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 55;
            label11.Text = "Payment ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 50);
            label1.Name = "label1";
            label1.Size = new Size(201, 35);
            label1.TabIndex = 54;
            label1.Text = "Payment's Form";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(828, 134);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 69;
            // 
            // PaymentTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 755);
            Controls.Add(dateTimePicker1);
            Controls.Add(DataBus);
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
            Controls.Add(txtPayID);
            Controls.Add(label11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaymentTicketForm";
            Text = "PaymentForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DataBus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataBus;
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
        private TextBox txtPayID;
        private Label label11;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
    }
}