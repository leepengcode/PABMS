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
    public partial class CustomerForm : Form
    {
        // private string connectionString = "Server=ASUS-EXPERTBOOK\\SQLEXPRESS;Database=ISADE5G5;Integrated Security=True;";
        private string connectionString = "Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void LoadLatestCusID()
        {
            int latestCusID = GetLatestCusID();
            txtCusID.Text = (latestCusID + 1).ToString();
        }

        private int GetLatestCusID()
        {
            int latestCusID = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(CustomerID), 0) FROM tbCustomer";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestCusID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching latest customer ID: " + ex.Message);
                }
            }

            return latestCusID;
        }
        private void DataCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataCus.Rows[e.RowIndex];
                if (row != null)
                {
                    txtCusID.Text = row.Cells["CustomerID"].Value.ToString(); // Replace with the correct column name
                    txtFullName.Text = row.Cells["FullName"].Value.ToString(); // Replace with the correct column name
                    string sex = row.Cells["Sex"].Value.ToString();
                    if (sex == "M")
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }
                    txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString(); // Replace with the correct column name
                }
            }
        }




        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadLatestCusID();
            LoadCusData();
            DataCus.CellClick += DataCus_CellClick;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string sex = rbMale.Checked ? "M" : "F";
            string phone = txtPhone.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter full name and phone number.");
                return;
            }

            // Check for duplicate phone number
            if (IsDuplicatePhoneNumber(phone))
            {
                MessageBox.Show("This phone number is already registered.");
                return;
            }

            // Proceed to insert new customer record
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbCustomer (FullName, Sex, PhoneNumber) " +
                                   "VALUES (@FullName, @Sex, @PhoneNumber)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Customer added successfully.");
                    LoadCusData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // Method to check if the phone number already exists in tbCustomer
        private bool IsDuplicatePhoneNumber(string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbCustomer WHERE PhoneNumber = @PhoneNumber";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking duplicate phone number: " + ex.Message);
                    return true; // Assume duplicate to prevent insertion in case of error
                }
            }
        }


        private void LoadCusData()
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter();

            string query = "SELECT CustomerID, FullName, Sex, PhoneNumber FROM tbCustomer";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataAdapter.SelectCommand = new SqlCommand(query, conn);
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    DataCus.DataSource = dataTable;

                    // Optionally, set DataGridView column headers if not automatically set
                    DataCus.Columns["CustomerID"].HeaderText = "Customer ID";
                    DataCus.Columns["FullName"].HeaderText = "Full Name";
                    DataCus.Columns["Sex"].HeaderText = "Sex";
                    DataCus.Columns["PhoneNumber"].HeaderText = "Phone Number";


                    DataCus.Columns["CustomerID"].Width = 150; // Adjust the width as needed
                    DataCus.Columns["FullName"].Width = 250; // Adjust the width as needed
                    DataCus.Columns["Sex"].Width = 100; // Adjust the width as needed
                    DataCus.Columns["PhoneNumber"].Width = 250; // Adjust the width as needed

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading customer data: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {

            txtFullName.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtPhone.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value for searching.");
                return;
            }

            string query = "SELECT CustomerID, FullName, Sex, PhoneNumber FROM tbCustomer WHERE 1=1";
            bool isNumericSearch = int.TryParse(searchValue, out int searchID);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    if (isNumericSearch)
                    {
                        query += " AND CustomerID = @SearchID";
                        cmd.Parameters.AddWithValue("@SearchID", searchID);
                    }
                    else
                    {
                        query += " AND (FullName LIKE @SearchValue OR PhoneNumber LIKE @SearchValue)";
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                    }

                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    dataAdapter.SelectCommand = cmd;
                    dataTable.Clear(); // Clear previous data
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No results found.");
                    }

                    // Bind data to DataGridView
                    DataCus.DataSource = dataTable;

                    // Optionally, set DataGridView column headers if not automatically set
                    DataCus.Columns["CustomerID"].HeaderText = "Customer ID";
                    DataCus.Columns["FullName"].HeaderText = "Full Name";
                    DataCus.Columns["Sex"].HeaderText = "Sex";
                    DataCus.Columns["PhoneNumber"].HeaderText = "Phone Number";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for the customer: " + ex.Message);
                }
            }
        }





        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtSearch.Clear();
            LoadCusData();
            LoadLatestCusID();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCusID.Text.Trim()))
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            int customerID = Convert.ToInt32(txtCusID.Text.Trim());
            string fullName = txtFullName.Text.Trim();
            string sex = rbMale.Checked ? "M" : "F";
            string phoneNumber = txtPhone.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE tbCustomer SET FullName = @FullName, Sex = @Sex, PhoneNumber = @PhoneNumber " +
                                   "WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Customer updated successfully.");
                    LoadCusData(); // Refresh the customer data grid
                    ClearForm(); // Clear the form fields

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the customer: " + ex.Message);
                }
            }



            void ClearForm()
            {
              
                txtFullName.Text = string.Empty;
                rbMale.Checked = false;
                txtSearch.Text = "";
                rbFemale.Checked = false;
                txtPhone.Text = string.Empty;
            }
        }
    }

}