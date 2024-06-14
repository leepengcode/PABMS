namespace PABMS
{
    public partial class mainpanel1 : Form
    {
        public mainpanel1()
        {
            InitializeComponent();
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

        private void Form1_Load(object Form, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            loadForm(new TicketForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }

        private void btnBagage_Click(object sender, EventArgs e)
        {
            loadForm(new BagageForm());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            loadForm(new VehicleForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            loadForm(new StaffForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            loadForm(new UserForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            loadForm(new PaymentForm());
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
                btnBagage.Text = removeChar(btnBagage.Text);
                btnVehicle.Text = removeChar(btnVehicle.Text);
                btnTicket.Text = removeChar(btnTicket.Text);
                btnPayment.Text = removeChar(btnPayment.Text);

                if (sideBar.Width < 85)
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
                    btnBagage.Text = "Bagage";
                    btnVehicle.Text = "Vehicle";
                    btnTicket.Text = "Ticket";
                    btnPayment.Text = "Payment";
                }

                if (sideBar.Width > 266)
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