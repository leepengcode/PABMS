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
                    p.PackageID,
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

        }

        private void gridSearch_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = gridSearch.CurrentRow;
            txtPaymentID.Text = row.Cells["PaymentPackageID"].Value.ToString();
        }
    }
}
