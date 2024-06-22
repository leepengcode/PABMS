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
            textBox4 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label14 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            textBox14 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Heebo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(708, 60);
            label1.Name = "label1";
            label1.Size = new Size(187, 44);
            label1.TabIndex = 3;
            label1.Text = "User's Form";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(483, 267);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(674, 44);
            textBox4.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(346, 281);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 38;
            label6.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(483, 186);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(674, 44);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 200);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 36;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(483, 344);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(674, 44);
            textBox1.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(346, 358);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 40;
            label2.Text = "Staff ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(196, 455);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 52;
            label14.Text = "Search";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.Location = new Point(1196, 779);
            button4.Name = "button4";
            button4.Size = new Size(152, 50);
            button4.TabIndex = 51;
            button4.Text = "NEW";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(883, 779);
            button3.Name = "button3";
            button3.Size = new Size(152, 50);
            button3.TabIndex = 50;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(560, 779);
            button2.Name = "button2";
            button2.Size = new Size(152, 50);
            button2.TabIndex = 49;
            button2.Text = "SEARCH";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(278, 779);
            button1.Name = "button1";
            button1.Size = new Size(152, 50);
            button1.TabIndex = 48;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(193, 506);
            listView1.Name = "listView1";
            listView1.Size = new Size(1226, 244);
            listView1.TabIndex = 47;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox14
            // 
            textBox14.BorderStyle = BorderStyle.FixedSingle;
            textBox14.Location = new Point(327, 443);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(664, 47);
            textBox14.TabIndex = 46;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 878);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBox14);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label14;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private TextBox textBox14;
    }
}