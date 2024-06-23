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
            txtSex = new TextBox();
            label16 = new Label();
            txtName = new TextBox();
            label12 = new Label();
            txtID = new TextBox();
            label11 = new Label();
            
            ckMale = new CheckBox();
            label4 = new Label();
            txtAddress = new TextBox();
            Address = new Label();
            txtPosition = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            ckStopwork = new CheckBox();
            label5 = new Label();
            photoBox = new PictureBox();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            listView1 = new ListView();
            txtSearch = new TextBox();
            bdStaff = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            label7 = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)photoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            // txtSex
            // 
            txtSex.BorderStyle = BorderStyle.FixedSingle;
            txtSex.Location = new Point(323, 204);
            txtSex.Multiline = true;
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(241, 44);
            txtSex.TabIndex = 24;
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
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(746, 140);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 44);
            txtName.TabIndex = 22;
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
            // ckFemale
            // 
           
            // 
            // ckMale
            // 
            ckMale.AutoSize = true;
            ckMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckMale.Location = new Point(340, 272);
            ckMale.Name = "ckMale";
            ckMale.Size = new Size(65, 24);
            ckMale.TabIndex = 28;
            ckMale.Text = "Male";
            ckMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(192, 276);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 27;
            label4.Text = "Sex";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(746, 322);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(241, 44);
            txtAddress.TabIndex = 33;
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
            // txtPosition
            // 
            txtPosition.BorderStyle = BorderStyle.FixedSingle;
            txtPosition.Location = new Point(323, 322);
            txtPosition.Multiline = true;
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(241, 44);
            txtPosition.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 336);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 30;
            label3.Text = "Position";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(746, 261);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(241, 44);
            txtPhone.TabIndex = 35;
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
            // ckStopwork
            // 
            ckStopwork.AutoSize = true;
            ckStopwork.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckStopwork.Location = new Point(329, 443);
            ckStopwork.Name = "ckStopwork";
            ckStopwork.Size = new Size(18, 17);
            ckStopwork.TabIndex = 37;
            ckStopwork.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(192, 444);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 36;
            label5.Text = "Stopped Work";
            // 
            // photoBox
            // 
            photoBox.Location = new Point(1063, 140);
            photoBox.Name = "photoBox";
            photoBox.Size = new Size(233, 279);
            photoBox.SizeMode = PictureBoxSizeMode.CenterImage;
            photoBox.TabIndex = 38;
            photoBox.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(189, 518);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 45;
            label14.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Location = new Point(1189, 842);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(152, 50);
            btnNew.TabIndex = 44;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Location = new Point(876, 842);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 50);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(553, 842);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 50);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Location = new Point(271, 842);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 50);
            btnSave.TabIndex = 41;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(186, 569);
            listView1.Name = "listView1";
            listView1.Size = new Size(1226, 244);
            listView1.TabIndex = 40;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(320, 506);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(664, 47);
            txtSearch.TabIndex = 39;
            // 
            // bdStaff
            // 
            bdStaff.Location = new Point(746, 218);
            bdStaff.Margin = new Padding(5);
            bdStaff.Name = "bdStaff";
            bdStaff.Size = new Size(241, 27);
            bdStaff.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(746, 384);
            dateTimePicker1.Margin = new Padding(5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 50;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(323, 375);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 44);
            textBox1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 389);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 48;
            label2.Text = "Position";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(609, 384);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 47;
            label7.Text = "Birth Date";
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 926);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(bdStaff);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(listView1);
            Controls.Add(txtSearch);
            Controls.Add(photoBox);
            Controls.Add(ckStopwork);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(Address);
            Controls.Add(txtPosition);
            Controls.Add(label3);
       
            Controls.Add(ckMale);
            Controls.Add(label4);
            Controls.Add(label15);
            Controls.Add(txtSex);
            Controls.Add(label16);
            Controls.Add(txtName);
            Controls.Add(label12);
            Controls.Add(txtID);
            Controls.Add(label11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            WindowState = FormWindowState.Maximized;
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)photoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDestination;
        private Label label15;
        private TextBox txtSex;
        private Label label16;
        private TextBox txtName;
        private Label label12;
        private TextBox txtID;
        private Label label11;
        private CheckBox checkBox2;
        private CheckBox ckMale;
        private Label label4;
        private TextBox txtAddress;
        private Label Address;
        private TextBox txtPosition;
        private Label label3;
        private TextBox txtPhone;
        private Label label6;
        private CheckBox ckStopwork;
        private Label label5;
        private PictureBox photoBox;
        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnSave;
        private ListView listView1;
        private TextBox txtSearch;
        private DateTimePicker bdStaff;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private Label label7;
        private BindingSource bindingSource1;
    }
}