using appventas.DAO;
using appventas.MODEL;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            Carga();
            Clear();
        }
        void Clear()
        {
            txtIdpro.Clear();
            txtNomp.Clear();
            txtPrecP.Clear();
            txtEdoP.Clear();
        }

        void Carga()
        {
            dtgProduct.Rows.Clear();
            ClsProductos pRoducto = new ClsProductos();
            List<tb_producto> Lista = pRoducto.cargarDatosProducto();

            foreach (var iteracion in Lista)
            {

                dtgProduct.Rows.Add(iteracion.idProducto, iteracion.nombreProducto, iteracion.precioProducto, iteracion.estadoProducto);
            }
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }

        private void dtgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String Id = dtgProduct.CurrentRow.Cells[0].Value.ToString();
            String NombrePro = dtgProduct.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgProduct.CurrentRow.Cells[2].Value.ToString();
            String Estado = dtgProduct.CurrentRow.Cells[3].Value.ToString();

            txtIdpro.Text = Id;
            txtNomp.Text = NombrePro;
            txtPrecP.Text = Precio;
            txtEdoP.Text = Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsProductos clsprod = new ClsProductos();
            tb_producto Prod = new tb_producto();

            Prod.nombreProducto = txtNomp.Text;
            Prod.precioProducto = txtPrecP.Text;
            Prod.estadoProducto = txtEdoP.Text;
            clsprod.SaveDatosProducto(Prod);
            Carga();
            Clear();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            ClsProductos clsP = new ClsProductos();

            tb_producto prd = new tb_producto();
            prd.idProducto = (Convert.ToInt32(txtIdpro.Text));
            prd.nombreProducto = txtNomp.Text;
            prd.precioProducto = txtPrecP.Text;
            prd.estadoProducto = txtEdoP.Text;
            clsP.updateProducto(prd);

            Carga();
            Clear();
        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            ClsProductos produ = new ClsProductos();
            produ.deleteProducto(Convert.ToInt32(txtIdpro.Text));
            MessageBox.Show("Product Deleted");
            Carga();
            Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmMdi frm = new FrmMdi();
            frm.Show();
            this.Hide();
        }
    }
}
