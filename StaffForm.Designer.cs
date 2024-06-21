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
            tableLayoutPanel3 = new TableLayoutPanel();
            button3 = new Button();
            label2 = new Label();
            txtSalary = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtSearchID = new TextBox();
            LBPayment = new ListBox();
            label5 = new Label();
            label6 = new Label();
            txtSex = new TextBox();
            label7 = new Label();
            txtStaffID = new TextBox();
            txtPosition = new TextBox();
            label8 = new Label();
            dtpHiredDate = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            txtFullName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            chkStoppedWork = new CheckBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(101, 10);
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
            btnSearchUpdate.Location = new Point(437, 10);
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
            button4.Location = new Point(1110, 10);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(134, 68);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel3.Controls.Add(btnSearchUpdate, 1, 0);
            tableLayoutPanel3.Controls.Add(button3, 2, 0);
            tableLayoutPanel3.Controls.Add(button4, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 709);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1347, 88);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(773, 10);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(134, 68);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(237, 8);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 20, 0);
            label2.Size = new Size(103, 29);
            label2.TabIndex = 32;
            label2.Text = "StaffID";
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.Left;
            txtSalary.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(346, 328);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(322, 34);
            txtSalary.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 54);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 20, 0);
            label1.Size = new Size(144, 29);
            label1.TabIndex = 31;
            label1.Text = "Full Name";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left;
            txtPhone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(346, 282);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(322, 34);
            txtPhone.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(266, 100);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 20, 0);
            label3.Size = new Size(74, 29);
            label3.TabIndex = 30;
            label3.Text = "Sex";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left;
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(346, 236);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(322, 34);
            txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(202, 146);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 20, 0);
            label4.Size = new Size(138, 29);
            label4.TabIndex = 29;
            label4.Text = "Birth Date";
            // 
            // txtSearchID
            // 
            txtSearchID.Anchor = AnchorStyles.None;
            txtSearchID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchID.Location = new Point(85, 39);
            txtSearchID.Margin = new Padding(3, 4, 3, 4);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(269, 34);
            txtSearchID.TabIndex = 20;
            // 
            // LBPayment
            // 
            LBPayment.Dock = DockStyle.Fill;
            LBPayment.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LBPayment.FormattingEnabled = true;
            LBPayment.ItemHeight = 29;
            LBPayment.Location = new Point(3, 116);
            LBPayment.Margin = new Padding(3, 4, 3, 4);
            LBPayment.Name = "LBPayment";
            LBPayment.Size = new Size(433, 486);
            LBPayment.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(167, 192);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 20, 0);
            label5.Size = new Size(173, 29);
            label5.TabIndex = 28;
            label5.Text = "Staff Position";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(165, 238);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 20, 0);
            label6.Size = new Size(175, 29);
            label6.TabIndex = 27;
            label6.Text = "Staff Address";
            // 
            // txtSex
            // 
            txtSex.Anchor = AnchorStyles.Left;
            txtSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSex.Location = new Point(346, 98);
            txtSex.Margin = new Padding(3, 4, 3, 4);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(322, 34);
            txtSex.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(144, 284);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 20, 0);
            label7.Size = new Size(196, 29);
            label7.TabIndex = 26;
            label7.Text = "Phone Number";
            // 
            // txtStaffID
            // 
            txtStaffID.Anchor = AnchorStyles.Left;
            txtStaffID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(346, 6);
            txtStaffID.Margin = new Padding(3, 4, 3, 4);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(322, 34);
            txtStaffID.TabIndex = 0;
            // 
            // txtPosition
            // 
            txtPosition.Anchor = AnchorStyles.Left;
            txtPosition.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPosition.Location = new Point(346, 190);
            txtPosition.Margin = new Padding(3, 4, 3, 4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(322, 34);
            txtPosition.TabIndex = 4;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(240, 330);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 20, 0);
            label8.Size = new Size(100, 29);
            label8.TabIndex = 26;
            label8.Text = "Salary";
            // 
            // dtpHiredDate
            // 
            dtpHiredDate.Anchor = AnchorStyles.Left;
            dtpHiredDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHiredDate.Location = new Point(346, 374);
            dtpHiredDate.Margin = new Padding(3, 4, 3, 4);
            dtpHiredDate.Name = "dtpHiredDate";
            dtpHiredDate.Size = new Size(322, 34);
            dtpHiredDate.TabIndex = 33;
            dtpHiredDate.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtSearchID, 0, 0);
            tableLayoutPanel1.Controls.Add(LBPayment, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 5, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.54305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.45695F));
            tableLayoutPanel1.Size = new Size(444, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 101);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1347, 608);
            splitContainer1.SplitterDistance = 446;
            splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3916F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6084F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSalary, 1, 7);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(txtPhone, 1, 6);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtAddress, 1, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(txtSex, 1, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Controls.Add(txtStaffID, 1, 0);
            tableLayoutPanel2.Controls.Add(txtPosition, 1, 4);
            tableLayoutPanel2.Controls.Add(label8, 0, 7);
            tableLayoutPanel2.Controls.Add(label9, 0, 8);
            tableLayoutPanel2.Controls.Add(label10, 0, 9);
            tableLayoutPanel2.Controls.Add(txtFullName, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpHiredDate, 1, 8);
            tableLayoutPanel2.Controls.Add(dtpBirthDate, 1, 3);
            tableLayoutPanel2.Controls.Add(chkStoppedWork, 1, 9);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 126);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 11;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(895, 480);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(192, 376);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 20, 0);
            label9.Size = new Size(148, 29);
            label9.TabIndex = 26;
            label9.Text = "Hired Date";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(125, 422);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 20, 0);
            label10.Size = new Size(215, 29);
            label10.TabIndex = 26;
            label10.Text = "Stopped Worked";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Left;
            txtFullName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(346, 52);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(322, 34);
            txtFullName.TabIndex = 7;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.Left;
            dtpBirthDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Location = new Point(346, 144);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(322, 34);
            dtpBirthDate.TabIndex = 35;
            dtpBirthDate.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(895, 126);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(760, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 10, 10, 0);
            pictureBox1.Size = new Size(135, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 797);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1347, 101);
            panel2.TabIndex = 0;
            // 
            // chkStoppedWork
            // 
            chkStoppedWork.AutoSize = true;
            chkStoppedWork.Location = new Point(346, 417);
            chkStoppedWork.Name = "chkStoppedWork";
            chkStoppedWork.Size = new Size(101, 24);
            chkStoppedWork.TabIndex = 36;
            chkStoppedWork.Text = "checkBox1";
            chkStoppedWork.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 797);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffForm";
            Text = "StaffForm";
            SizeChanged += StaffForm_SizeChanged;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnSearchUpdate;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Label label2;
        private TextBox txtSalary;
        private Label label1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtSearchID;
        private ListBox LBPayment;
        private Label label5;
        private TextBox TBCustomerID;
        private Label label6;
        private TextBox txtSex;
        private TextBox TBTicketID;
        private Label label7;
        private TextBox txtStaffID;
        private TextBox txtPosition;
        private Label label8;
        private DateTimePicker dtpHiredDate;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private TextBox txtFullName;
        private Label label10;
        private TextBox textBox2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private DateTimePicker dtpBirthDate;
        private CheckBox chkStoppedWork;
    }
}