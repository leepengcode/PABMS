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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSearch = new TextBox();
            lstTicket = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            TicketID = new Label();
            txtRouteID = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBusID = new TextBox();
            txtTicketID = new TextBox();
            dtpDepartureDate = new DateTimePicker();
            dtpPurchaseDate = new DateTimePicker();
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
            panel1.Size = new Size(1397, 749);
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
            splitContainer1.Size = new Size(1397, 560);
            splitContainer1.SplitterDistance = 462;
            splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(lstTicket, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
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
            lstTicket.Dock = DockStyle.Fill;
            lstTicket.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstTicket.FormattingEnabled = true;
            lstTicket.ItemHeight = 29;
            lstTicket.Location = new Point(3, 107);
            lstTicket.Margin = new Padding(3, 4, 3, 4);
            lstTicket.Name = "lstTicket";
            lstTicket.Size = new Size(449, 447);
            lstTicket.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3916F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6084F));
            tableLayoutPanel2.Controls.Add(TicketID, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(txtTicketID, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpPurchaseDate, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpDepartureDate, 1, 2);
            tableLayoutPanel2.Controls.Add(txtRouteID, 1, 3);
            tableLayoutPanel2.Controls.Add(txtBusID, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(929, 558);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TicketID
            // 
            TicketID.Anchor = AnchorStyles.Right;
            TicketID.AutoSize = true;
            TicketID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TicketID.Location = new Point(231, 41);
            TicketID.Name = "TicketID";
            TicketID.Padding = new Padding(0, 0, 20, 0);
            TicketID.Size = new Size(122, 29);
            TicketID.TabIndex = 32;
            TicketID.Text = "TicketID";
            // 
            // txtRouteID
            // 
            txtRouteID.Anchor = AnchorStyles.Left;
            txtRouteID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRouteID.Location = new Point(359, 371);
            txtRouteID.Margin = new Padding(3, 4, 3, 4);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.Size = new Size(322, 34);
            txtRouteID.TabIndex = 7;
            txtRouteID.TextChanged += txtSalary_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 152);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 20, 0);
            label1.Size = new Size(190, 29);
            label1.TabIndex = 31;
            label1.Text = "Purchace Date";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(157, 263);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 20, 0);
            label3.Size = new Size(196, 29);
            label3.TabIndex = 30;
            label3.Text = "Departure Date";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 374);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 20, 0);
            label4.Size = new Size(126, 29);
            label4.TabIndex = 29;
            label4.Text = "Route ID";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(250, 486);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 20, 0);
            label5.Size = new Size(103, 29);
            label5.TabIndex = 28;
            label5.Text = "Bus ID";
            // 
            // txtBusID
            // 
            txtBusID.Anchor = AnchorStyles.Left;
            txtBusID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusID.Location = new Point(359, 484);
            txtBusID.Margin = new Padding(3, 4, 3, 4);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(322, 34);
            txtBusID.TabIndex = 2;
            // 
            // txtTicketID
            // 
            txtTicketID.Anchor = AnchorStyles.Left;
            txtTicketID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTicketID.Location = new Point(359, 38);
            txtTicketID.Margin = new Padding(3, 4, 3, 4);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(322, 34);
            txtTicketID.TabIndex = 0;
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Anchor = AnchorStyles.Left;
            dtpDepartureDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDepartureDate.Location = new Point(359, 260);
            dtpDepartureDate.Margin = new Padding(3, 4, 3, 4);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new Size(322, 34);
            dtpDepartureDate.TabIndex = 33;
            dtpDepartureDate.UseWaitCursor = true;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Anchor = AnchorStyles.Left;
            dtpPurchaseDate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPurchaseDate.Location = new Point(359, 149);
            dtpPurchaseDate.Margin = new Padding(3, 4, 3, 4);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(322, 34);
            dtpPurchaseDate.TabIndex = 35;
            dtpPurchaseDate.UseWaitCursor = true;
            dtpPurchaseDate.ValueChanged += dtpBirthDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1397, 101);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
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
            tableLayoutPanel3.Location = new Point(0, 661);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1397, 88);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(107, 10);
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
            btnSearchUpdate.Location = new Point(456, 10);
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
            button3.Location = new Point(805, 10);
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
            button4.Location = new Point(1155, 10);
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
            ClientSize = new Size(1397, 749);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketForm";
            Text = "TicketForm";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSearch;
        private ListBox lstTicket;
        private TableLayoutPanel tableLayoutPanel2;
        private Label TicketID;
        private TextBox txtRouteID;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBusID;
        private TextBox txtTicketID;
        private DateTimePicker dtpDepartureDate;
        private DateTimePicker dtpPurchaseDate;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSave;
        private Button btnSearchUpdate;
        private Button button3;
        private Button button4;
    }
}