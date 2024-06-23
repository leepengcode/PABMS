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


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Drivers (FullName, Sex, BirthDate, DriverAddress, PhoneNumber, Salary, HiredDate, StoppedWork) " +
                                   "VALUES (@FullName, @Sex, @BirthDate, @DriverAddress, @PhoneNumber, @Salary, @HiredDate, @StoppedWork)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Sex", txtSex.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@DriverAddress", txtDriverAddress.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    cmd.Parameters.AddWithValue("@HiredDate", dtpHiredDate.Value);
                    cmd.Parameters.AddWithValue("@StoppedWork", chkStoppedWork.Checked);
                    cmd.ExecuteNonQuery();
                }
                LoadDrivers();
                ClearInputFields();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
