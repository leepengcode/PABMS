namespace PABMS
{
    partial class FormLogin
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            btnLogin = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(154, 111);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 0;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(348, 267);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(152, 52);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 187);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 0;
            label1.Text = "Password";
            label1.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(348, 181);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 38);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(348, 102);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(299, 38);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(630, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 429);
            panel1.TabIndex = 4;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1525, 826);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Button btnLogin;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Panel panel1;
    }
}