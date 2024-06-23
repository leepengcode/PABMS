/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABMS
{
    public partial class PackageForm : Form
    {
        public PackageForm()
        {
            InitializeComponent();
        }
    }
}
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PABMS
{
    public partial class PackageForm : Form
    {
        string connectionString = "Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True;";

        public PackageForm()
        {
            InitializeComponent();
            // Attach event handlers
            btnSearch.Click += BtnSearch_Click;
            gridSearch.SelectionChanged += GridSearch_SelectionChanged;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int packageId))
            {
                SearchTickets(packageId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Package ID.");
            }
        }

        private void SearchTickets(int packageId)
        {
            string query = @"
                SELECT 
                    p.PackageID,
                    p.PackageName,
                    p.PackagePrice,
                    p.DeliveryDate,
                    p.DepartureDate,
                    p.ReceiverContactInformation,
                    p.OriginName,
                    p.DestinationName,
                    c.CustomerID,
                    c.FullName AS CustomerName,
                    c.PhoneNumber AS CustomerPhoneNumber,
                    c.Sex AS CustomerSex,
                    s.StaffID,
                    s.FullName AS StaffName,
                    s.Sex AS StaffSex,
                    t.TruckID,
                    t.TruckNumber
                FROM tbPackage p
                JOIN tbCustomer c ON p.CustomerID = c.CustomerID
                JOIN tbStaff s ON p.StaffID = s.StaffID
                JOIN tbTruck t ON p.TruckID = t.TruckID
                WHERE 
                    p.PackageID = @PackageID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PackageID", packageId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gridSearch.DataSource = dt;
            }
        }

        private void GridSearch_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = gridSearch.CurrentRow;
            if (row != null)
                DisplaySelectedRowData(row);
        }

        private void DisplaySelectedRowData(DataGridViewRow row)
        {
            txtPackageID.Text = row.Cells["PackageID"].Value.ToString();
            txtPackagePrice.Text = row.Cells["PackagePrice"].Value.ToString();
            txtReciverContact.Text = row.Cells["ReceiverContactInformation"].Value.ToString();
            txtOrigin.Text = row.Cells["OriginName"].Value.ToString();
            txtDestination.Text = row.Cells["DestinationName"].Value.ToString();
            txtPackageName.Text = row.Cells["PackageName"].Value.ToString();

            txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
            txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["CustomerPhoneNumber"].Value.ToString();
            string customerSex = row.Cells["CustomerSex"].Value.ToString();
            ckMale.Checked = customerSex == "M";
            ckFemale.Checked = customerSex == "F";

            txtStaffID.Text = row.Cells["StaffID"].Value.ToString();
            txtStaffName.Text = row.Cells["StaffName"].Value.ToString();
            string staffSex = row.Cells["StaffSex"].Value.ToString();
            ckMale.Checked = staffSex == "M";
            ckFemale.Checked = staffSex == "F";

            txtTruckID.Text = row.Cells["TruckID"].Value.ToString();
            txtTruckNo.Text = row.Cells["TruckNumber"].Value.ToString();

            dateDeparture.Value = (DateTime)row.Cells["DepartureDate"].Value;
            dateDelivery.Value = (DateTime)row.Cells["DeliveryDate"].Value;
        }

        // btnSave Click Event Handler
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
        UPDATE tbPackage
        SET PackageName = @PackageName, PackagePrice = @PackagePrice, DeliveryDate = @DeliveryDate, DepartureDate = @DepartureDate, ReceiverContactInformation = @ReceiverContact, OriginName = @Origin, DestinationName = @Destination, CustomerID = @CustomerID, StaffID = @StaffID, TruckID = @TruckID
        WHERE PackageID = @PackageID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@PackageName", txtPackageName.Text);
                command.Parameters.AddWithValue("@PackagePrice", decimal.Parse(txtPackagePrice.Text));
                command.Parameters.AddWithValue("@DeliveryDate", DateTime.Parse(dateDelivery.Value.ToString()));
                command.Parameters.AddWithValue("@DepartureDate", DateTime.Parse(dateDeparture.Value.ToString()));
                command.Parameters.AddWithValue("@ReceiverContact", txtReciverContact.Text);
                command.Parameters.AddWithValue("@Origin", txtOrigin.Text);
                command.Parameters.AddWithValue("@Destination", txtDestination.Text);
                command.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                command.Parameters.AddWithValue("@StaffID", int.Parse(txtStaffID.Text));
                command.Parameters.AddWithValue("@TruckID", int.Parse(txtTruckID.Text));
                command.Parameters.AddWithValue("@PackageID", int.Parse(txtPackageID.Text)); // Assuming txtPackageID is your textbox for PackageID

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Data updated successfully.");
                else
                    MessageBox.Show("Data update failed.");
            }
        }

        // btnUpdate Click Event Handler
        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertQuery = @"
        INSERT INTO tbPackage (PackageName, PackagePrice, DeliveryDate, DepartureDate, ReceiverContactInformation, OriginName, DestinationName, CustomerID, StaffID, TruckID)
        VALUES (@PackageName, @PackagePrice, @DeliveryDate, @DepartureDate, @ReceiverContact, @Origin, @Destination, @CustomerID, @StaffID, @TruckID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@PackageName", txtPackageName.Text);
                command.Parameters.AddWithValue("@PackagePrice", decimal.Parse(txtPackagePrice.Text));
                command.Parameters.AddWithValue("@DeliveryDate", DateTime.Parse(dateDelivery.Value.ToString()));
                command.Parameters.AddWithValue("@DepartureDate", DateTime.Parse(dateDeparture.Value.ToString()));
                command.Parameters.AddWithValue("@ReceiverContact", txtReciverContact.Text);
                command.Parameters.AddWithValue("@Origin", txtOrigin.Text);
                command.Parameters.AddWithValue("@Destination", txtDestination.Text);
                command.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                command.Parameters.AddWithValue("@StaffID", int.Parse(txtStaffID.Text));
                command.Parameters.AddWithValue("@TruckID", int.Parse(txtTruckID.Text));

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Data inserted successfully.");
                else
                    MessageBox.Show("Data insertion failed.");
            }
        }

        // btnNew Click Event Handler
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            // Example: txtPackageName.Clear();
            // Repeat for all textboxes

            // Reset checkboxes
            ckMale.Checked = false;
            ckFemale.Checked = false;
        }
    }
}
