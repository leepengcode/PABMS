namespace PABMS
{
    partial class TruckForm
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
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            cmTruck = new ComboBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtTruckNumber = new TextBox();
            label2 = new Label();
            txtTruckID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            DataTruck = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTruck).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(229, 588);
            label14.Name = "label14";
            label14.Size = new Size(159, 29);
            label14.TabIndex = 67;
            label14.Text = "Search Driver";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(1174, 908);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 50);
            btnNew.TabIndex = 66;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(861, 908);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 50);
            btnUpdate.TabIndex = 65;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(538, 908);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 50);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(256, 908);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 63;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(430, 583);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(673, 34);
            txtSearch.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmTruck);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(285, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 206);
            panel1.TabIndex = 60;
            // 
            // cmTruck
            // 
            cmTruck.FormattingEnabled = true;
            cmTruck.Location = new Point(396, 20);
            cmTruck.Name = "cmTruck";
            cmTruck.Size = new Size(517, 37);
            cmTruck.TabIndex = 9;
            cmTruck.SelectedIndexChanged += cmTruck_SelectedIndexChanged_1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(396, 103);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(517, 34);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(105, 108);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            label5.Click += label5_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(396, 63);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(517, 34);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 68);
            label3.Name = "label3";
            label3.Size = new Size(148, 29);
            label3.TabIndex = 2;
            label3.Text = "Driver Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 28);
            label6.Name = "label6";
            label6.Size = new Size(106, 29);
            label6.TabIndex = 0;
            label6.Text = "Driver ID";
            // 
            // txtTruckNumber
            // 
            txtTruckNumber.BorderStyle = BorderStyle.FixedSingle;
            txtTruckNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTruckNumber.Location = new Point(1005, 204);
            txtTruckNumber.Multiline = true;
            txtTruckNumber.Name = "txtTruckNumber";
            txtTruckNumber.Size = new Size(299, 34);
            txtTruckNumber.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(835, 206);
            label2.Name = "label2";
            label2.Size = new Size(167, 29);
            label2.TabIndex = 58;
            label2.Text = "Truck Number";
            // 
            // txtTruckID
            // 
            txtTruckID.AutoCompleteMode = AutoCompleteMode.Append;
            txtTruckID.BorderStyle = BorderStyle.FixedSingle;
            txtTruckID.Enabled = false;
            txtTruckID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTruckID.Location = new Point(391, 204);
            txtTruckID.Multiline = true;
            txtTruckID.Name = "txtTruckID";
            txtTruckID.Size = new Size(299, 34);
            txtTruckID.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(285, 208);
            label11.Name = "label11";
            label11.Size = new Size(103, 29);
            label11.TabIndex = 54;
            label11.Text = "Truck ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(721, 54);
            label1.Name = "label1";
            label1.Size = new Size(199, 36);
            label1.TabIndex = 53;
            label1.Text = "Truck's Form";
            // 
            // DataTruck
            // 
            DataTruck.AllowUserToAddRows = false;
            DataTruck.AllowUserToDeleteRows = false;
            DataTruck.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTruck.Location = new Point(430, 623);
            DataTruck.Name = "DataTruck";
            DataTruck.ReadOnly = true;
            DataTruck.RowHeadersWidth = 51;
            DataTruck.RowTemplate.Height = 29;
            DataTruck.Size = new Size(673, 279);
            DataTruck.TabIndex = 68;
            DataTruck.CellClick += gridDriver_CellClick;
            // 
            // TruckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 1012);
            Controls.Add(DataTruck);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(txtTruckNumber);
            Controls.Add(label2);
            Controls.Add(txtTruckID);
            Controls.Add(label11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TruckForm";
            Text = "VehicleForm";
            Load += TruckForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataTruck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private TextBox txtSearch;
        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label6;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private TextBox txtTruckNumber;
        private TextBox txtTruckID;
        private Label label2;
        private Label label11;
        private Label label1;
        private DataGridView DataTruck;
        private ComboBox cmTruck;
    }
}