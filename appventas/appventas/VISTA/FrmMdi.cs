using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTA
{
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome :)");
            FrmClientes frm = new FrmClientes();
            frm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Tb_Docs :)");
            FrmDocumentos frm = new FrmDocumentos();
            frm.Show();
            this.Hide();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.Show();
            this.Hide();
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
            this.Hide();
        }
    }
}
