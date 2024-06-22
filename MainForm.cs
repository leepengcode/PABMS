using System.Data.SqlClient;
namespace PABMS
{
    public partial class MainForm : Form
    {
        SqlConnection cnn = new SqlConnection();

        public MainForm()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketForm f = new TicketForm();
            loadForm(f);
            f.changeSize();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(69);
            loadForm(f);
            f.changeSize();
        }

        private void btnBagage_Click(object sender, EventArgs e)
        {
            loadForm(new BagageForm());
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            loadForm(new DriverForm());
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

                if (sideBar.Width < 85)
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
                }

                if (sideBar.Width > 235)
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
            //PanelForm.Location = new Point(sideBar.Right + 10, sideBar.Height);

        }
    }
}