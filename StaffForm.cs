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
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_SizeChanged(object sender, EventArgs e)
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
    }
}
