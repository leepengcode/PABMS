using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PABMS
{
    public partial class StaffForm : Form
    {
        //private string connectionString = "Server=LAPTOP-2O9AK3I7\\SQLISADE5;Database=ISAD;Integrated Security=True;";
        //private string connectionString = "Server=ASUS-EXPERTBOOK\\SQLEXPRESS;Database=PABMS_DBS;Integrated Security=True;";
        private string connectionString = "";

        public StaffForm()
        {
            InitializeComponent();
            LoadNextStaffID(); // Load the next available StaffID when the form is initialized
            panel1.Dock = DockStyle.None;
            panelTitle.Dock = DockStyle.None;
            splitMain.Dock = DockStyle.None;
            tlpButtons.Dock = DockStyle.None;
            //this.FormBorderStyle = FormBorderStyle.None;
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
                string fullName = txtFullName.Text;
                string sex = txtSex.Text; // Assuming txtSex is the TextBox for Sex
                DateTime birthDate = dtpBirthDate.Value;
                string staffPosition = txtPosition.Text;
                string staffAddress = txtAddress.Text;
                string phoneNumber = txtPhone.Text;
                decimal salary = decimal.Parse(txtSalary.Text);
                DateTime hiredDate = dtpHiredDate.Value;
                bool stoppedWork = chkStoppedWork.Checked;

                string query = "INSERT INTO tbStaff (FullName, Sex, BirthDate, StaffPosition, StaffAddress, PhoneNumber, Salary, HiredDate, StoppedWork) " +
                               "VALUES (@FullName, @Sex, @BirthDate, @StaffPosition, @StaffAddress, @PhoneNumber, @Salary, @HiredDate, @StoppedWork)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Sex", sex);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@StaffPosition", staffPosition);
                        command.Parameters.AddWithValue("@StaffAddress", staffAddress);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@HiredDate", hiredDate);
                        command.Parameters.AddWithValue("@StoppedWork", stoppedWork);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Staff data saved successfully!");
                            LoadNextStaffID(); // Load the next available StaffID after saving
                            ClearFields();
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
                dtpBirthDate.Value == DateTime.MinValue ||
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
                                dtpBirthDate.Value = (DateTime)reader["BirthDate"];
                                txtPosition.Text = reader["StaffPosition"].ToString();
                                txtAddress.Text = reader["StaffAddress"].ToString();
                                txtPhone.Text = reader["PhoneNumber"].ToString();
                                txtSalary.Text = reader["Salary"].ToString();
                                dtpHiredDate.Value = (DateTime)reader["HiredDate"];
                                chkStoppedWork.Checked = (bool)reader["StoppedWork"];

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
                    DateTime birthDate = dtpBirthDate.Value;
                    string staffPosition = txtPosition.Text;
                    string staffAddress = txtAddress.Text;
                    string phoneNumber = txtPhone.Text;
                    decimal salary = decimal.Parse(txtSalary.Text);
                    DateTime hiredDate = dtpHiredDate.Value;
                    bool stoppedWork = chkStoppedWork.Checked;

                    string updateQuery = "UPDATE tbStaff SET " +
                                         "FullName = @FullName, " +
                                         "Sex = @Sex, " +
                                         "BirthDate = @BirthDate, " +
                                         "StaffPosition = @StaffPosition, " +
                                         "StaffAddress = @StaffAddress, " +
                                         "PhoneNumber = @PhoneNumber, " +
                                         "Salary = @Salary, " +
                                         "HiredDate = @HiredDate, " +
                                         "StoppedWork = @StoppedWork " +
                                         "WHERE StaffID = @StaffID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@StaffID", staffID);
                            updateCommand.Parameters.AddWithValue("@FullName", fullName);
                            updateCommand.Parameters.AddWithValue("@Sex", sex);
                            updateCommand.Parameters.AddWithValue("@BirthDate", birthDate);
                            updateCommand.Parameters.AddWithValue("@StaffPosition", staffPosition);
                            updateCommand.Parameters.AddWithValue("@StaffAddress", staffAddress);
                            updateCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            updateCommand.Parameters.AddWithValue("@Salary", salary);
                            updateCommand.Parameters.AddWithValue("@HiredDate", hiredDate);
                            updateCommand.Parameters.AddWithValue("@StoppedWork", stoppedWork);

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
            dtpBirthDate.Value = DateTime.Now; // Set to current date as an example
            txtPosition.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            dtpHiredDate.Value = DateTime.Now; // Set to current date as an example
            chkStoppedWork.Checked = false;
        }

        private void StaffForm_SizeChanged(object sender, EventArgs e)
        {
            /*panel1.Size = new Size(
                this.Width - Convert.ToInt16(this.Width * 0.2),
                this.Height - Convert.ToInt16(this.Height * 0.2)
            );

            panel1.Location = new Point(
                this.Width / 2 - panel1.Width / 2,
                this.Height / 2 - panel1.Height / 2
            );*/

            if (this.Width > 1680)
                return;
            panel1.Width = this.Width;
            panelTitle.Width = this.Width;
            splitMain.Width = this.Width;
            tlpButtons.Width = this.Width;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStaffData();
        }

        private void bntLoad_Click(object sender, EventArgs e)
        {
            SearchAndUpdateStaff();
        }

        public void changeSize()
        {
            panel1.Width = this.Width;
            panelTitle.Width = this.Width;
            splitMain.Width = this.Width;
            tlpButtons.Width = this.Width;
        }

        private void StaffForm_ResizeEnd(object sender, EventArgs e)
        {
            
            //MessageBox.Show("");
        }
    }
}
