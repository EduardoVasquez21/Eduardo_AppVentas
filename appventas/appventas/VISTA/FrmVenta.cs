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
                if (txtCant.Text.Equals("")) {
                    txtCant.Text = "0";
                    txtCant.SelectAll();
                
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtId.Text,txtNom.Text,txtPrec.Text,txtCant.Text,txtTotal.Text);

            Double suma = 0;

            for (int i= 0; i<dataGridView1.Rows.Count; i++) {

                //String Precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String datosaoperartotal = dataGridView1.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosaoperartotal);

                suma += DatosConvertidos;

                txtTF.Text = suma.ToString();

                txtId.Clear();
                txtNom.Clear();
                txtPrec.Clear();
                txtCant.Clear();
                txtTotal.Clear();

                FrmMenuVenta.frmVenta.txtBus.Focus();
            }
        }

        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();

        }
    }
}
