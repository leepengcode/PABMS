
using System.Data;
using System.Data.SqlClient;


namespace PABMS
{

    public partial class PaymentPackageForm : Form
    {
<<<<<<< HEAD
        string connectionString = "Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True";
=======
        string connectionString = @"Data Source=ASUS-EXPERTBOOK\SQLEXPRESS;Initial Catalog=ISADE5G5;Integrated Security=True;";
        //private string connectionString = @"Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True;";
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
>>>>>>> 6da47fc7a6dce197aabb5ed50c3c40985747f2d3
        public PaymentPackageForm()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            InitializeComponent();
        }
        private void FillComboSearchCusID()
        {
            cmCusID.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM tbCustomer", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmCusID.Items.Add(reader["CustomerID"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filling CustomerID combo box: " + ex.Message);
                }
            }
        }
      
        private void PaymentPackageForm_Load(object sender, EventArgs e)
        {
            FillComboSearchCusID();
            LoadLatestPayID();
        }

        private void cmCusID_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmCusID.SelectedItem != null)
            {
                int selectedCusID = Convert.ToInt32(cmCusID.SelectedItem.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT FullName, PhoneNumber FROM tbCustomer WHERE CustomerID = @CustomerID", conn);
                        cmd.Parameters.AddWithValue("@CustomerID", selectedCusID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtName.Text = reader["FullName"].ToString();
                            txtQty.Text = reader["PhoneNumber"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving customer details: " + ex.Message);
                    }
                }
            }
        }
        private void LoadLatestPayID()
        {
            int latestTicketID = GetLatestPayID();
            txtPayID.Text = (latestTicketID + 1).ToString();
        }

        private int GetLatestPayID()
        {
            int latestPayID = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(PaymentPackageID), 0) FROM tbPaymentPackage";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestPayID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching latest Payment Package: " + ex.Message);
                }
            }

            return latestPayID;
        }
    }
}
