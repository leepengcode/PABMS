using System;
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
    public partial class StaffForm : Form
    {
        private string connectionString = "Server=ASUS-EXPERTBOOK\\SQLEXPRESS;Database=PABMS_DBS;Integrated Security=True;";
        public StaffForm()
        {
            InitializeComponent();
        }


        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
