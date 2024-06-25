using System.Data.SqlClient;

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

        public string username;
        public bool isLogin = false;

        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void MainForm_FormClosed(string data)
        {
            MessageBox.Show($"Data received: {data}");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
            try
            {
                connector = new SqlConnection("Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True;");
                //connector = new SqlConnection("Data Source=ASUS-EXPERTBOOK\\SQLEXPRESS;Initial Catalog=ISADE5G5;Integrated Security=True;");
                sql_command.CommandText = "SELECT * FROM dbo.tbUser";

                // excute this command
                sql_command.Connection = connector;
                connector.Open();
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
                users.Add(user);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (txtUsername.Text == users[i].Username && txtPassword.Text == users[i].Password)
                {
                    username = users[i].Username;

                    isLogin = true;

                    //MainForm mainForm = new MainForm();
                    //mainForm.Show();

                    this.Hide();
                    //this.Dispose();
                    break;
                }
            }
        }
    }
}
