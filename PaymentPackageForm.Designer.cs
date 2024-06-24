namespace PABMS
{
    partial class PaymentPackageForm
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
            dateTimePicker1 = new DateTimePicker();
            DataBus = new DataGridView();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            txtQty = new TextBox();
            label4 = new Label();
            cmCusID = new ComboBox();
            txtName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmDriver = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label16 = new Label();
            txtPayID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataBus).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(791, 137);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 84;
            // 
            // DataBus
            // 
            DataBus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBus.Location = new Point(133, 479);
            DataBus.Margin = new Padding(3, 2, 3, 2);
            DataBus.Name = "DataBus";
            DataBus.RowHeadersWidth = 51;
            DataBus.RowTemplate.Height = 29;
            DataBus.Size = new Size(936, 210);
            DataBus.TabIndex = 83;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(166, 451);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 82;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Location = new Point(936, 694);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(133, 38);
            btnNew.TabIndex = 81;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Location = new Point(662, 694);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 38);
            btnUpdate.TabIndex = 80;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(380, 694);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 38);
            btnSearch.TabIndex = 79;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Location = new Point(133, 694);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 38);
            btnSave.TabIndex = 78;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(251, 431);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(486, 36);
            txtSearch.TabIndex = 77;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtQty);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmCusID);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmDriver);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(158, 260);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 130);
            panel1.TabIndex = 76;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(641, 77);
            txtQty.Margin = new Padding(3, 2, 3, 2);
            txtQty.Multiline = true;
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(208, 26);
            txtQty.TabIndex = 61;
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
            // cmCusID
            // 
            cmCusID.FormattingEnabled = true;
            cmCusID.Location = new Point(641, 22);
            cmCusID.Margin = new Padding(3, 2, 3, 2);
            cmCusID.Name = "cmCusID";
            cmCusID.Size = new Size(208, 23);
            cmCusID.TabIndex = 59;
            cmCusID.SelectedIndexChanged += cmCusID_SelectedIndexChanged_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(641, 47);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 26);
            txtName.TabIndex = 57;
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
            label2.Location = new Point(671, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 75;
            label2.Text = "Payment Date";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(278, 178);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(262, 34);
            txtAmount.TabIndex = 74;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(158, 188);
            label16.Name = "label16";
            label16.Size = new Size(51, 15);
            label16.TabIndex = 73;
            label16.Text = "Amount";
            // 
            // txtPayID
            // 
            txtPayID.BorderStyle = BorderStyle.FixedSingle;
            txtPayID.Location = new Point(278, 130);
            txtPayID.Margin = new Padding(3, 2, 3, 2);
            txtPayID.Multiline = true;
            txtPayID.Name = "txtPayID";
            txtPayID.ReadOnly = true;
            txtPayID.Size = new Size(262, 34);
            txtPayID.TabIndex = 72;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(158, 140);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 71;
            label11.Text = "Payment ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(540, 53);
            label1.Name = "label1";
            label1.Size = new Size(201, 35);
            label1.TabIndex = 70;
            label1.Text = "Payment's Form";
            // 
            // PaymentPackageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 749);
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
            Name = "PaymentPackageForm";
            Text = "PaymentForm";
            Load += PaymentPackageForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataBus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView DataBus;
        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private TextBox txtSearch;
        private Panel panel1;
        private TextBox txtQty;
        private Label label4;
        private ComboBox cmCusID;
        private TextBox txtName;
        private Label label7;
        private Label label8;
        private ComboBox cmDriver;
        private Label label6;
        private Label label2;
        private TextBox txtAmount;
        private Label label16;
        private TextBox txtPayID;
        private Label label11;
        private Label label1;
    }
}