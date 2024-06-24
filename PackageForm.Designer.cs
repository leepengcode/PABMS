namespace PABMS
{
    partial class PackageForm
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
            txtReciverContact = new TextBox();
            label15 = new Label();
            txtPackagePrice = new TextBox();
            label16 = new Label();
            label13 = new Label();
            txtPackageID = new TextBox();
            label11 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txtTruckNo = new TextBox();
            label8 = new Label();
            txtTruckID = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            txtStaffName = new TextBox();
            label6 = new Label();
            txtStaffID = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            ckFemale = new CheckBox();
            ckMale = new CheckBox();
            label4 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtCustomerID = new TextBox();
            label2 = new Label();
            label10 = new Label();
            txtOrigin = new TextBox();
            label17 = new Label();
            txtDestination = new TextBox();
            label18 = new Label();
            txtSearch = new TextBox();
            gridSearch = new DataGridView();
            dateDeparture = new DateTimePicker();
            dateDelivery = new DateTimePicker();
            txtPackageName = new TextBox();
            label19 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSearch).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(93, 606);
            label14.Name = "label14";
            label14.Size = new Size(89, 29);
            label14.TabIndex = 46;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(1163, 904);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 50);
            btnNew.TabIndex = 45;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(850, 904);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 50);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(527, 904);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 50);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(245, 904);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 42;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtReciverContact
            // 
            txtReciverContact.BorderStyle = BorderStyle.FixedSingle;
            txtReciverContact.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtReciverContact.Location = new Point(779, 511);
            txtReciverContact.Multiline = true;
            txtReciverContact.Name = "txtReciverContact";
            txtReciverContact.Size = new Size(676, 34);
            txtReciverContact.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(573, 514);
            label15.Name = "label15";
            label15.Size = new Size(196, 29);
            label15.TabIndex = 38;
            label15.Text = "Reciever Contact";
            // 
            // txtPackagePrice
            // 
            txtPackagePrice.BorderStyle = BorderStyle.FixedSingle;
            txtPackagePrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPackagePrice.Location = new Point(294, 417);
            txtPackagePrice.Multiline = true;
            txtPackagePrice.Name = "txtPackagePrice";
            txtPackagePrice.Size = new Size(250, 34);
            txtPackagePrice.TabIndex = 37;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(93, 422);
            label16.Name = "label16";
            label16.Size = new Size(169, 29);
            label16.TabIndex = 36;
            label16.Text = "Package Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(573, 422);
            label13.Name = "label13";
            label13.Size = new Size(156, 29);
            label13.TabIndex = 34;
            label13.Text = "Delivery Date";
            // 
            // txtPackageID
            // 
            txtPackageID.BorderStyle = BorderStyle.FixedSingle;
            txtPackageID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPackageID.Location = new Point(294, 371);
            txtPackageID.Multiline = true;
            txtPackageID.Name = "txtPackageID";
            txtPackageID.Size = new Size(250, 34);
            txtPackageID.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(93, 373);
            label11.Name = "label11";
            label11.Size = new Size(136, 29);
            label11.TabIndex = 30;
            label11.Text = "Package ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(709, 51);
            label1.Name = "label1";
            label1.Size = new Size(241, 36);
            label1.TabIndex = 29;
            label1.Text = "Package's Form";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtTruckNo);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtTruckID);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(1027, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 202);
            panel3.TabIndex = 27;
            // 
            // txtTruckNo
            // 
            txtTruckNo.BorderStyle = BorderStyle.FixedSingle;
            txtTruckNo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTruckNo.Location = new Point(159, 63);
            txtTruckNo.Multiline = true;
            txtTruckNo.Name = "txtTruckNo";
            txtTruckNo.Size = new Size(250, 34);
            txtTruckNo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 66);
            label8.Name = "label8";
            label8.Size = new Size(111, 29);
            label8.TabIndex = 10;
            label8.Text = "Truck N0";
            // 
            // txtTruckID
            // 
            txtTruckID.BorderStyle = BorderStyle.FixedSingle;
            txtTruckID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTruckID.Location = new Point(159, 23);
            txtTruckID.Multiline = true;
            txtTruckID.Name = "txtTruckID";
            txtTruckID.Size = new Size(250, 34);
            txtTruckID.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(23, 28);
            label9.Name = "label9";
            label9.Size = new Size(103, 29);
            label9.TabIndex = 8;
            label9.Text = "Truck ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtStaffName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtStaffID);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(585, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 202);
            panel2.TabIndex = 28;
            // 
            // txtStaffName
            // 
            txtStaffName.BorderStyle = BorderStyle.FixedSingle;
            txtStaffName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(150, 63);
            txtStaffName.Multiline = true;
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(250, 34);
            txtStaffName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 68);
            label6.Name = "label6";
            label6.Size = new Size(131, 29);
            label6.TabIndex = 6;
            label6.Text = "Staff Name";
            // 
            // txtStaffID
            // 
            txtStaffID.BorderStyle = BorderStyle.FixedSingle;
            txtStaffID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(150, 23);
            txtStaffID.Multiline = true;
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(250, 34);
            txtStaffID.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 28);
            label7.Name = "label7";
            label7.Size = new Size(89, 29);
            label7.TabIndex = 4;
            label7.Text = "Staff ID";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ckFemale);
            panel1.Controls.Add(ckMale);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCustomerID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(79, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 202);
            panel1.TabIndex = 26;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(216, 144);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(250, 34);
            txtPhoneNumber.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 144);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // ckFemale
            // 
            ckFemale.AutoSize = true;
            ckFemale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ckFemale.Location = new Point(310, 104);
            ckFemale.Name = "ckFemale";
            ckFemale.Size = new Size(117, 33);
            ckFemale.TabIndex = 6;
            ckFemale.Text = "Female";
            ckFemale.UseVisualStyleBackColor = true;
            // 
            // ckMale
            // 
            ckMale.AutoSize = true;
            ckMale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ckMale.Location = new Point(216, 105);
            ckMale.Name = "ckMale";
            ckMale.Size = new Size(88, 33);
            ckMale.TabIndex = 5;
            ckMale.Text = "Male";
            ckMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 105);
            label4.Name = "label4";
            label4.Size = new Size(54, 29);
            label4.TabIndex = 4;
            label4.Text = "Sex";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerName.Location = new Point(216, 63);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(250, 34);
            txtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 66);
            label3.Name = "label3";
            label3.Size = new Size(188, 29);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // txtCustomerID
            // 
            txtCustomerID.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.Location = new Point(216, 23);
            txtCustomerID.Multiline = true;
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(250, 34);
            txtCustomerID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 28);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 0;
            label2.Text = "Customer ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(575, 466);
            label10.Name = "label10";
            label10.Size = new Size(176, 29);
            label10.TabIndex = 47;
            label10.Text = "Departure Date";
            // 
            // txtOrigin
            // 
            txtOrigin.BorderStyle = BorderStyle.FixedSingle;
            txtOrigin.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigin.Location = new Point(294, 466);
            txtOrigin.Multiline = true;
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(250, 34);
            txtOrigin.TabIndex = 52;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(93, 468);
            label17.Name = "label17";
            label17.Size = new Size(79, 29);
            label17.TabIndex = 51;
            label17.Text = "Origin";
            // 
            // txtDestination
            // 
            txtDestination.BorderStyle = BorderStyle.FixedSingle;
            txtDestination.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestination.Location = new Point(294, 511);
            txtDestination.Multiline = true;
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(250, 34);
            txtDestination.TabIndex = 50;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(93, 511);
            label18.Name = "label18";
            label18.Size = new Size(133, 29);
            label18.TabIndex = 49;
            label18.Text = "Destination";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(188, 606);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(478, 34);
            txtSearch.TabIndex = 52;
            // 
            // gridSearch
            // 
            gridSearch.AllowUserToAddRows = false;
            gridSearch.AllowUserToDeleteRows = false;
            gridSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSearch.Location = new Point(93, 668);
            gridSearch.Name = "gridSearch";
            gridSearch.ReadOnly = true;
            gridSearch.RowHeadersWidth = 51;
            gridSearch.RowTemplate.Height = 29;
            gridSearch.Size = new Size(1270, 188);
            gridSearch.TabIndex = 53;
            // 
            // dateDeparture
            // 
            dateDeparture.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateDeparture.Location = new Point(779, 461);
            dateDeparture.Name = "dateDeparture";
            dateDeparture.Size = new Size(250, 34);
            dateDeparture.TabIndex = 54;
            // 
            // dateDelivery
            // 
            dateDelivery.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateDelivery.Location = new Point(779, 420);
            dateDelivery.Name = "dateDelivery";
            dateDelivery.Size = new Size(250, 34);
            dateDelivery.TabIndex = 54;
            // 
            // txtPackageName
            // 
            txtPackageName.BorderStyle = BorderStyle.FixedSingle;
            txtPackageName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPackageName.Location = new Point(779, 374);
            txtPackageName.Multiline = true;
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(676, 34);
            txtPackageName.TabIndex = 31;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(573, 376);
            label19.Name = "label19";
            label19.Size = new Size(178, 29);
            label19.TabIndex = 30;
            label19.Text = "Package Name";
            // 
            // PackageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 972);
            Controls.Add(dateDelivery);
            Controls.Add(dateDeparture);
            Controls.Add(gridSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtOrigin);
            Controls.Add(label17);
            Controls.Add(txtDestination);
            Controls.Add(label18);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtReciverContact);
            Controls.Add(label15);
            Controls.Add(txtPackagePrice);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(txtPackageName);
            Controls.Add(txtPackageID);
            Controls.Add(label19);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PackageForm";
            Text = "BagageForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private Label label15;
        private Label label16;
        private Label label13;
        private Label label12;
        
        private Label label11;
        private Label label1;
        private Panel panel3;
        
        private Label label8;
        
        private Label label9;
        private Panel panel2;
        
        private Label label6;
        
        private Label label7;
        private Panel panel1;
        
        private Label label5;
        
        
        private Label label4;
        
        private Label label3;
        
        private Label label2;
        private Label label10;
        private Label label17;
        private Label label18;


        private TextBox txtTruckNo;
        private TextBox txtTruckID;

        private TextBox txtStaffName;
        private TextBox txtStaffID;

        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private TextBox txtPhoneNumber;
        private CheckBox ckFemale;
        private CheckBox ckMale;

        private TextBox txtPackageID;
        private TextBox txtOrigin;
        private TextBox txtDestination;
        private TextBox txtReciverContact;
        private TextBox txtPackagePrice;

        private TextBox txtSearch;
        private DataGridView gridSearch;
        private DateTimePicker dateDeparture;
        private DateTimePicker datePurchase;
        private DateTimePicker dateDelivery;
        private TextBox txtPackageName;
        private Label label19;
    }
}