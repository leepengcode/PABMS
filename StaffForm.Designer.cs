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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            btnSave = new Button();
            btnSearchUpdate = new Button();
            button4 = new Button();
            tlpButtons = new TableLayoutPanel();
            button3 = new Button();
            txtSearchID = new TextBox();
            lstStaff = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitMain = new SplitContainer();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtSalary = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSex = new TextBox();
            label7 = new Label();
            txtStaffID = new TextBox();
            txtPosition = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtFullName = new TextBox();
            dtpHiredDate = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            chkStoppedWork = new CheckBox();
            panel1 = new Panel();
            panelTitle = new Panel();
            tlpButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(105, 10);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 68);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearchUpdate
            // 
            btnSearchUpdate.Anchor = AnchorStyles.None;
            btnSearchUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchUpdate.Location = new Point(449, 10);
            btnSearchUpdate.Margin = new Padding(3, 4, 3, 4);
            btnSearchUpdate.Name = "btnSearchUpdate";
            btnSearchUpdate.Size = new Size(134, 68);
            btnSearchUpdate.TabIndex = 0;
            btnSearchUpdate.Text = "Search";
            btnSearchUpdate.UseVisualStyleBackColor = true;
            btnSearchUpdate.Click += bntLoad_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1138, 10);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(134, 68);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 4;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtons.Controls.Add(btnSave, 0, 0);
            tlpButtons.Controls.Add(btnSearchUpdate, 1, 0);
            tlpButtons.Controls.Add(button3, 2, 0);
            tlpButtons.Controls.Add(button4, 3, 0);
            tlpButtons.Dock = DockStyle.Bottom;
            tlpButtons.Location = new Point(0, 709);
            tlpButtons.Margin = new Padding(3, 4, 3, 4);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(1379, 88);
            tlpButtons.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(793, 10);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(134, 68);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtSearchID
            // 
            txtSearchID.Anchor = AnchorStyles.None;
            txtSearchID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchID.Location = new Point(90, 39);
            txtSearchID.Margin = new Padding(3, 4, 3, 4);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(269, 34);
            txtSearchID.TabIndex = 20;
            // 
            // lstStaff
            // 
            lstStaff.Dock = DockStyle.Fill;
            lstStaff.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstStaff.FormattingEnabled = true;
            lstStaff.ItemHeight = 29;
            lstStaff.Location = new Point(3, 116);
            lstStaff.Margin = new Padding(3, 4, 3, 4);
            lstStaff.Name = "lstStaff";
            lstStaff.Size = new Size(443, 486);
            lstStaff.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lstStaff, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSearchID, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 5, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.54305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.45695F));
            tableLayoutPanel1.Size = new Size(454, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // splitMain
            // 
            splitMain.BorderStyle = BorderStyle.FixedSingle;
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 101);
            splitMain.Margin = new Padding(3, 4, 3, 4);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(panel4);
            splitMain.Size = new Size(1379, 608);
            splitMain.SplitterDistance = 456;
            splitMain.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtSalary);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtPhone);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtAddress);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtSex);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtStaffID);
            panel4.Controls.Add(txtPosition);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtFullName);
            panel4.Controls.Add(dtpHiredDate);
            panel4.Controls.Add(dtpBirthDate);
            panel4.Controls.Add(chkStoppedWork);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(917, 606);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(760, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 10, 10, 0);
            pictureBox1.Size = new Size(135, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 110);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 20, 0);
            label2.Size = new Size(103, 29);
            label2.TabIndex = 73;
            label2.Text = "StaffID";
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.None;
            txtSalary.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(307, 402);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(322, 34);
            txtSalary.TabIndex = 62;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 152);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 20, 0);
            label1.Size = new Size(144, 29);
            label1.TabIndex = 72;
            label1.Text = "Full Name";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(307, 360);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(322, 34);
            txtPhone.TabIndex = 61;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(227, 195);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 20, 0);
            label3.Size = new Size(74, 29);
            label3.TabIndex = 71;
            label3.Text = "Sex";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(307, 318);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(322, 34);
            txtAddress.TabIndex = 60;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(163, 237);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 20, 0);
            label4.Size = new Size(138, 29);
            label4.TabIndex = 70;
            label4.Text = "Birth Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(128, 279);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 20, 0);
            label5.Size = new Size(173, 29);
            label5.TabIndex = 69;
            label5.Text = "Staff Position";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(126, 321);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 20, 0);
            label6.Size = new Size(175, 29);
            label6.TabIndex = 68;
            label6.Text = "Staff Address";
            // 
            // txtSex
            // 
            txtSex.Anchor = AnchorStyles.None;
            txtSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSex.Location = new Point(307, 192);
            txtSex.Margin = new Padding(3, 4, 3, 4);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(322, 34);
            txtSex.TabIndex = 58;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(105, 363);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 20, 0);
            label7.Size = new Size(196, 29);
            label7.TabIndex = 64;
            label7.Text = "Phone Number";
            // 
            // txtStaffID
            // 
            txtStaffID.Anchor = AnchorStyles.None;
            txtStaffID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(307, 107);
            txtStaffID.Margin = new Padding(3, 4, 3, 4);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(322, 34);
            txtStaffID.TabIndex = 57;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.None;
            txtPosition.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosition.Location = new Point(307, 276);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(322, 34);
            txtPosition.TabIndex = 59;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(201, 405);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 20, 0);
            label8.Size = new Size(100, 29);
            label8.TabIndex = 65;
            label8.Text = "Salary";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(153, 447);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 20, 0);
            label9.Size = new Size(148, 29);
            label9.TabIndex = 66;
            label9.Text = "Hired Date";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(86, 485);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 20, 0);
            label10.Size = new Size(215, 29);
            label10.TabIndex = 67;
            label10.Text = "Stopped Worked";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(307, 149);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(322, 34);
            txtFullName.TabIndex = 63;
            // 
            // dtpHiredDate
            // 
            dtpHiredDate.Anchor = AnchorStyles.None;
            dtpHiredDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHiredDate.Location = new Point(307, 444);
            dtpHiredDate.Margin = new Padding(3, 4, 3, 4);
            dtpHiredDate.Name = "dtpHiredDate";
            dtpHiredDate.Size = new Size(322, 34);
            dtpHiredDate.TabIndex = 74;
            dtpHiredDate.UseWaitCursor = true;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.None;
            dtpBirthDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Location = new Point(307, 234);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(322, 34);
            dtpBirthDate.TabIndex = 75;
            dtpBirthDate.UseWaitCursor = true;
            // 
            // chkStoppedWork
            // 
            chkStoppedWork.Anchor = AnchorStyles.None;
            chkStoppedWork.AutoSize = true;
            chkStoppedWork.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            chkStoppedWork.Location = new Point(307, 481);
            chkStoppedWork.Name = "chkStoppedWork";
            chkStoppedWork.Size = new Size(152, 33);
            chkStoppedWork.TabIndex = 76;
            chkStoppedWork.Text = "checkBox1";
            chkStoppedWork.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(splitMain);
            panel1.Controls.Add(panelTitle);
            panel1.Controls.Add(tlpButtons);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1379, 797);
            panel1.TabIndex = 1;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.ForestGreen;
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(3, 4, 3, 4);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1379, 101);
            panelTitle.TabIndex = 0;
            // 
            // StaffForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 797);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            ResizeEnd += StaffForm_ResizeEnd;
            SizeChanged += StaffForm_SizeChanged;
            tlpButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnSearchUpdate;
        private Button button4;
        private TableLayoutPanel tlpButtons;
        private Button button3;
        private TextBox txtSearchID;
        private ListBox lstStaff;
        private TextBox TBCustomerID;
        private TextBox TBTicketID;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitMain;
        private Panel panel1;
        private Panel panelTitle;
        private TextBox textBox2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtSalary;
        private Label label1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSex;
        private Label label7;
        private TextBox txtStaffID;
        private TextBox txtPosition;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtFullName;
        private DateTimePicker dtpHiredDate;
        private DateTimePicker dtpBirthDate;
        private CheckBox chkStoppedWork;
    }
}