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
            Nation = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            SeatNo = new DataGridViewTextBoxColumn();
            DepartureTime = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Trip = new DataGridViewTextBoxColumn();
            TicketNo = new DataGridViewTextBoxColumn();
            TiketID = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Nation
            // 
            Nation.HeaderText = "Nation";
            Nation.MinimumWidth = 6;
            Nation.Name = "Nation";
            Nation.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // SeatNo
            // 
            SeatNo.HeaderText = "SeatNo";
            SeatNo.MinimumWidth = 6;
            SeatNo.Name = "SeatNo";
            SeatNo.Width = 125;
            // 
            // DepartureTime
            // 
            DepartureTime.HeaderText = "DepartureTime";
            DepartureTime.MinimumWidth = 6;
            DepartureTime.Name = "DepartureTime";
            DepartureTime.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Trip
            // 
            Trip.HeaderText = "Trip";
            Trip.MinimumWidth = 6;
            Trip.Name = "Trip";
            Trip.Width = 125;
            // 
            // TicketNo
            // 
            TicketNo.HeaderText = "TicketNo";
            TicketNo.MinimumWidth = 6;
            TicketNo.Name = "TicketNo";
            TicketNo.Width = 125;
            // 
            // TiketID
            // 
            TiketID.HeaderText = "TiketID";
            TiketID.MinimumWidth = 6;
            TiketID.Name = "TiketID";
            TiketID.ReadOnly = true;
            TiketID.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TiketID, TicketNo, Trip, Date, DepartureTime, SeatNo, Price, Nation });
            dataGridView1.Location = new Point(57, 310);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(861, 305);
            dataGridView1.TabIndex = 1;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 626);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicketForm";
            Text = "TicketForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn Nation;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn SeatNo;
        private DataGridViewTextBoxColumn DepartureTime;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Trip;
        private DataGridViewTextBoxColumn TicketNo;
        private DataGridViewTextBoxColumn TiketID;
        private DataGridView dataGridView1;
    }
}