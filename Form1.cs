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
            //this.PanelForm.MaximumSize = new Size(this.PanelForm.Width, sideBar.Height);
            //this.PanelForm.Size = new Size(this.Width - sideBar.Width, sideBar.Height);
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
        int i, j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                this.PanelForm.Dock = DockStyle.None;

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
                    this.PanelForm.Dock = DockStyle.Fill;
                    this.PanelForm.Show();
                    sideBarTransition.Stop();
                    i++;
                }

            }
            else
            {
                this.PanelForm.Dock = DockStyle.None;

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

                if (sideBar.Width > 235)
                {
                    sideBarExpand = true;
                    this.PanelForm.Dock = DockStyle.Fill;
                    this.PanelForm.Show();
                    sideBarTransition.Stop();
                    j++;
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.PanelForm.Hide();
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
    }
}