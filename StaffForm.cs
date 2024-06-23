using System.Data.SqlClient;
using System.Data;

namespace PABMS
{
    public partial class StaffForm : Form
    {
        private string connectionString = "Server=ASUS-EXPERTBOOK\\SQLEXPRESS;Database=ISADE5G5;Integrated Security=True;";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadLatestStaffID();
            LoadStaffData();
            DataStaff.CellClick += dataStaff_CellClick; // Add event handler for DataGridView cell click
        }

        private void LoadLatestStaffID()
        {
            int latestStaffID = GetLatestStaffID();
            txtID.Text = latestStaffID.ToString();
        }

        private int GetLatestStaffID()
        {
            int latestStaffID = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(StaffID), 0)  FROM tbStaff";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestStaffID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching latest StaffID: " + ex.Message);
                }
            }

            return latestStaffID;
        }

        private void LoadStaffData()
        {
            dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter();

            string query = "SELECT StaffID, FullName, Sex, BirthDate, StaffPosition, StaffAddress, PhoneNumber, Salary, HiredDate, Photo, StoppedWork FROM tbStaff";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataAdapter.SelectCommand = new SqlCommand(query, conn);
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    DataStaff.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading staff data: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int nextStaffID = GetLatestStaffID() + 1;
            txtID.Text = nextStaffID.ToString();

            string fullName = txtFullName.Text.Trim();
            string sex = rbMale.Checked ? "M" : "F";
            DateTime birthDate = dtpBirthDate.Value;
            string position = txtStaffPosition.Text.Trim();
            string address = txtStaffAddress.Text.Trim();
            string phone = txtStaffPhone.Text.Trim();
            decimal salary;

            if (!decimal.TryParse(txtStaffSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            DateTime hiredDate = dtpHiredDate.Value;
            bool stoppedWork = rbStoppedWork.Checked;

            byte[] photo = null;
            if (pbPhoto.Image != null)
            {
                photo = ImageToByteArray(pbPhoto.Image);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbStaff (FullName, Sex, BirthDate, StaffPosition, StaffAddress, PhoneNumber, Salary, HiredDate, Photo, StoppedWork) " +
                                   "VALUES (@FullName, @Sex, @BirthDate, @StaffPosition, @StaffAddress, @PhoneNumber, @Salary, @HiredDate, @Photo, @StoppedWork)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@StaffPosition", position);
                        cmd.Parameters.AddWithValue("@StaffAddress", address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@HiredDate", hiredDate);
                        cmd.Parameters.AddWithValue("@Photo", photo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@StoppedWork", stoppedWork);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Staff member added successfully.");
                    ClearForm();
                    LoadLatestStaffID();
                    LoadStaffData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchID;
            if (!int.TryParse(txtSearch.Text.Trim(), out searchID))
            {
                MessageBox.Show("Please enter a valid Staff ID for searching.");
                return;
            }

            string query = "SELECT StaffID, FullName, Sex, BirthDate, StaffPosition, StaffAddress, PhoneNumber, Salary, HiredDate, Photo, StoppedWork " +
                           "FROM tbStaff WHERE StaffID = @StaffID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    dataAdapter.SelectCommand = new SqlCommand(query, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@StaffID", searchID);
                    dataTable.Clear(); // Clear previous data
                    dataAdapter.Fill(dataTable);

                    // Bind data to DataGridView
                    DataStaff.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching staff: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            rbMale.Checked = true;
            dtpBirthDate.Value = DateTime.Now;
            txtStaffPosition.Clear();
            txtStaffAddress.Clear();
            txtStaffPhone.Clear();
            txtStaffSalary.Clear();
            dtpHiredDate.Value = DateTime.Now;
            rbStoppedWork.Checked = false;
            pbPhoto.Image = null;
        }

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void dataStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataStaff.Rows[e.RowIndex];
                txtID.Text = row.Cells["StaffID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                rbMale.Checked = row.Cells["Sex"].Value.ToString() == "M";
                rbFemale.Checked = row.Cells["Sex"].Value.ToString() == "F";
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                txtStaffPosition.Text = row.Cells["StaffPosition"].Value.ToString();
                txtStaffAddress.Text = row.Cells["StaffAddress"].Value.ToString();
                txtStaffPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtStaffSalary.Text = row.Cells["Salary"].Value.ToString();
                dtpHiredDate.Value = Convert.ToDateTime(row.Cells["HiredDate"].Value);
                rbStoppedWork.Checked = Convert.ToBoolean(row.Cells["StoppedWork"].Value);

                // Load photo if exists
                if (row.Cells["Photo"].Value != DBNull.Value)
                {
                    byte[] photo = (byte[])row.Cells["Photo"].Value;
                    pbPhoto.Image = ByteArrayToImage(photo);
                }
                else
                {
                    pbPhoto.Image = null;
                }
            }
        }



        private void btnBrowsePhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLatestStaffID();
            LoadStaffData();
            txtSearch.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Please select a staff member to update.");
                return;
            }

            int staffID = Convert.ToInt32(txtID.Text.Trim());
            string fullName = txtFullName.Text.Trim();
            string sex = rbMale.Checked ? "M" : "F";
            DateTime birthDate = dtpBirthDate.Value;
            string position = txtStaffPosition.Text.Trim();
            string address = txtStaffAddress.Text.Trim();
            string phone = txtStaffPhone.Text.Trim();
            decimal salary;

            if (!decimal.TryParse(txtStaffSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            DateTime hiredDate = dtpHiredDate.Value;
            bool stoppedWork = rbStoppedWork.Checked;

            byte[] photo = null;
            if (pbPhoto.Image != null)
            {
                photo = ImageToByteArray(pbPhoto.Image);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE tbStaff SET FullName = @FullName, Sex = @Sex, BirthDate = @BirthDate, " +
                                   "StaffPosition = @StaffPosition, StaffAddress = @StaffAddress, PhoneNumber = @PhoneNumber, " +
                                   "Salary = @Salary, HiredDate = @HiredDate, Photo = CASE WHEN @Photo IS NULL THEN NULL ELSE @Photo END, " +
                                   "StoppedWork = @StoppedWork " +
                                   "WHERE StaffID = @StaffID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffID);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Sex", sex);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@StaffPosition", position);
                        cmd.Parameters.AddWithValue("@StaffAddress", address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@HiredDate", hiredDate);
                        cmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = (object)photo ?? DBNull.Value; // Ensure DBNull.Value if photo is null
                        cmd.Parameters.AddWithValue("@StoppedWork", stoppedWork);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Staff member updated successfully.");
                    ClearForm();
                    LoadLatestStaffID();
                    LoadStaffData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

       
    }
}
