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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
        }

        private void TicketForm_DockChanged(object sender, EventArgs e)
        {

        }

        public void changeSize()
        {
            panel1.Width = this.Width;
            panelTitle.Width = this.Width;
            splitMain.Width = this.Width;
            tlpButtons.Width = this.Width;
        }

        private void TicketForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 1680)
                return;
            panel1.Width = this.Width;
            panelTitle.Width = this.Width;
            splitMain.Width = this.Width;
            tlpButtons.Width = this.Width;

        }

        private void splitMain_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
