namespace PABMS
{
    partial class TicketForm
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
            panel1 = new Panel();
            splitMain = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSearch = new TextBox();
            lstTicket = new ListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            txtBusID = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            txtRouteID = new TextBox();
            dtpDepartureDate = new DateTimePicker();
            label10 = new Label();
            dtpPurchaseDate = new DateTimePicker();
            label9 = new Label();
            txtTicketID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label8 = new Label();
            label2 = new Label();
            panelTitle = new Panel();
            tlpButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnSearchUpdate = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(splitMain);
            panel1.Controls.Add(panelTitle);
            panel1.Controls.Add(tlpButtons);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1397, 866);
            panel1.TabIndex = 2;
            // 
            // splitMain
            // 
            splitMain.BorderStyle = BorderStyle.FixedSingle;
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
            splitMain.Panel2.Controls.Add(textBox2);
            splitMain.Panel2.Controls.Add(textBox1);
            splitMain.Panel2.Controls.Add(textBox3);
            splitMain.Panel2.Controls.Add(txtBusID);
            splitMain.Panel2.Controls.Add(textBox5);
            splitMain.Panel2.Controls.Add(textBox4);
            splitMain.Panel2.Controls.Add(txtRouteID);
            splitMain.Panel2.Controls.Add(dtpDepartureDate);
            splitMain.Panel2.Controls.Add(label10);
            splitMain.Panel2.Controls.Add(dtpPurchaseDate);
            splitMain.Panel2.Controls.Add(label9);
            splitMain.Panel2.Controls.Add(txtTicketID);
            splitMain.Panel2.Controls.Add(label5);
            splitMain.Panel2.Controls.Add(label4);
            splitMain.Panel2.Controls.Add(label3);
            splitMain.Panel2.Controls.Add(label7);
            splitMain.Panel2.Controls.Add(label1);
            splitMain.Panel2.Controls.Add(label6);
            splitMain.Panel2.Controls.Add(label8);
            splitMain.Panel2.Controls.Add(label2);
            splitMain.Panel2.Paint += splitMain_Panel2_Paint;
            splitMain.Size = new Size(1397, 685);
            splitMain.SplitterDistance = 462;
            splitMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(lstTicket, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 5, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.54305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.45695F));
            tableLayoutPanel1.Size = new Size(460, 558);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(93, 34);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(269, 34);
            txtSearch.TabIndex = 20;
            // 
            // lstTicket
            // 
            lstTicket.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstTicket.FormattingEnabled = true;
            lstTicket.ItemHeight = 29;
            lstTicket.Location = new Point(3, 107);
            lstTicket.Margin = new Padding(3, 4, 3, 4);
            lstTicket.Name = "lstTicket";
            lstTicket.Size = new Size(449, 439);
            lstTicket.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(445, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 34);
            textBox2.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(445, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 34);
            textBox1.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(445, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 34);
            textBox3.TabIndex = 46;
            // 
            // txtBusID
            // 
            txtBusID.Anchor = AnchorStyles.None;
            txtBusID.Enabled = false;
            txtBusID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusID.Location = new Point(445, 224);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(322, 34);
            txtBusID.TabIndex = 46;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(445, 570);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(322, 34);
            textBox5.TabIndex = 48;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(445, 522);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 34);
            textBox4.TabIndex = 48;
            // 
            // txtRouteID
            // 
            txtRouteID.Anchor = AnchorStyles.None;
            txtRouteID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRouteID.Location = new Point(445, 469);
            txtRouteID.Margin = new Padding(3, 4, 3, 4);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.Size = new Size(322, 34);
            txtRouteID.TabIndex = 48;
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Anchor = AnchorStyles.None;
            dtpDepartureDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDepartureDate.Location = new Point(445, 412);
            dtpDepartureDate.Margin = new Padding(3, 4, 3, 4);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new Size(322, 34);
            dtpDepartureDate.TabIndex = 54;
            dtpDepartureDate.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(186, 575);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 20, 0);
            label10.Size = new Size(151, 29);
            label10.TabIndex = 50;
            label10.Text = "Staff Name";
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Anchor = AnchorStyles.None;
            dtpPurchaseDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPurchaseDate.Location = new Point(445, 335);
            dtpPurchaseDate.Margin = new Padding(3, 4, 3, 4);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(322, 34);
            dtpPurchaseDate.TabIndex = 55;
            dtpPurchaseDate.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(186, 527);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 20, 0);
            label9.Size = new Size(109, 29);
            label9.TabIndex = 50;
            label9.Text = "Staff ID";
            // 
            // txtTicketID
            // 
            txtTicketID.Anchor = AnchorStyles.None;
            txtTicketID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTicketID.Location = new Point(445, 44);
            txtTicketID.Margin = new Padding(3, 4, 3, 4);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(322, 34);
            txtTicketID.TabIndex = 47;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(186, 474);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 20, 0);
            label5.Size = new Size(126, 29);
            label5.TabIndex = 50;
            label5.Text = "Route ID";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(186, 412);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 20, 0);
            label4.Size = new Size(196, 29);
            label4.TabIndex = 51;
            label4.Text = "Departure Date";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(186, 335);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 20, 0);
            label3.Size = new Size(190, 29);
            label3.TabIndex = 52;
            label3.Text = "Purchace Date";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(186, 166);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 20, 0);
            label7.Size = new Size(245, 29);
            label7.TabIndex = 49;
            label7.Text = "Customer PhoneNo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 44);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 20, 0);
            label1.Size = new Size(122, 29);
            label1.TabIndex = 53;
            label1.Text = "TicketID";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(186, 114);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 20, 0);
            label6.Size = new Size(166, 29);
            label6.TabIndex = 49;
            label6.Text = "Customer ID";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(186, 269);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 20, 0);
            label8.Size = new Size(167, 29);
            label8.TabIndex = 49;
            label8.Text = "Bus Number";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 224);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 20, 0);
            label2.Size = new Size(103, 29);
            label2.TabIndex = 49;
            label2.Text = "Bus ID";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.ForestGreen;
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(3, 4, 3, 4);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1397, 101);
            panelTitle.TabIndex = 0;
            panelTitle.Paint += panel2_Paint;
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
            tlpButtons.Location = new Point(0, 786);
            tlpButtons.Margin = new Padding(3, 4, 3, 4);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(1397, 80);
            tlpButtons.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(107, 6);
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
            btnSearchUpdate.Location = new Point(456, 6);
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
            button3.Location = new Point(805, 6);
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
            button4.Location = new Point(1155, 6);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(134, 68);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 863);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketForm";
            Text = "TicketForm";
            Load += TicketForm_Load;
            DockChanged += TicketForm_DockChanged;
            SizeChanged += TicketForm_SizeChanged;
            panel1.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            splitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitMain;
        private Panel panelTitle;
        private TableLayoutPanel tlpButtons;
        private Button btnSave;
        private Button btnSearchUpdate;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSearch;
        private ListBox lstTicket;
        private TextBox txtBusID;
        private TextBox txtRouteID;
        private DateTimePicker dtpDepartureDate;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtTicketID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label10;
        private Label label9;
    }
}