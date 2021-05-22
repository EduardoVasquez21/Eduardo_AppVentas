using appventas.DAO;
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
    public partial class FrmFiltroProducto : Form
    {
        public FrmFiltroProducto()
        {
            InitializeComponent();
        }

        void cargardatos()
        {
            var clsProductos = new ClsProductos();
            dtgFiltro.Rows.Clear();

            foreach(var listarDatos in clsProductos.CargarProductosFiltro(txtFiltro.Text)) {

                dtgFiltro.Rows.Add(listarDatos.idProducto,listarDatos.nombreProducto,listarDatos.precioProducto);

            }

        }

        private void FrmFiltroProducto_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtgFiltro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        void envio()
        {
            String id = dtgFiltro.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgFiltro.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgFiltro.CurrentRow.Cells[2].Value.ToString();

            //FrmVenta frmVenta = new FrmVenta();
            //frmVenta.txtId.Text = id;
            //frmVenta.txtNom.Text = nombre;
            //frmVenta.txtPrec.Text = precio;
            //frmVenta.Show();

            FrmMenuVenta.frmVenta.txtId.Text = id;
            FrmMenuVenta.frmVenta.txtNom.Text = Nombre;
            FrmMenuVenta.frmVenta.txtPrec.Text = Precio;
            FrmMenuVenta.frmVenta.txtCant.Focus();

            this.Close();
        }

        private void dtgFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        private void dtgFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                envio();
            }
        }
    }
}
