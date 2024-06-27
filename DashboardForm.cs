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
    public partial class DashboardForm : Form
    {
        private string connectionString;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public DashboardForm(SqlConnection connection)
        {
            InitializeComponent();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            connectionString = connection.ConnectionString;
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DisplayCustomerCount();
        }

        private int GetCustomerCount()
        {
            int customerCount = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbCustomer";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        customerCount = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the customer count: " + ex.Message);
                }
            }

            return customerCount;
        }

        private int GetStaffCount()
        {
            int staffCount = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbStaff";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        staffCount = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the staff count: " + ex.Message);
                }
            }

            return staffCount;
        }

        private int GetBusCount()
        {
            int busCount = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbBus";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        busCount = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the bus count: " + ex.Message);
                }
            }

            return busCount;
        }
        private int GetTruckCount()
        {
            int truckCount = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tbTruck";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        truckCount = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the truck count: " + ex.Message);
                }
            }

            return truckCount;
        }

        private void DisplayCustomerCount()
        {
            int Cuscount = GetCustomerCount();
            int Staffcount = GetStaffCount();
            int busCount = GetBusCount();
            int truckCount = GetTruckCount();

            lbCustomer.Text = Cuscount.ToString();
            lbSatff.Text = Staffcount.ToString();
            lbTruck.Text = Staffcount.ToString();
            lbBus.Text = busCount.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
