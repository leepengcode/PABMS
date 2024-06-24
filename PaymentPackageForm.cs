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
        public PaymentPackageForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }
    }
}
