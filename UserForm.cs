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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PABMS
{

    public partial class UserForm : Form
    {
        string connectionString;
        public UserForm(SqlConnection connection)
        {
            InitializeComponent();
            connectionString = connection.ConnectionString;
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbUser", connectionString))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridSearch.DataSource = table;
            }
        }

        private void showUsers()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbUser", connectionString))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridSearch.DataSource = table;
                return;
            }
            //LoadLatestUserID();
        }

        private void searchUserByID()
        {

            if (!int.TryParse(txtSearch.Text, out int userID))
            {
                //showUsers();
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("spSearchUserByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", userID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);

                            if (table.Rows.Count > 0)
                            {
                                gridSearch.DataSource = table;
                            }
                            else
                            {
                                MessageBox.Show("Did not find User with ID: " + userID);
                                showUsers();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void insertUser()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int staffID = int.Parse(txtStaffID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertCommandText = @"
                INSERT INTO tbUser (Username, Password, StaffID)
                VALUES (@Username, @Password, @StaffID)";

                using (SqlCommand command = new SqlCommand(insertCommandText, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@StaffID", staffID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("User inserted successfully.");
                        LoadLatestUserID();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    showUsers();
                }
            }
        }

        private void UpdateUser()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int staffID = int.Parse(txtStaffID.Text);
            int userID = int.Parse(txtUserID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateCommandText = @"
                UPDATE tbUser
                SET Username = @Username,
                    Password = @Password,
                    StaffID = @StaffID
                WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(updateCommandText, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@StaffID", staffID);
                    command.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.");

                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                        showUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void LoadUserStaffDetails(int staffID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        tbUser.UserID,
                        tbUser.Username,
                        tbUser.Password,
                        tbStaff.StaffID,
                        tbStaff.FullName,
                        tbStaff.PhoneNumber
                    FROM 
	                    tbUser
                    INNER JOIN 
                        tbStaff ON tbStaff.StaffID = @staffID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@staffID", staffID);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        txtStaffID.Text = dataTable.Rows[0]["StaffID"].ToString();
                        txtStaffName.Text = dataTable.Rows[0]["FullName"].ToString();
                        txtStaffTel.Text = dataTable.Rows[0]["PhoneNumber"].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchUserByID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertUser();
            ClearForm();
        }

        private void gridSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbUser", connectionString))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0 && index > -1)
                {
                    txtUserID.Text = table.Rows[index]["UserID"].ToString();
                    txtUsername.Text = table.Rows[index]["Username"].ToString();
                    txtPassword.Text = table.Rows[index]["Password"].ToString();
                    txtStaffID.Text = table.Rows[index]["StaffID"].ToString();
                }
                int staffID = int.Parse(txtStaffID.Text);
                LoadUserStaffDetails(staffID);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser();
            ClearForm();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateCommandText = @"
                    SELECT 
                        StaffID, FullName, PhoneNumber
                    FROM 
                        tbStaff 
                    WHERE 
                        FullName LIKE @Name;
                    ";

                using (SqlCommand command = new SqlCommand(updateCommandText, connection))
                {
                    command.Parameters.AddWithValue("@Name", "%" + txtStaffName.Text + "%");
                    // message box command's final sql
                    //MessageBox.Show(command.CommandText);

                    try
                    {
                        connection.Open();
                        DataTable table = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            table.Load(reader);
                        }
                        if (table.Rows.Count > 0)
                        {
                            txtStaffID.Text = table.Rows[0]["StaffID"].ToString();
                            txtStaffName.Text = table.Rows[0]["FullName"].ToString();
                            txtStaffTel.Text = table.Rows[0]["PhoneNumber"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Staff not found.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
        private void LoadLatestUserID()
        {
            int latestUserID = GetLatestUserID();
            txtUserID.Text = (latestUserID + 1).ToString();
        }

        private int GetLatestUserID()
        {
            int latestUserID = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(UserID), 0) FROM tbUser";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestUserID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching latest user ID: " + ex.Message);
                }
            }

            return latestUserID;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadLatestUserID();
        }

        private void ClearForm()
        {
            txtPassword.Clear();
            txtSearch.Clear();
            txtStaffID.Clear();
            txtStaffTel.Clear();
            txtStaffName.Clear();
            txtUsername.Clear();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLatestUserID();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

