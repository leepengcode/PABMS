namespace PABMS
{
    partial class BusForm
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
            label1 = new Label();
            txtPrice = new TextBox();
            label16 = new Label();
            txtBusID = new TextBox();
            label11 = new Label();
            txtBusNo = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtPhone = new TextBox();
            cmDriver = new ComboBox();
            label5 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            DataBus = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataBus).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(729, 62);
            label1.Name = "label1";
            label1.Size = new Size(177, 44);
            label1.TabIndex = 3;
            label1.Text = "Bus's Form";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(430, 228);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(299, 44);
            txtPrice.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(293, 242);
            label16.Name = "label16";
            label16.Size = new Size(87, 20);
            label16.TabIndex = 29;
            label16.Text = "Ticket Price";
            // 
            // txtBusID
            // 
            txtBusID.BorderStyle = BorderStyle.FixedSingle;
            txtBusID.Location = new Point(430, 164);
            txtBusID.Multiline = true;
            txtBusID.Name = "txtBusID";
            txtBusID.ReadOnly = true;
            txtBusID.Size = new Size(299, 44);
            txtBusID.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(293, 178);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 25;
            label11.Text = "Bus ID";
            // 
            // txtBusNo
            // 
            txtBusNo.BorderStyle = BorderStyle.FixedSingle;
            txtBusNo.Location = new Point(1016, 164);
            txtBusNo.Multiline = true;
            txtBusNo.Name = "txtBusNo";
            txtBusNo.Size = new Size(299, 44);
            txtBusNo.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(879, 178);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 31;
            label2.Text = "Bus Number";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(cmDriver);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(293, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 176);
            panel1.TabIndex = 33;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(396, 103);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(517, 34);
            txtPhone.TabIndex = 54;
            // 
            // cmDriver
            // 
            cmDriver.FormattingEnabled = true;
            cmDriver.Location = new Point(396, 29);
            cmDriver.Name = "cmDriver";
            cmDriver.Size = new Size(517, 28);
            cmDriver.TabIndex = 53;
            cmDriver.SelectedIndexChanged += cmDriver_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(105, 117);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(396, 63);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(517, 34);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(105, 77);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Driver Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(105, 37);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 0;
            label6.Text = "Driver ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(399, 597);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 52;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Location = new Point(1182, 916);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 50);
            btnNew.TabIndex = 51;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Location = new Point(869, 916);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 50);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(546, 916);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 50);
            btnSearch.TabIndex = 49;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Location = new Point(264, 916);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 48;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(509, 580);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(555, 47);
            txtSearch.TabIndex = 46;
            // 
            // DataBus
            // 
            DataBus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataBus.Location = new Point(509, 648);
            DataBus.Name = "DataBus";
            DataBus.RowHeadersWidth = 51;
            DataBus.RowTemplate.Height = 29;
            DataBus.Size = new Size(555, 262);
            DataBus.TabIndex = 53;
            // 
            // BusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 997);
            Controls.Add(DataBus);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(txtBusNo);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label16);
            Controls.Add(txtBusID);
            Controls.Add(label11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BusForm";
            Text = "BusForm";
            Load += BusForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataBus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrice;
        private Label label16;
        private TextBox txtBusID;
        private Label label11;
        private TextBox txtBusNo;
        private Label label2;
        private Panel panel1;
        private TextBox textBox3;
        private Label label5;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private Label label6;
        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private TextBox txtSearch;
        private ComboBox cmDriver;
        private TextBox txtPhone;
        private DataGridView DataBus;
    }
}