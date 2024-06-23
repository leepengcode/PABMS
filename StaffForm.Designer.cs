namespace PABMS
{
    partial class StaffForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtFullName = new TextBox();
            label12 = new Label();
            txtID = new TextBox();
            label11 = new Label();
            rbMale = new CheckBox();
            txtStaffAddress = new TextBox();
            Address = new Label();
            txtStaffPosition = new TextBox();
            label3 = new Label();
            txtStaffPhone = new TextBox();
            label6 = new Label();
            rbStoppedWork = new CheckBox();
            label5 = new Label();
            pbPhoto = new PictureBox();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            dtpBirthDate = new DateTimePicker();
            txtStaffSalary = new TextBox();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            rbFemale = new CheckBox();
            dtpHiredDate = new DateTimePicker();
            label4 = new Label();
            btnBrowsePhoto = new Button();
            DataStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataStaff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(714, 49);
            label1.Name = "label1";
            label1.Size = new Size(192, 44);
            label1.TabIndex = 3;
            label1.Text = "Staff's Form";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(609, 218);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 25;
            label15.Text = "Birth Date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(186, 218);
            label16.Name = "label16";
            label16.Size = new Size(33, 20);
            label16.TabIndex = 23;
            label16.Text = "Sex";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(746, 140);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(241, 44);
            txtFullName.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(609, 154);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 21;
            label12.Text = "Full Name";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(323, 140);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(241, 44);
            txtID.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(186, 154);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 19;
            label11.Text = "Staff ID";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbMale.Location = new Point(325, 214);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(65, 24);
            rbMale.TabIndex = 28;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtStaffAddress
            // 
            txtStaffAddress.BorderStyle = BorderStyle.FixedSingle;
            txtStaffAddress.Location = new Point(746, 322);
            txtStaffAddress.Multiline = true;
            txtStaffAddress.Name = "txtStaffAddress";
            txtStaffAddress.Size = new Size(241, 44);
            txtStaffAddress.TabIndex = 33;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Address.Location = new Point(609, 336);
            Address.Name = "Address";
            Address.Size = new Size(63, 20);
            Address.TabIndex = 32;
            Address.Text = "Address";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.BorderStyle = BorderStyle.FixedSingle;
            txtStaffPosition.Location = new Point(323, 261);
            txtStaffPosition.Multiline = true;
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(241, 44);
            txtStaffPosition.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 275);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 30;
            label3.Text = "Position";
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.BorderStyle = BorderStyle.FixedSingle;
            txtStaffPhone.Location = new Point(746, 261);
            txtStaffPhone.Multiline = true;
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(241, 44);
            txtStaffPhone.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(609, 275);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 34;
            label6.Text = "Phone";
            // 
            // rbStoppedWork
            // 
            rbStoppedWork.AutoSize = true;
            rbStoppedWork.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbStoppedWork.Location = new Point(746, 386);
            rbStoppedWork.Name = "rbStoppedWork";
            rbStoppedWork.Size = new Size(18, 17);
            rbStoppedWork.TabIndex = 37;
            rbStoppedWork.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(609, 387);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 36;
            label5.Text = "Stopped Work";
            // 
            // pbPhoto
            // 
            pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPhoto.Location = new Point(1063, 191);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(233, 228);
            pbPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPhoto.TabIndex = 38;
            pbPhoto.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(189, 480);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 45;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Location = new Point(1171, 896);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 50);
            btnNew.TabIndex = 44;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Location = new Point(858, 896);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 50);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(535, 896);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 50);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Location = new Point(253, 896);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 41;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(320, 468);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(664, 47);
            txtSearch.TabIndex = 39;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(746, 218);
            dtpBirthDate.Margin = new Padding(5);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(241, 27);
            dtpBirthDate.TabIndex = 46;
            // 
            // txtStaffSalary
            // 
            txtStaffSalary.BorderStyle = BorderStyle.FixedSingle;
            txtStaffSalary.Location = new Point(323, 322);
            txtStaffSalary.Multiline = true;
            txtStaffSalary.Name = "txtStaffSalary";
            txtStaffSalary.Size = new Size(241, 44);
            txtStaffSalary.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 336);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 48;
            label2.Text = "Salary";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbFemale.Location = new Point(407, 214);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(80, 24);
            rbFemale.TabIndex = 51;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpHiredDate
            // 
            dtpHiredDate.Location = new Point(320, 387);
            dtpHiredDate.Margin = new Padding(5);
            dtpHiredDate.Name = "dtpHiredDate";
            dtpHiredDate.Size = new Size(241, 27);
            dtpHiredDate.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(183, 387);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 52;
            label4.Text = "Hired Date";
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.Location = new Point(1063, 140);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(233, 44);
            btnBrowsePhoto.TabIndex = 54;
            btnBrowsePhoto.UseVisualStyleBackColor = true;
            btnBrowsePhoto.Click += btnBrowsePhoto_Click_1;
            // 
            // DataStaff
            // 
            DataStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataStaff.Location = new Point(54, 521);
            DataStaff.Name = "DataStaff";
            DataStaff.RowHeadersWidth = 51;
            DataStaff.RowTemplate.Height = 29;
            DataStaff.Size = new Size(1410, 369);
            DataStaff.TabIndex = 55;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 1025);
            Controls.Add(DataStaff);
            Controls.Add(btnBrowsePhoto);
            Controls.Add(dtpHiredDate);
            Controls.Add(label4);
            Controls.Add(rbFemale);
            Controls.Add(txtStaffSalary);
            Controls.Add(label2);
            Controls.Add(dtpBirthDate);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(pbPhoto);
            Controls.Add(rbStoppedWork);
            Controls.Add(label5);
            Controls.Add(txtStaffPhone);
            Controls.Add(label6);
            Controls.Add(txtStaffAddress);
            Controls.Add(Address);
            Controls.Add(txtStaffPosition);
            Controls.Add(label3);
            Controls.Add(rbMale);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txtFullName);
            Controls.Add(label12);
            Controls.Add(txtID);
            Controls.Add(label11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            WindowState = FormWindowState.Maximized;
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDestination;
        private Label label15;
        private Label label16;
        private TextBox txtFullName;
        private Label label12;
        private TextBox txtID;
        private Label label11;
        private CheckBox checkBox2;
        private CheckBox rbMale;
        private TextBox txtStaffAddress;
        private Label Address;
        private TextBox txtStaffPosition;
        private Label label3;
        private TextBox txtStaffPhone;
        private Label label6;
        private CheckBox rbStoppedWork;
        private Label label5;
        private PictureBox pbPhoto;
        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private TextBox txtSearch;
        private DateTimePicker dtpBirthDate;
        private TextBox txtStaffSalary;
        private Label label2;
        private BindingSource bindingSource1;
        private CheckBox rbFemale;
        private DateTimePicker dtpHiredDate;
        private Label label4;
        private Button btnBrowsePhoto;
        private DataGridView DataStaff;
    }
}