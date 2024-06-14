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
    public partial class PaymentForm : Form
    {

        public class User
        {
            public string PaymentID { get; set; }
            public string PaymentDate { get; set; }
            public string PaymentAmount { get; set; }
            public string IsTraveling { get; set; }
        }

        List<User> users = new List<User>();
        List<User> temp_search = new List<User>();
        List<Control> sortedControls = new List<Control>();

        string[] tableColumns = new string[]
        {
            "PaymentID",
            "PaymentDate",
            "PaymentAmount",
            "IsTraveling"
        };
        public PaymentForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(pressEnter);
            this.KeyPreview = true;
            //this.Shown += new EventHandler(PaymentForm_Shown);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            List<Control> allControls = GetAllControls(this);
            sortedControls = allControls.OrderBy(c => c.TabIndex).ToList();

            for (int i = 0; i < sortedControls.Count; i++)
            {
                Console.WriteLine($"{sortedControls[i].Name}: TabIndex = {sortedControls[i].TabIndex}");
            }
            temp_search.AddRange(users);

            // Connection to Database
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            /*while (reader.Read())
            {
                User user = new User();
                user.PaymentID = reader["PaymentID"].ToString();
                user.PaymentDate = reader["PaymentDate"].ToString();
                user.PaymentAmount = reader["PaymentAmount"].ToString();
                user.IsTraveling = reader["IsTraveling"].ToString();
                users.Add(user);
            }*/


            // populate this user to the listbox
            foreach (User user in users)
            {
                LBPayment.Items.Add(user.PaymentID);
            }
        }

        private void PaymentForm_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(
                this.Width - Convert.ToInt16(this.Width * 0.2),
                this.Height - Convert.ToInt16(this.Height * 0.2)
            );

            panel1.Location = new Point(
                this.Width / 2 - panel1.Width / 2,
                this.Height / 2 - panel1.Height / 2
            );
        }

        private void LBPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LBPayment.SelectedIndex;
            User user = users[index];
            TBPaymentNo.Text = user.PaymentID;
            TBTicketID.Text = user.PaymentDate;
            TBTicketID.Text = user.PaymentAmount;
            TBCustomerID.Text = user.IsTraveling;
        }

        void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MoveToNextControl();
            }
        }

        private List<Control> GetAllControls(Control container)
        {
            List<Control> controls = new List<Control>();
            foreach (Control control in container.Controls)
            {
                if (control is TextBox || control is ComboBox)
                    controls.Add(control);
                if (control.HasChildren)
                {
                    controls.AddRange(GetAllControls(control));
                }
            }
            return controls;
        }

        int i = 0;
        private void MoveToNextControl()
        {
            if (sortedControls.Count == i)
                i = 0;
            sortedControls[i].Focus();
            i++;
        }

        // create a function that runs 10 seconds after form is loaded
        private async void PaymentForm_Shown(object sender, EventArgs e)
        {
            await Task.Delay(1500);
            foreach (Control control in sortedControls)
            {
                control.Text = "LMAO";
            }
        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
