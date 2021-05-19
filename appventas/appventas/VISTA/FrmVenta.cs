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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            //using (sistema_ventasEntities bd = new sistema_ventasEntities())
            //{
            //    var consultacliente = bd.tb_cliente.ToList();

            //    comboBox2.DataSource = consultacliente;
            //    comboBox2.DisplayMember = "nombreCliente";
            //    comboBox2.ValueMember = "iDCliente";

            //    var consultadocumento = bd.tb_documento.ToList();
            //    comboBox1.DataSource = consultadocumento;
            //    comboBox1.DisplayMember = "nombreDocumento";
            //    comboBox1.ValueMember = "iDDocumento";
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
    }
}
