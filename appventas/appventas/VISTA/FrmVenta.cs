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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        void ultimocorrelativodeventa()
        {
            var consultarultimaventa = new ClsDVenta();

            int lista = 0;

            foreach (var list in consultarultimaventa.UltimaVenta())
            {

                lista = list.iDVenta;
            }

            lista++;
            txtNumPro.Text = lista.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            ultimocorrelativodeventa();

            //using (sistema_ventasEntities bd = new sistema_ventasEntities())
            //{
            //    var consultacliente = bd.tb_cliente.ToList();

            //    comboBox2.DataSource = consultacliente;
            //    comboBox2.DisplayMember = "nombreCliente";
            //    comboBox2.ValueMember = "iDCliente";

            //    var consultadocumento = bd.tb_documento.ToList();
            //    comboBox1.DataSource = consultadocumento;
            //    comboBox1.DisplayMember = "nombreDocumento";
            //    comboBox1.ValueMember = "iDDocumento"
            //}
            ClsClientes clsclientes = new ClsClientes();

            comboBox2.DataSource = clsclientes.cargarDatosClientes();
            comboBox2.DisplayMember = "nombreCliente";
            comboBox2.ValueMember = "iDCliente";

            ClsDocs clsDocs = new ClsDocs();
            comboBox1.DataSource = clsDocs.cargarDatosDoc();
            comboBox1.DisplayMember = "nombreDocumento";
            comboBox1.ValueMember = "iDDocumento";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFiltroProducto buscar = new FrmFiltroProducto();
            buscar.Show();
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
        void calcular()
        {
            try
            {
                Double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCant.Text);
                precio = Convert.ToDouble(txtPrec.Text);

                total = precio * cantidad;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                if (txtCant.Text.Equals(""))
                {
                    txtCant.Text = "1";
                    txtCant.SelectAll();

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            calcular();
            calculartotal();
            dataGridView1.Rows.Add(txtId.Text,txtNom.Text,txtPrec.Text,txtCant.Text,txtTotal.Text);

            txtId.Clear();
            txtNom.Clear();
            txtPrec.Clear();
            txtCant.Clear();
            txtTotal.Clear();

            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
            int ultimafila = dataGridView1.Rows.Count - 1;
            dataGridView1.FirstDisplayedScrollingRowIndex = ultimafila;
            dataGridView1.Rows[ultimafila].Selected = true;
        }

        private void txtBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (txtBus.Text.Equals(""))
                {
                    btnBuscar.PerformClick();
                    e.Handled = true;
                    //txtCant.Focus();

                }
                else
                {
                    e.Handled = true;
                    ClsProductos prod = new ClsProductos();
                    var busqueda = prod.BuscarProducto(Convert.ToInt32(txtBus.Text));

                    if (busqueda.Count<1) {

                        MessageBox.Show("No se ha encontrado coincidencias");
                        txtBus.Text = "";
                    
                    }
                    foreach (var iterar in busqueda)
                    {

                        txtId.Text = iterar.idProducto.ToString();
                        txtNom.Text = iterar.nombreProducto;
                        txtPrec.Text = iterar.precioProducto.ToString();
                        txtCant.Text = "1";
                        txtCant.Focus();
                        txtBus.Text = "";

                    }
                }
           
        }
        void calculartotal()
        {
            Double suma = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                //String Precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String datosaoperartotal = dataGridView1.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosaoperartotal);

                suma += DatosConvertidos;

                txtTF.Text = suma.ToString();


            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregar.PerformClick();
                e.Handled = true;
                txtBus.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try {
                ClsDVenta ventas = new ClsDVenta();
                tb_venta venta = new tb_venta();

                venta.iDDocumento = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTF.Text);
                venta.fecha = Convert.ToDateTime(dateTimePicker1.Text);
                ventas.save(venta);


                ClsDDetalle detalle = new ClsDDetalle();
                tb_detalleVenta tbdetalle = new tb_detalleVenta();

                foreach (DataGridViewRow dtgv in dataGridView1.Rows)
                {
                    tbdetalle.iDVenta = Convert.ToInt32(txtNumPro.Text);
                    tbdetalle.iDProducto = Convert.ToInt32(dtgv.Cells[0].Value.ToString());
                    tbdetalle.cantidad = Convert.ToInt32(dtgv.Cells[3].Value.ToString());
                    tbdetalle.precio = Convert.ToDecimal(dtgv.Cells[2].Value.ToString());
                    tbdetalle.total = Convert.ToDecimal(dtgv.Cells[4].Value.ToString());

                    detalle.guardardetalleventa(tbdetalle);
                }

                ultimocorrelativodeventa();
                dataGridView1.Rows.Clear();
                txtTF.Text = "";


                MessageBox.Show("Save");
            }
            catch (Exception ex) {

                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotal();
        }
    }
}
