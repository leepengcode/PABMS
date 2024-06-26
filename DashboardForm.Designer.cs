namespace PABMS
{
    partial class DashboardForm
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
            lbCustomer = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lbBus = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lbSatff = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lbTruck = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbCustomer);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(108, 135);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 165);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbCustomer
            // 
            lbCustomer.AutoSize = true;
            lbCustomer.Location = new Point(149, 87);
            lbCustomer.Margin = new Padding(4, 0, 4, 0);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(0, 28);
            lbCustomer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 122);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbBus);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1206, 135);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 165);
            panel2.TabIndex = 2;
            // 
            // lbBus
            // 
            lbBus.AutoSize = true;
            lbBus.Location = new Point(149, 87);
            lbBus.Margin = new Padding(4, 0, 4, 0);
            lbBus.Name = "lbBus";
            lbBus.Size = new Size(0, 28);
            lbBus.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 38);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 1;
            label5.Text = "Bus";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbSatff);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(479, 135);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 165);
            panel3.TabIndex = 3;
            // 
            // lbSatff
            // 
            lbSatff.AutoSize = true;
            lbSatff.Location = new Point(149, 87);
            lbSatff.Margin = new Padding(4, 0, 4, 0);
            lbSatff.Name = "lbSatff";
            lbSatff.Size = new Size(0, 28);
            lbSatff.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(149, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 28);
            label7.TabIndex = 1;
            label7.Text = "Staff";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lbTruck);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(846, 135);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 165);
            panel4.TabIndex = 4;
            // 
            // lbTruck
            // 
            lbTruck.AutoSize = true;
            lbTruck.Location = new Point(149, 87);
            lbTruck.Margin = new Padding(4, 0, 4, 0);
            lbTruck.Name = "lbTruck";
            lbTruck.Size = new Size(0, 28);
            lbTruck.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(137, 38);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 28);
            label9.TabIndex = 1;
            label9.Text = "Truck";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbCustomer;
        private Label label3;
        private Panel panel2;
        private Label lbBus;
        private Label label5;
        private Panel panel3;
        private Label lbSatff;
        private Label label7;
        private Panel panel4;
        private Label lbTruck;
        private Label label9;
    }
}