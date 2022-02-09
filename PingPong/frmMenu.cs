using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void buttonFacil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(250);
            frm1.Show();
        }
        private void buttonMedio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(150);
            frm1.Show();
        }
        private void buttonDificil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(50);
            frm1.Show();
        }
    }
}
