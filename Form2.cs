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
    public partial class Form2 : Form
    {
        public Form2(int num)
        { 
            InitializeComponent();
            txtBusID.Text = num.ToString();
        }
        public void changeSize()
        {
            panelTitle.Width = this.Width;
            panelMain.Width = this.Width;
            tlpButtons.Width = this.Width;
        }
    }
}
