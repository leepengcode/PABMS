namespace PABMS
{
    partial class DriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSearchID = new TextBox();
            lstDriver = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtSalary = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSex = new TextBox();
            txtDriverD = new TextBox();
            txtDriverAddress = new TextBox();
            txtFullName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            chkStoppedWork = new CheckBox();
            dtpHiredDate = new DateTimePicker();
            panel3 = new Panel();
            picDriver = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSave = new Button();
            btnSearchUpdate = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDriver).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1406, 759);
            panel1.TabIndex = 2;
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
            splitContainer1.Size = new Size(1406, 570);
            splitContainer1.SplitterDistance = 465;
            splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtSearchID, 0, 0);
            tableLayoutPanel1.Controls.Add(lstDriver, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 5, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.54305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.45695F));
            tableLayoutPanel1.Size = new Size(463, 568);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearchID
            // 
            txtSearchID.Anchor = AnchorStyles.None;
            txtSearchID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchID.Location = new Point(94, 35);
            txtSearchID.Margin = new Padding(3, 4, 3, 4);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(269, 34);
            txtSearchID.TabIndex = 20;
            // 
            // lstDriver
            // 
            lstDriver.Dock = DockStyle.Fill;
            lstDriver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstDriver.FormattingEnabled = true;
            lstDriver.ItemHeight = 29;
            lstDriver.Location = new Point(3, 109);
            lstDriver.Margin = new Padding(3, 4, 3, 4);
            lstDriver.Name = "lstDriver";
            lstDriver.Size = new Size(452, 455);
            lstDriver.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3916F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6084F));
            tableLayoutPanel2.Controls.Add(txtSalary, 1, 6);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtPhoneNumber, 1, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(txtSex, 1, 2);
            tableLayoutPanel2.Controls.Add(txtDriverD, 1, 0);
            tableLayoutPanel2.Controls.Add(txtDriverAddress, 1, 4);
            tableLayoutPanel2.Controls.Add(txtFullName, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpBirthDate, 1, 3);
            tableLayoutPanel2.Controls.Add(label8, 0, 6);
            tableLayoutPanel2.Controls.Add(label9, 0, 7);
            tableLayoutPanel2.Controls.Add(label7, 0, 8);
            tableLayoutPanel2.Controls.Add(chkStoppedWork, 1, 8);
            tableLayoutPanel2.Controls.Add(dtpHiredDate, 1, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 126);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(935, 442);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.Left;
            txtSalary.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(361, 301);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(322, 34);
            txtSalary.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 20, 0);
            label2.Size = new Size(120, 29);
            label2.TabIndex = 32;
            label2.Text = "DriverID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 59);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 20, 0);
            label1.Size = new Size(144, 29);
            label1.TabIndex = 31;
            label1.Text = "Full Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 108);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 20, 0);
            label3.Size = new Size(74, 29);
            label3.TabIndex = 30;
            label3.Text = "Sex";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Left;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(361, 252);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(322, 34);
            txtPhoneNumber.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(217, 157);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 20, 0);
            label4.Size = new Size(138, 29);
            label4.TabIndex = 29;
            label4.Text = "Birth Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(163, 206);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 20, 0);
            label5.Size = new Size(192, 29);
            label5.TabIndex = 28;
            label5.Text = "Driver Address";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(159, 255);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 20, 0);
            label6.Size = new Size(196, 29);
            label6.TabIndex = 27;
            label6.Text = "Phone Number";
            // 
            // txtSex
            // 
            txtSex.Anchor = AnchorStyles.Left;
            txtSex.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSex.Location = new Point(361, 105);
            txtSex.Margin = new Padding(3, 4, 3, 4);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(322, 34);
            txtSex.TabIndex = 2;
            // 
            // txtDriverD
            // 
            txtDriverD.Anchor = AnchorStyles.Left;
            txtDriverD.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDriverD.Location = new Point(361, 7);
            txtDriverD.Margin = new Padding(3, 4, 3, 4);
            txtDriverD.Name = "txtDriverD";
            txtDriverD.Size = new Size(322, 34);
            txtDriverD.TabIndex = 0;
            // 
            // txtDriverAddress
            // 
            txtDriverAddress.Anchor = AnchorStyles.Left;
            txtDriverAddress.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDriverAddress.Location = new Point(361, 203);
            txtDriverAddress.Margin = new Padding(3, 4, 3, 4);
            txtDriverAddress.Name = "txtDriverAddress";
            txtDriverAddress.Size = new Size(322, 34);
            txtDriverAddress.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Left;
            txtFullName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(361, 56);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(322, 34);
            txtFullName.TabIndex = 7;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.Left;
            dtpBirthDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Location = new Point(361, 154);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(322, 34);
            dtpBirthDate.TabIndex = 35;
            dtpBirthDate.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(255, 304);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 20, 0);
            label8.Size = new Size(100, 29);
            label8.TabIndex = 26;
            label8.Text = "Salary";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(207, 353);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 20, 0);
            label9.Size = new Size(148, 29);
            label9.TabIndex = 26;
            label9.Text = "Hired Date";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(168, 402);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 20, 0);
            label7.Size = new Size(187, 29);
            label7.TabIndex = 26;
            label7.Text = "Stopped Work";
            // 
            // chkStoppedWork
            // 
            chkStoppedWork.AutoSize = true;
            chkStoppedWork.Location = new Point(361, 395);
            chkStoppedWork.Name = "chkStoppedWork";
            chkStoppedWork.Size = new Size(101, 24);
            chkStoppedWork.TabIndex = 36;
            chkStoppedWork.Text = "checkBox1";
            chkStoppedWork.UseVisualStyleBackColor = true;
            // 
            // dtpHiredDate
            // 
            dtpHiredDate.Anchor = AnchorStyles.Left;
            dtpHiredDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHiredDate.Location = new Point(361, 350);
            dtpHiredDate.Margin = new Padding(3, 4, 3, 4);
            dtpHiredDate.Name = "dtpHiredDate";
            dtpHiredDate.Size = new Size(322, 34);
            dtpHiredDate.TabIndex = 33;
            dtpHiredDate.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(picDriver);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(935, 126);
            panel3.TabIndex = 1;
            // 
            // picDriver
            // 
            picDriver.Dock = DockStyle.Right;
            picDriver.Image = (Image)resources.GetObject("picDriver.Image");
            picDriver.InitialImage = (Image)resources.GetObject("picDriver.InitialImage");
            picDriver.Location = new Point(800, 0);
            picDriver.Name = "picDriver";
            picDriver.Padding = new Padding(0, 10, 10, 0);
            picDriver.Size = new Size(135, 126);
            picDriver.SizeMode = PictureBoxSizeMode.StretchImage;
            picDriver.TabIndex = 36;
            picDriver.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1406, 101);
            panel2.TabIndex = 0;
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
            tableLayoutPanel3.Location = new Point(0, 671);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1406, 88);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(108, 10);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 68);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearchUpdate
            // 
            btnSearchUpdate.Anchor = AnchorStyles.None;
            btnSearchUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchUpdate.Location = new Point(459, 10);
            btnSearchUpdate.Margin = new Padding(3, 4, 3, 4);
            btnSearchUpdate.Name = "btnSearchUpdate";
            btnSearchUpdate.Size = new Size(134, 68);
            btnSearchUpdate.TabIndex = 0;
            btnSearchUpdate.Text = "Search";
            btnSearchUpdate.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(810, 10);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(134, 68);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1162, 10);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(134, 68);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // DriverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 759);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DriverForm";
            Text = "VehicleForm";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDriver).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSearchID;
        private ListBox lstDriver;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSex;
        private TextBox txtDriverD;
        private TextBox txtDriverAddress;
        private Label label8;
        private Label label9;
        private TextBox txtFullName;
        private DateTimePicker dtpHiredDate;
        private DateTimePicker dtpBirthDate;
        private Panel panel3;
        private PictureBox picDriver;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSave;
        private Button btnSearchUpdate;
        private Button button3;
        private Button button4;
        private Label label7;
        private CheckBox chkStoppedWork;
        private TextBox txtSalary;
    }
}