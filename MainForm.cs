using System.Data.SqlClient;

namespace PABMS
{
    public partial class MainForm : Form
    {
        //private string connectionString = "Server=ASUS-EXPERTBOOK\\SQLEXPRESS;Database=ISADE5G5;Integrated Security=True;";
        private string connectionString = "Data Source=LAPTOP-2O9AK3I7\\SQLISADE5;Initial Catalog=ISAD;Integrated Security=True";
        SqlConnection connection;

        FormLogin formLogin;

        public MainForm()
        {
            InitializeComponent();

            formLogin = new FormLogin();
            formLogin.ShowDialog();

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void loadForm(object Form)
        {
            if (this.PanelForm.Controls.Count > 0)
                this.PanelForm.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelForm.Controls.Add(f);
            this.PanelForm.Tag = f;
            f.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketForm f = new TicketForm();
            loadForm(f);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }

        private void btnBagage_Click(object sender, EventArgs e)
        {
            loadForm(new PackageForm());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            loadForm(new StaffForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            loadForm(new BusForm());

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            loadForm(new UserForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            loadForm(new TruckForm());
        }

        bool sideBarExpand = true;
        int i, j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;

                btnDashboard.Text = removeChar(btnDashboard.Text);
                btnStaff.Text = removeChar(btnStaff.Text);
                btnUser.Text = removeChar(btnUser.Text);
                btnBagage.Text = removeChar(btnBagage.Text);
                btnVehicle.Text = removeChar(btnVehicle.Text);
                btnTicket.Text = removeChar(btnTicket.Text);
                btnPayment.Text = removeChar(btnPayment.Text);
                btnCus.Text = removeChar(btnCus.Text);
                btnPayTicket.Text = removeChar(btnPayTicket.Text);
                btnPayPackage.Text = removeChar(btnPayPackage.Text);

                if (sideBar.Width < 101)
                {
                    sideBarExpand = false;
                    sideBarTransition.Stop();
                    i++;
                }

            }
            else
            {
                sideBar.Width += 10;

                if (sideBar.Width > 200)
                {
                    btnDashboard.Text = "Dashboard";
                    btnStaff.Text = "Staff";
                    btnUser.Text = "User";
                    btnBagage.Text = "Bagage";
                    btnVehicle.Text = "Vehicle";
                    btnTicket.Text = "Ticket";
                    btnPayment.Text = "Payment";
                    btnCus.Text = "Customer";
                    btnPayPackage.Text = "Payment Package";
                    btnPayTicket.Text = "Payment Ticket";
                }

                if (sideBar.Width > 319)
                {
                    sideBarExpand = true;
                    sideBarTransition.Stop();
                    j++;
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();

        }

        private string removeChar(string text)
        {
            string ret = "";
            for (int i = 0; i < text.Count() - 1; i++)
            {
                ret += text[i];
            }

            return ret;
        }

        private void PanelForm_SizeChanged(object sender, EventArgs e)
        {

        }

        private void sideBar_SizeChanged(object sender, EventArgs e)
        {
            //this.PanelForm.Size = new Size(this.Width - sideBar.Width, sideBar.Height);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + i + " " + j);
        }

        private void MainPanel_SizeChanged(object sender, EventArgs e)
        {

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            FormLogin.User user;
            user = formLogin.user;
            labelUsername.Text = $"Login as : {user.Username}";
            if (formLogin.isLogin)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new PaymentTicketForm());
        }

        private void btnPayPackage_Click(object sender, EventArgs e)
        {
            loadForm(new PaymentPackageForm(connection));
        }

        private void btnPayTicket_Click(object sender, EventArgs e)
        {
            loadForm(new PaymentTicketForm());
        }


    }
}