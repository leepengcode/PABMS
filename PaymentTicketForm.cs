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
    public partial class PaymentTicketForm : Form
    {
        DataTable table;
        SqlConnection connection;
        public PaymentTicketForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void PaymentTicketForm_Load(object sender, EventArgs e)
        {
            // establish dataadapter to database
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbPaymentTicket", connection);
            try
            {
                table = new DataTable();
                adapter.Fill(table);
                // bind the data to the datagridview
                gridPaymentTicket.DataSource = table;

                txtPaymentTicketID.Text = table.Rows[0]["PaymentTicketID"].ToString();
                txtTicketID.Text = table.Rows[0]["TicketID"].ToString();
                txtCusID.Text = "1";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
