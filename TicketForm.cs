using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace PABMS
{
    public partial class TicketForm : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        SqlConnection connection;

        public TicketForm(SqlConnection connection)
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter();
            dataTable = new DataTable();
            this.connection = connection;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            FillComboBusID();
            FillComboStaffID();
            FillComboCusID();
            /*LoadTicketData();
            LoadLatestTicketID();
            gridTicket.CellClick += DataTicket_CellClick;*/

            //fillDataTableAllColumns();
            fillDataTableTicketColumns();
            gridTicket.DataSource = dataTable;
        }
        private void FillComboBusID()
        {
            cmbBusNumber.Items.Clear();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT BusNumber FROM tbBus", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBusNumber.Items.Add(reader["BusNumber"].ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling BusID combo box: " + ex.Message);
            }

        }

        private void FillComboStaffID()
        {
            cmStaffName.Items.Clear();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT FullName FROM tbStaff", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmStaffName.Items.Add(reader["FullName"].ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling StaffID combo box: " + ex.Message);
            }

        }

        private void FillComboCusID()
        {
            cmCusName.Items.Clear();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT FullName FROM tbCustomer", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmCusName.Items.Add(reader["FullName"].ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling CustomerID combo box: " + ex.Message);
            }

        }

        private void cmCusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmCusName.SelectedItem != null)
            {
                string selectedCusName = Convert.ToString(cmCusName.SelectedItem.ToString());
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CustomerID, PhoneNumber FROM tbCustomer WHERE FullName = @FullName", connection);
                    cmd.Parameters.AddWithValue("@FullName", selectedCusName);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtCustomerID.Text = reader["CustomerID"].ToString();
                        txtCusPhone.Text = reader["PhoneNumber"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving customer details: " + ex.Message);
                }

            }
        }


        private void LoadLatestTicketID()
        {
            int latestTicketID = GetLatestTicketID();
            txtTicketID.Text = (latestTicketID + 1).ToString();
        }
        private int GetLatestTicketID()
        {
            int latestTicketID = 1;

            try
            {
                connection.Open();
                string query = "SELECT ISNULL(MAX(TicketID), 0) FROM tbTicket";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        latestTicketID = Convert.ToInt32(result);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching latest Ticket ID: " + ex.Message);
            }


            return latestTicketID;
        }

        private void gridTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fillDataTableAllColumns();
                DataRow row;
                row = dataTable.Rows[e.RowIndex];
                if (row != null)
                {
                    txtTicketID.Text = row["TicketID"].ToString();
                    dtpPurchase.Value = Convert.ToDateTime(row["PurchaseDate"]);
                    dtpDeparture.Value = Convert.ToDateTime(row["DepartureDate"]);
                    txtOrigin.Text = row["OriginName"].ToString();
                    txtDestination.Text = row["DestinationName"].ToString();

                    txtCustomerID.Text = row["CustomerID"].ToString();
                    cmCusName.Text = row["CustomerName"].ToString();
                    txtCusPhone.Text = row["CustomerPhone"].ToString();

                    StaffID.Text = row["StaffID"].ToString();
                    cmStaffName.Text = row["StaffID"].ToString();

                    txtBusID.Text = row["BusID"].ToString();
                    cmbBusNumber.Text = row["BusNumber"].ToString();
                    txtTicketPrice.Text = row["TicketPrice"].ToString();
                }
                else
                {
                    return;
                }
            }
        }
        // get all data for grid with all connected foreign keys
        private void fillDataTableAllColumns()
        {
            dataTable = new DataTable();
            string query = @"SELECT t.TicketID, t.PurchaseDate, t.DepartureDate, t.OriginName, t.DestinationName, +
                c.CustomerID, c.FullName as CustomerName, c.PhoneNumber as CustomerPhone, +
                s.StaffID, s.FullName as StaffName,
                b.BusID, b.BusNumber, b.TicketPrice
                FROM tbTicket t
                INNER JOIN tbCustomer c ON t.CustomerID = c.CustomerID
                INNER JOIN tbStaff s ON t.StaffID = s.StaffID
                INNER JOIN tbBus b ON t.BusID = b.BusID
            ";
            try
            {
                connection.Open();
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading ticket data: " + ex.Message);
            }
        }
        private void fillDataTableTicketColumns()
        {
            dataTable = new DataTable();
            string query = "SELECT TicketID, PurchaseDate, DepartureDate, CustomerID, StaffID, OriginName, DestinationName, BusID FROM tbTicket";
            try
            {
                connection.Open();
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading ticket data: " + ex.Message);
            }
        }
        private void cmbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmStaffName.SelectedItem != null)
            {
                string selectedStaffName = cmStaffName.SelectedItem.ToString();

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT StaffID FROM tbStaff WHERE FullName = @FullName", connection);
                    cmd.Parameters.AddWithValue("@FullName", selectedStaffName);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        StaffID.Text = reader["StaffID"].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving staff details: " + ex.Message);
                }
            }
        }

        private void cmBusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBusNumber.SelectedItem != null)
            {
                string selectedBusNumber = cmbBusNumber.SelectedItem.ToString();

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT BusID, TicketPrice FROM tbBus WHERE BusNumber = @BusNumber", connection);
                    cmd.Parameters.AddWithValue("@BusNumber", selectedBusNumber);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtBusID.Text = reader["BusID"].ToString();
                        txtTicketPrice.Text = reader["TicketPrice"].ToString();
                    }

                    connection.Close(); reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving bus details: " + ex.Message);
                }

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchID;
            if (!int.TryParse(txtSearch.Text.Trim(), out searchID))
            {
                MessageBox.Show("Please enter a valid Ticket ID for searching.");
                return;
            }

            string query = "SELECT TicketID, PurchaseDate, DepartureDate, CustomerID, StaffID, OriginName, DestinationName, BusID " +
                           "FROM tbTicket WHERE TicketID = @TicketID";

            try
            {
                connection.Open(); // error here
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@TicketID", searchID);
                dataTable.Clear(); // Clear previous data
                dataAdapter.Fill(dataTable);

                // Bind data to DataGridView
                gridTicket.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the ticket: " + ex.Message);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {


            int customerId = Convert.ToInt32(cmCusName.SelectedItem.ToString());
            int staffId = Convert.ToInt32(cmStaffName.SelectedItem.ToString());
            int busId = Convert.ToInt32(cmbBusNumber.SelectedItem.ToString());
            DateTime purchaseDate = dtpPurchase.Value;
            DateTime departureDate = dtpDeparture.Value;
            string originName = txtOrigin.Text.Trim();
            string destinationName = txtDestination.Text.Trim();

            try
            {
                connection.Open();
                string query = "INSERT INTO tbTicket (PurchaseDate, DepartureDate, CustomerID, StaffID, OriginName, DestinationName, BusID) " +
                                "VALUES (@PurchaseDate, @DepartureDate, @CustomerID, @StaffID, @OriginName, @DestinationName, @BusID)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@DepartureDate", departureDate);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@OriginName", originName);
                    cmd.Parameters.AddWithValue("@DestinationName", destinationName);
                    cmd.Parameters.AddWithValue("@BusID", busId);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ticket added successfully.");
                //LoadTicketData();
                LoadLatestTicketID();
                ClearForm();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the ticket: " + ex.Message);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTicketID.Text.Trim()))
            {
                MessageBox.Show("Please select a ticket to update.");
                return;
            }

            int ticketID = Convert.ToInt32(txtTicketID.Text.Trim());
            int customerID = Convert.ToInt32(cmCusName.SelectedItem?.ToString());
            int staffID = Convert.ToInt32(cmStaffName.SelectedItem?.ToString());
            int busID = Convert.ToInt32(cmbBusNumber.SelectedItem?.ToString());
            DateTime purchaseDate = dtpPurchase.Value;
            DateTime departureDate = dtpDeparture.Value;
            string origin = txtOrigin.Text.Trim();
            string destination = txtDestination.Text.Trim();

            if (customerID == 0 || staffID == 0 || busID == 0)
            {
                MessageBox.Show("Please select a valid customer, staff, and bus.");
                return;
            }

            try
            {
                connection.Open();
                string query = "UPDATE tbTicket SET PurchaseDate = @PurchaseDate, DepartureDate = @DepartureDate, " +
                                "CustomerID = @CustomerID, StaffID = @StaffID, OriginName = @OriginName, " +
                                "DestinationName = @DestinationName, BusID = @BusID " +
                                "WHERE TicketID = @TicketID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TicketID", ticketID);
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@DepartureDate", departureDate);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@StaffID", staffID);
                    cmd.Parameters.AddWithValue("@OriginName", origin);
                    cmd.Parameters.AddWithValue("@DestinationName", destination);
                    cmd.Parameters.AddWithValue("@BusID", busID);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ticket updated successfully.");
                ClearForm();
                //LoadTicketData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            cmCusName.SelectedIndex = -1;
            cmStaffName.SelectedIndex = -1;
            cmbBusNumber.SelectedIndex = -1;
            dtpPurchase.Value = DateTime.Now;
            dtpDeparture.Value = DateTime.Now;
            txtOrigin.Clear();
            txtDestination.Clear();
            txtBusID.Clear();
            txtTicketPrice.Clear();
            txtCustomerID.Clear();
            txtCusPhone.Clear();
            StaffID.Clear();
            txtSearch.Clear();
            //LoadTicketData();
            //LoadLatestTicketID();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
