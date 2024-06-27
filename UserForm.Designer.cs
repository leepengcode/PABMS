namespace PABMS
{
    partial class UserForm
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
            txtPassword = new TextBox();
            label6 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtStaffID = new TextBox();
            label2 = new Label();
            label14 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            gridSearch = new DataGridView();
            txtUserID = new TextBox();
            label4 = new Label();
            txtStaffName = new TextBox();
            txtStaffTel = new TextBox();
            label5 = new Label();
            label7 = new Label();
            btnSearchStaff = new Button();
            ((System.ComponentModel.ISupportInitialize)gridSearch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(708, 60);
            label1.Name = "label1";
            label1.Size = new Size(186, 36);
            label1.TabIndex = 3;
            label1.Text = "User's Form";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(439, 325);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 39;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(302, 327);
            label6.Name = "label6";
            label6.Size = new Size(120, 29);
            label6.TabIndex = 38;
            label6.Text = "Password";
            
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(439, 269);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 34);
            txtUsername.TabIndex = 37;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(302, 274);
            label3.Name = "label3";
            label3.Size = new Size(124, 29);
            label3.TabIndex = 36;
            label3.Text = "Username";
            
            // 
            // txtStaffID
            // 
            txtStaffID.BorderStyle = BorderStyle.FixedSingle;
            txtStaffID.Enabled = false;
            txtStaffID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(876, 211);
            txtStaffID.Multiline = true;
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(250, 34);
            txtStaffID.TabIndex = 41;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(739, 216);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 40;
            label2.Text = "Staff ID";
            
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(302, 444);
            label14.Name = "label14";
            label14.Size = new Size(89, 29);
            label14.TabIndex = 52;
            label14.Text = "Search";
            
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(192, 255, 255);
            btnNew.Location = new Point(1196, 779);
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
            btnUpdate.Location = new Point(883, 779);
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
            btnSearch.Location = new Point(560, 779);
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
            btnSave.Location = new Point(278, 779);
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
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(439, 442);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 34);
            txtSearch.TabIndex = 46;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // gridSearch
            // 
            gridSearch.AllowUserToAddRows = false;
            gridSearch.AllowUserToDeleteRows = false;
            gridSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSearch.Location = new Point(302, 527);
            gridSearch.Name = "gridSearch";
            gridSearch.ReadOnly = true;
            gridSearch.RowHeadersWidth = 51;
            gridSearch.RowTemplate.Height = 29;
            gridSearch.Size = new Size(1004, 188);
            gridSearch.TabIndex = 53;
            gridSearch.CellClick += gridSearch_CellClick;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = SystemColors.ButtonHighlight;
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Enabled = false;
            txtUserID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(439, 214);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(250, 34);
            txtUserID.TabIndex = 36;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(302, 219);
            label4.Name = "label4";
            label4.Size = new Size(93, 29);
            label4.TabIndex = 36;
            label4.Text = "User ID";
            
            // 
            // txtStaffName
            // 
            txtStaffName.BorderStyle = BorderStyle.FixedSingle;
            txtStaffName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(876, 268);
            txtStaffName.Multiline = true;
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(250, 34);
            txtStaffName.TabIndex = 41;
            
            // 
            // txtStaffTel
            // 
            txtStaffTel.BorderStyle = BorderStyle.FixedSingle;
            txtStaffTel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffTel.Location = new Point(876, 325);
            txtStaffTel.Multiline = true;
            txtStaffTel.Name = "txtStaffTel";
            txtStaffTel.Size = new Size(250, 34);
            txtStaffTel.TabIndex = 41;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(739, 268);
            label5.Name = "label5";
            label5.Size = new Size(131, 29);
            label5.TabIndex = 40;
            label5.Text = "Staff Name";
            
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(739, 330);
            label7.Name = "label7";
            label7.Size = new Size(102, 29);
            label7.TabIndex = 40;
            label7.Text = "Staff Tel";
            
            // 
            // btnSearchStaff
            // 
            btnSearchStaff.BackColor = SystemColors.ActiveCaption;
            btnSearchStaff.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchStaff.Location = new Point(1132, 269);
            btnSearchStaff.Name = "btnSearchStaff";
            btnSearchStaff.Size = new Size(174, 34);
            btnSearchStaff.TabIndex = 49;
            btnSearchStaff.Text = "SEARCH STAFF";
            btnSearchStaff.UseVisualStyleBackColor = false;
            btnSearchStaff.Click += btnSearchStaff_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 878);
            Controls.Add(gridSearch);
            Controls.Add(label14);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearchStaff);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(txtStaffTel);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffID);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtUserID);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtStaffID;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label14;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnSave;
        private DataGridView gridSearch;
        private TextBox txtUserID;
        private Label label4;
        private TextBox txtStaffName;
        private TextBox txtStaffTel;
        private Label label5;
        private Label label7;
        private Button btnSearchStaff;
    }
}