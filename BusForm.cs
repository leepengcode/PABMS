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
    public partial class BusForm : Form
    {
        private string connectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public BusForm(SqlConnection connection)
        {
            InitializeComponent();
            connectionString = connection.ConnectionString;
        }

        private void FillComboSearchDriverID()
        {
            cmDriver.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DriverID FROM tbDriver", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmDriver.Items.Add(reader["DriverID"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filling driver combo box: " + ex.Message);
                }
            }
        }



        private void BusForm_Load(object sender, EventArgs e)
        {
            FillComboSearchDriverID();
            LoadLatestBusID();
            LoadBusData();
            DataBus.CellClick += DataBus_CellClick;
        }

        private void cmDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmDriver.SelectedItem != null)
            {
                int selectedCusID = Convert.ToInt32(cmDriver.SelectedItem.ToString());

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
            if (cmDriver.SelectedItem == null)
            {
                MessageBox.Show("Please select a driver.");
                return;
            }

            int driverId = Convert.ToInt32(cmDriver.SelectedItem.ToString());
            string busNo = txtBusNo.Text.Trim();
            double price;

            if (!double.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid ticket price.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbBus (BusNumber, TicketPrice, DriverID) " +
                                   "VALUES (@BusNumber, @TicketPrice, @DriverID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BusNumber", busNo);
                        cmd.Parameters.AddWithValue("@TicketPrice", price);
                        cmd.Parameters.AddWithValue("@DriverID", driverId);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bus added successfully.");
                    LoadLatestBusID();
                    LoadBusData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the bus: " + ex.Message);
                }
            }
        }
        private void LoadLatestBusID()
        {
            int latestTicketID = GetLatestBusID();
            txtBusID.Text = (latestTicketID + 1).ToString();
        }

        private int GetLatestBusID()
        {
            int latestbusID = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(BusID), 0) FROM tbBus";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestbusID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching latest Bus ID: " + ex.Message);
                }
            }

            return latestbusID;
        }

        private void LoadBusData()
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter();

            string query = "SELECT BusID, BusNumber, TicketPrice, DriverID FROM tbBus";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataAdapter.SelectCommand = new SqlCommand(query, conn);
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    DataBus.DataSource = dataTable;

                    // Optionally, set DataGridView column headers if not automatically set
                    DataBus.Columns["BusID"].HeaderText = "Bus ID";
                    DataBus.Columns["BusNumber"].HeaderText = "Bus Numer";
                    DataBus.Columns["TicketPrice"].HeaderText = "Ticket Price";
                    DataBus.Columns["DriverID"].HeaderText = "Driver ID";

                    DataBus.Columns["BusID"].Width = 170; // Adjust the width as needed
                    DataBus.Columns["BusNumber"].Width = 250; // Adjust the width as needed
                    DataBus.Columns["TicketPrice"].Width = 250;
                    DataBus.Columns["DriverID"].Width = 250;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading bus data: " + ex.Message);
                }
            }
        }
        private void DataBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataBus.Rows[e.RowIndex];
                if (row != null)
                {
                    txtBusID.Text = row.Cells["BusID"].Value.ToString(); // Assuming BusID is stored in the TicketID field of DataTicket
                    txtBusNo.Text = row.Cells["BusNumber"].Value.ToString(); // Replace with correct column name
                    txtPrice.Text = row.Cells["TicketPrice"].Value.ToString(); // Replace with correct column name
                    cmDriver.Text = row.Cells["DriverID"].Value.ToString(); // Replace with correct column name
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int searchID;
            if (!int.TryParse(txtSearch.Text.Trim(), out searchID))
            {
                MessageBox.Show("Please enter a valid Bus ID for searching.");
                return;
            }

            string query = "SELECT BusID, BusNumber, TicketPrice, DriverID " +
                           "FROM tbBus WHERE BusID = @BusID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataAdapter.SelectCommand = new SqlCommand(query, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@BusID", searchID);
                    dataTable.Clear(); // Clear previous data
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    DataBus.DataSource = dataTable;

                    // Optionally, set DataGridView column headers if not automatically set
                    DataBus.Columns["BusID"].HeaderText = "Bus ID";
                    DataBus.Columns["BusNumber"].HeaderText = "Bus Number";
                    DataBus.Columns["TicketPrice"].HeaderText = "Ticket Price";
                    DataBus.Columns["DriverID"].HeaderText = "Driver ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for the bus: " + ex.Message);
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusID.Text.Trim()))
            {
                MessageBox.Show("Please select a bus to update.");
                return;
            }

            int busID = Convert.ToInt32(txtBusID.Text.Trim());
            string busNumber = txtBusNo.Text.Trim();
            decimal ticketPrice;

            if (!decimal.TryParse(txtPrice.Text.Trim(), out ticketPrice))
            {
                MessageBox.Show("Please enter a valid ticket price.");
                return;
            }

            int driverID = Convert.ToInt32(cmDriver.SelectedItem?.ToString());

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
                    string query = "UPDATE tbBus SET BusNumber = @BusNumber, TicketPrice = @TicketPrice, DriverID = @DriverID " +
                                   "WHERE BusID = @BusID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BusID", busID);
                        cmd.Parameters.AddWithValue("@BusNumber", busNumber);
                        cmd.Parameters.AddWithValue("@TicketPrice", ticketPrice);
                        cmd.Parameters.AddWithValue("@DriverID", driverID);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bus updated successfully.");
                    LoadLatestBusID();
                    LoadBusData();
                    ClearForm();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the bus: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {

            txtBusNo.Clear();
            txtPrice.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtSearch.Clear();
            txtBusNo.Clear();
            cmDriver.SelectedIndex = -1;

            // Optionally, you can also clear any other fields related to tbBus
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLatestBusID();
            LoadBusData();
        }
    }
}
