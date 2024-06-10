namespace PABMS
{
    public partial class mainpanel1 : Form
    {
        public mainpanel1()
        {
            InitializeComponent();
        }
        public void LordForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object Form, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LordForm(new TicketForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LordForm(new DashboardForm());
        }

        private void btnBagage_Click(object sender, EventArgs e)
        {
            LordForm(new BagageForm());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            LordForm(new VehicleForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            LordForm(new StaffForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LordForm(new UserForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            LordForm(new PaymentForm());
        }

        bool sidbarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidbarExpand)
            {
                sidbar.Width -= 10;
                if (sidbar.Width <= 74)
                {
                    sidbarExpand = false;
                    sidbarTransition.Stop();
                }

            }
            else
            {
                sidbar.Width += 10;
                if (sidbar.Width >= 266)
                {
                    sidbarExpand = true;
                    sidbarTransition.Stop();
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sidbarTransition.Start();
        }
    }
}