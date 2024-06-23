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
        static string connectionString = "Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True";
        SqlDataAdapter adapterDriver = new SqlDataAdapter("SELECT * FROM tbDriver", connectionString);
        DataTable tableDriver = new DataTable();

        public TruckForm()
        {
            InitializeComponent();


            var adapterTruck = new SqlDataAdapter("SELECT * FROM tbTruck", connectionString);
            var tableTruck = new DataTable();
            adapterTruck.Fill(tableTruck);
            if (tableTruck.Rows.Count > 0)
            {
                txtTruckID.Text = tableTruck.Rows[0]["TruckID"].ToString();
                txtTruckNumber.Text = tableTruck.Rows[0]["TruckNumber"].ToString();
            }
            adapterTruck.Dispose();




        }

        private void TruckForm_Load(object sender, EventArgs e)
        {
            adapterDriver.Fill(tableDriver);
            gridDriver.DataSource = tableDriver;
        }



        private void gridDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (tableDriver.Rows.Count > 0 && index > -1)
            {
                txtDriverID.Text = tableDriver.Rows[index]["DriverID"].ToString();
                txtDriverName.Text = tableDriver.Rows[index]["FullName"].ToString();
                if (tableDriver.Rows[index]["Sex"].ToString().CompareTo("M") == 0)
                {
                    ckMale.Checked = true;
                }
                else
                    ckFemale.Checked = true;

                txtDriverPhone.Text = tableDriver.Rows[index]["PhoneNumber"].ToString();
                adapterDriver.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            insertDriver();
        }

        private void insertDriver()
        {
            // Gather data from form controls
            string fullName = txtDriverName.Text;
            string phoneNumber = txtDriverPhone.Text;
            string sex = ckMale.Checked ? "M" : ckFemale.Checked ? "F" : string.Empty;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(sex))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertCommandText = @"
                INSERT INTO tbDriver (FullName, Sex,PhoneNumber)
                VALUES (@FullName, @Sex, @PhoneNumber)";

                using (SqlCommand command = new SqlCommand(insertCommandText, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Driver data inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            adapterDriver = new SqlDataAdapter("SELECT * FROM tbDriver", connectionString);
            tableDriver.Clear();
            adapterDriver.Fill(tableDriver);
            gridDriver.DataSource = tableDriver;
        }
    }
}
