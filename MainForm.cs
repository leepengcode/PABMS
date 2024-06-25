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
            connection = new SqlConnection(connectionString);



            InitializeComponent();

            /*formLogin = new FormLogin();
            formLogin.ShowDialog();*/

            
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
        private void btnTicket_Click(object sender, EventArgs e)
        {
            loadForm(new TicketForm(connection));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            loadForm(new PackageForm(connection));
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
        private void btnPayPackage_Click(object sender, EventArgs e)
        {
            loadForm(new PaymentPackageForm(connection));
        }

        private void btnPayTicket_Click(object sender, EventArgs e)
        {
            loadForm(new PaymentTicketForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerForm());
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {

            /*FormLogin.User user;
            user = formLogin.user;
            labelUsername.Text = $"Login as : {user.Username}";
            if (formLogin.isLogin)
            {

            }
            else
            {
                this.Close();
            }*/
        }

        bool sideBarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;

                btnDashboard.Text = removeChar(btnDashboard.Text);
                btnStaff.Text = removeChar(btnStaff.Text);
                btnUser.Text = removeChar(btnUser.Text);
                btnPackage.Text = removeChar(btnPackage.Text);
                btnVehicle.Text = removeChar(btnVehicle.Text);
                btnTicket.Text = removeChar(btnTicket.Text);
                btnPayment.Text = removeChar(btnPayment.Text);
                btnCustomer.Text = removeChar(btnCustomer.Text);
                btnPayTicket.Text = removeChar(btnPayTicket.Text);
                btnPayPackage.Text = removeChar(btnPayPackage.Text);

                if (sideBar.Width < 101)
                {
                    sideBarExpand = false;
                    sideBarTransition.Stop();
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
                    btnPackage.Text = "Bagage";
                    btnVehicle.Text = "Vehicle";
                    btnTicket.Text = "Ticket";
                    btnPayment.Text = "Payment";
                    btnCustomer.Text = "Customer";
                    btnPayPackage.Text = "Payment Package";
                    btnPayTicket.Text = "Payment Ticket";
                }

                if (sideBar.Width > 319)
                {
                    sideBarExpand = true;
                    sideBarTransition.Stop();
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
    }
}