using PABMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABMS
{
    public partial class FormLogin : Form
    {
        SqlConnection connector = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        List<User> users = new List<User>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //connector = new SqlConnection("Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True");
                
        connector = new SqlConnection("Data Source=ASUS-EXPERTBOOK\\SQLEXPRESS;Initial Catalog=ISADE5G5;Integrated Security=True");
                MessageBox.Show("Successfully connected to the database!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sql_command.CommandText = "SELECT * FROM dbo.tbUser";

            // excute this command
            sql_command.Connection = connector;
            connector.Open();
            reader = sql_command.ExecuteReader();


            while (reader.Read())
            {
                User user = new User();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                users.Add(user);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (textBoxUsername.Text == users[i].Username && textBoxPassword.Text == users[i].Password)
                {
                    MessageBox.Show("Login Successful!");
                    MainForm main_form = new MainForm();
                    main_form.Show();
                    this.Hide();
                    break;
                }
            }
        }
    }
}
