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
    public partial class PaymentPackageForm : Form
    {
        SqlConnection connection;
        DataTable table;
        public PaymentPackageForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            string query = @"
                SELECT
                    pp.PaymentPackageID, pp.PaymentDate, pp.PaymentAmount, 
                    p.PackageID, p.PackageName,
                    c.CustomerID, c.FullName AS CustomerName, c.PhoneNumber AS CustomerTel
                FROM
	                tbPaymentPackage pp
                INNER JOIN
	                (tbPackage p 
                        INNER JOIN
			                tbCustomer c ON p.CustomerID = c.CustomerID)
                ON pp.PackageID = p.PackageID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            table = new DataTable();
            adapter.Fill(table);
            gridSearch.DataSource = table;
        }

        private void PaymentPackageForm_Load(object sender, EventArgs e)
        {
            // messagebox all value in column "PackageName: in table
            //MessageBox.Show(string.Join("\n", table.AsEnumerable().Select(x => x.Field<string>("PackageName")).ToArray()));
            cmbPackageName.Items.AddRange(table.AsEnumerable().Select(x => x.Field<string>("PackageName")).ToArray());

            // make cmbPackageName auto show suggested item
            cmbPackageName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPackageName.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void gridSearch_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = gridSearch.CurrentRow;
            txtPaymentID.Text = row.Cells["PaymentPackageID"].Value.ToString();
            txtAmount.Text = row.Cells["PaymentAmount"].Value.ToString();
            datePayment.Value = (DateTime)row.Cells["PaymentDate"].Value;

            txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
            txtCustomerTel.Text = row.Cells["CustomerTel"].Value.ToString();

            // put all package name into cmbPackage from table
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbPaymentPackage (PaymentDate, PaymentAmount, PackageID) VALUES (@PaymentDate, @PaymentAmount, @PackageID)";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PaymentDate", datePayment.Value);
                command.Parameters.AddWithValue("@PaymentAmount", txtAmount.Text);
                //command.Parameters.AddWithValue("@PackageID", table.AsEnumerable().Where(x => x.Field<string>("PackageName") == cmbPackageName.Text).Select(x => x.Field<int>("PackageID")).FirstOrDefault());
                command.ExecuteNonQuery();
            }
        }
    }
}
