using System.Data.SqlClient;

namespace PABMS
{
    public partial class FormLogin : Form
    {
        SqlConnection connection;
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader reader;
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public int StaffID { get; set; }
        }

        List<User> users = new List<User>();

        

        public User user;
        public bool isLogin = false;

        public FormLogin(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "panha";
            txtPassword.Text = "panha";

            //this.txtUsername.Focus();
            btnLogin.Focus();
            try
            {
                sql_command.CommandText = "SELECT * FROM dbo.tbUser";

                // excute this command
                sql_command.Connection = connection;
                connection.Open();
                reader = sql_command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            while (reader.Read())
            {
                User user = new User();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.StaffID = Convert.ToInt32(reader["StaffID"]);
                users.Add(user);
            }
            connection.Close();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (txtUsername.Text == users[i].Username && txtPassword.Text == users[i].Password)
                {
                    user = users[i];
                    isLogin = true;

                    

                    //MainForm mainForm = new MainForm();
                    //mainForm.Show();

                    this.Hide();
                    //this.Dispose();
                    break;
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
