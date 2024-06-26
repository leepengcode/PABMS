using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PABMS
{
    public partial class TruckForm : Form
    {
        static string connectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public TruckForm(SqlConnection connection)
        {
            InitializeComponent();
            connectionString = connection.ConnectionString;
        }

        private void FillComboSearchTruckID()
        {
            cmTruck.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DriverID FROM tbDriver", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmTruck.Items.Add(reader["DriverID"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filling driver combo box: " + ex.Message);
                }
            }
        }


        private void TruckForm_Load(object sender, EventArgs e)
        {
            FillComboSearchTruckID();
            LoadLatestTruckID();
            LoadTruckData();
            DataTruck.CellClick += DataBus_CellClick;
        }



        private void gridDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
                int searchID;
                if (!int.TryParse(txtSearch.Text.Trim(), out searchID))
                {
                    MessageBox.Show("Please enter a valid Truck ID for searching.");
                    return;
                }

                string query = "SELECT TruckID, TruckNumber, DriverID " +
                               "FROM tbTruck WHERE TruckID = @TruckID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        dataAdapter.SelectCommand = new SqlCommand(query, conn);
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@TruckID", searchID);
                        dataTable.Clear(); // Clear previous data
                        dataAdapter.Fill(dataTable);

                        // Bind data to DataGridView
                        DataTruck.DataSource = dataTable;

                        // Optionally, set DataGridView column headers if not automatically set
                        DataTruck.Columns["TruckID"].HeaderText = "Truck ID";
                        DataTruck.Columns["TruckNumber"].HeaderText = "Truck Number";
                        DataTruck.Columns["DriverID"].HeaderText = "Driver ID";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while searching for the truck: " + ex.Message);
                    }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTruckID.Text.Trim()))
            {
                MessageBox.Show("Please select a truck to update.");
                return;
            }

            int truckID = Convert.ToInt32(txtTruckID.Text.Trim()); // Assuming txtBusID is used for TruckID
            string truckNumber = txtTruckNumber.Text.Trim();
            int driverID = Convert.ToInt32(cmTruck.SelectedItem?.ToString());

            if (driverID == 0)
            {
                MessageBox.Show("Please select a valid driver.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE tbTruck SET TruckNumber = @TruckNumber, DriverID = @DriverID " +
                                   "WHERE TruckID = @TruckID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TruckID", truckID);
                        cmd.Parameters.AddWithValue("@TruckNumber", truckNumber);
                        cmd.Parameters.AddWithValue("@DriverID", driverID);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Truck updated successfully.");
                    LoadLatestTruckID(); // Assuming you have a method to load latest TruckID
                    LoadTruckData(); // Assuming you have a method to load truck data into DataGridView
                    //ClearForm(); // Assuming you have a method to clear form fields

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the truck: " + ex.Message);
                }
            }
        }

        private void insertDriver()
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmTruck_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmTruck.SelectedItem != null)
            {
                int selectedCusID = Convert.ToInt32(cmTruck.SelectedItem.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT FullName, PhoneNumber FROM tbDriver WHERE DriverID = @DriverID", conn);
                        cmd.Parameters.AddWithValue("@DriverID", selectedCusID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["FullName"].ToString();
                            txtPhone.Text = reader["PhoneNumber"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving Driver details: " + ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmTruck.SelectedItem == null)
            {
                MessageBox.Show("Please select a driver.");
                return;
            }

            int driverId = Convert.ToInt32(cmTruck.SelectedItem.ToString());
            string truckNo = txtTruckNumber.Text.Trim();
            string truckID = txtTruckID.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbTruck (TruckNumber, DriverID) " +
                                   "VALUES (@TruckNumber, @DriverID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TruckID", truckID);
                        cmd.Parameters.AddWithValue("@TruckNumber", truckNo);
                        cmd.Parameters.AddWithValue("@DriverID", driverId);

                        cmd.ExecuteNonQuery();
                    }
                    LoadLatestTruckID();
                    MessageBox.Show("Truck added successfully.");
                    LoadLatestTruckID();
                    LoadTruckData();
                    ClearForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the truck: " + ex.Message);
                }
            }
        }
        private void LoadLatestTruckID()
        {
            int latestTruckID = GetLatestTruckID();
            txtTruckID.Text = (latestTruckID + 1).ToString();
        }

        private int GetLatestTruckID()
        {
            int latestTruckID = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(TruckID), 0) FROM tbTruck";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestTruckID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching latest Truck ID: " + ex.Message);
                }
            }

            return latestTruckID;
        }
        private void LoadTruckData()
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter();

            string query = "SELECT TruckID, TruckNumber, DriverID FROM tbTruck";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataAdapter.SelectCommand = new SqlCommand(query, conn);
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    DataTruck.DataSource = dataTable;

                    // Optionally, set DataGridView column headers if not automatically set
                    DataTruck.Columns["TruckID"].HeaderText = "Truck ID";
                    DataTruck.Columns["TruckNumber"].HeaderText = "Truck Number";
                    DataTruck.Columns["DriverID"].HeaderText = "Driver ID";

                    DataTruck.Columns["TruckID"].Width = 150; // Adjust the width as needed
                    DataTruck.Columns["TruckNumber"].Width = 250; // Adjust the width as needed
                    DataTruck.Columns["DriverID"].Width = 200; // Adjust the width as needed
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading truck data: " + ex.Message);
                }
            }
        }
        private void DataBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataTruck.Rows[e.RowIndex];
                if (row != null)
                {
                    txtTruckID.Text = row.Cells["TruckID"].Value.ToString(); // Assuming TruckID is the column name in your DataGridView
                    txtTruckNumber.Text = row.Cells["TruckNumber"].Value.ToString(); // Replace with correct column name
                    cmTruck.Text = row.Cells["DriverID"].Value.ToString(); // Replace with correct column name
                }
            }
        }
        private void ClearForm()
        {
            txtTruckNumber.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtSearch.Clear();
            cmTruck.SelectedIndex = -1;
            LoadLatestTruckID();


            // Optionally, you can also clear any other fields related to tbTruck
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
