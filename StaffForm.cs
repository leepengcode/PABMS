using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PABMS
{
    public partial class StaffForm : Form
    {
        private string connectionString = "Server=ASUS-EXPERTBOOK\\SQLEXPRESS;Database=PABMS_DB;Integrated Security=True;";

        public StaffForm()
        {
            InitializeComponent();
            LoadNextStaffID(); // Load the next available StaffID when the form is initialized

        }

        private void LoadNextStaffID()
        {
            string query = "SELECT MAX(StaffID) FROM tbStaff";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int nextID = Convert.ToInt32(result) + 1;
                            txtStaffID.Text = nextID.ToString();
                        }
                        else
                        {
                            txtStaffID.Text = "1";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving StaffID: " + ex.Message);
                    }
                }
            }
        }

        private void SaveStaffData()
        {
            // Validate all fields before saving
            if (ValidateFields())
            {
                string staffID = txtStaffID.Text;
                string fullName = txtFullName.Text;
                string sex = txtSex.Text; // Assuming txtSex is the TextBox for Sex
                DateTime dateBirth = dtpDateBirth.Value;
                string position = txtPosition.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;
                decimal salary = decimal.Parse(txtSalary.Text);
                DateTime hiredDate = dtpHiredDate.Value;
                DateTime? stoppedDate = dtpStoppedDate.Checked ? dtpStoppedDate.Value : (DateTime?)null;

                string query = "INSERT INTO tbStaff (StaffID, FullName, Sex, DateBirth, Position, Address, Phone, Salary, HiredDate, StopedDate) " +
                               "VALUES (@StaffID, @FullName, @Sex, @DateBirth, @Position, @Address, @Phone, @Salary, @HiredDate, @StopedDate)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffID);
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Sex", sex);
                        command.Parameters.AddWithValue("@DateBirth", dateBirth);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@HiredDate", hiredDate);
                        command.Parameters.AddWithValue("@StopedDate", stoppedDate);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Staff data saved successfully!");
                            LoadNextStaffID(); // Load the next available StaffID after saving
                            txtFullName.Text = "";
                            txtSex.Text = "";
                            dtpDateBirth.Value = DateTime.Now; // Set to current date as an example
                            txtPosition.Text = "";
                            txtAddress.Text = "";
                            txtPhone.Text = "";
                            txtSalary.Text = "";
                            dtpHiredDate.Value = DateTime.Now; // Set to current date as an example
                            dtpStoppedDate.Value = DateTime.Now;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.");
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtSex.Text) ||
                dtpDateBirth.Value == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                return false;
            }
            return true;
        }

        private void SearchAndUpdateStaff()
        {
            string staffID = txtSearchID.Text.Trim();

            if (string.IsNullOrWhiteSpace(staffID))
            {
                MessageBox.Show("Please enter a StaffID to search.");
                return;
            }

            if (btnSearchUpdate.Text == "Search")
            {
                // Perform search operation
                string query = "SELECT * FROM tbStaff WHERE StaffID = @StaffID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                // Staff found, populate the form fields for editing
                                txtFullName.Text = reader["FullName"].ToString();
                                txtSex.Text = reader["Sex"].ToString();
                                dtpDateBirth.Value = (DateTime)reader["DateBirth"];
                                txtPosition.Text = reader["Position"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                txtPhone.Text = reader["Phone"].ToString();
                                txtSalary.Text = reader["Salary"].ToString();
                                dtpHiredDate.Value = (DateTime)reader["HiredDate"];
                                if (reader["StopedDate"] != DBNull.Value)
                                    dtpStoppedDate.Value = (DateTime)reader["StopedDate"];
                                else
                                    dtpStoppedDate.Value = DateTime.Now; // Set default if stopped date is null

                                // Change button text and functionality to "Update"
                                btnSearchUpdate.Text = "Update";
                            }
                            else
                            {
                                // Staff not found, clear form fields for new entry
                                MessageBox.Show("Staff with ID " + staffID + " not found.");
                                ClearFields();
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error searching staff: " + ex.Message);
                        }
                    }
                }
            }
            else if (btnSearchUpdate.Text == "Update")
            {
                // Perform update operation
                if (ValidateFields())
                {
                    string fullName = txtFullName.Text;
                    string sex = txtSex.Text;
                    DateTime dateBirth = dtpDateBirth.Value;
                    string position = txtPosition.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    decimal salary = decimal.Parse(txtSalary.Text);
                    DateTime hiredDate = dtpHiredDate.Value;
                    DateTime? stoppedDate = dtpStoppedDate.Checked ? dtpStoppedDate.Value : (DateTime?)null;

                    string updateQuery = "UPDATE tbStaff SET " +
                                         "FullName = @FullName, " +
                                         "Sex = @Sex, " +
                                         "DateBirth = @DateBirth, " +
                                         "Position = @Position, " +
                                         "Address = @Address, " +
                                         "Phone = @Phone, " +
                                         "Salary = @Salary, " +
                                         "HiredDate = @HiredDate, " +
                                         "StopedDate = @StopedDate " +
                                         "WHERE StaffID = @StaffID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@StaffID", staffID);
                            updateCommand.Parameters.AddWithValue("@FullName", fullName);
                            updateCommand.Parameters.AddWithValue("@Sex", sex);
                            updateCommand.Parameters.AddWithValue("@DateBirth", dateBirth);
                            updateCommand.Parameters.AddWithValue("@Position", position);
                            updateCommand.Parameters.AddWithValue("@Address", address);
                            updateCommand.Parameters.AddWithValue("@Phone", phone);
                            updateCommand.Parameters.AddWithValue("@Salary", salary);
                            updateCommand.Parameters.AddWithValue("@HiredDate", hiredDate);
                            updateCommand.Parameters.AddWithValue("@StopedDate", stoppedDate);

                            try
                            {
                                connection.Open();
                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Staff data updated successfully!");
                                    ClearFields();
                                    btnSearchUpdate.Text = "Search";
                                }
                                else
                                {
                                    MessageBox.Show("Staff with ID " + staffID + " not found.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error updating staff data: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields.");
                }
            }
        }
        
        private void ClearFields()
        {
            txtFullName.Text = "";
            txtSex.Text = "";
            dtpDateBirth.Value = DateTime.Now; // Set to current date as an example
            txtPosition.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            dtpHiredDate.Value = DateTime.Now; // Set to current date as an example
            dtpStoppedDate.Value = DateTime.Now; // Set to current date as an example
        }



        private void StaffForm_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(
                this.Width - Convert.ToInt16(this.Width * 0.2),
                this.Height - Convert.ToInt16(this.Height * 0.2)
            );

            panel1.Location = new Point(
                this.Width / 2 - panel1.Width / 2,
                this.Height / 2 - panel1.Height / 2
            );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStaffData();
        }

        private void bntLoad_Click(object sender, EventArgs e)
        {
            SearchAndUpdateStaff();
        }
    }
}
