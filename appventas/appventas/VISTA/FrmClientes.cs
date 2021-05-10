using appventas.MODEL;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            Carga();
            Clear();
        }

        void Clear()
        {
            txtIdCl.Clear();
            txtNomCl.Clear();
            txtDirecCl.Clear();
            txtDuiCl.Clear();
        }


        void Carga()
        {
            dataGridView1.Rows.Clear();
            ClsClientes user = new ClsClientes();
            List<tb_cliente> Lista = user.cargarDatosClientes();

            foreach (var iteracion in Lista)
            {

                dataGridView1.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente, iteracion.duiCliente);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String Dui = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            txtIdCl.Text = Id;
            txtNomCl.Text = Nombre;
            txtDirecCl.Text = Direccion;
            txtDuiCl.Text = Dui;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ClsClientes clsClientes = new ClsClientes();
            tb_cliente cliente = new tb_cliente();

            //cliente.iDCliente = Convert.ToInt32(txtIdCl.Text);
            cliente.nombreCliente = txtNomCl.Text;
            cliente.direccionCliente = txtDirecCl.Text;
            cliente.duiCliente = txtDuiCl.Text;
            clsClientes.SaveDatosUser(cliente);
            Carga();
            Clear();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            ClsClientes clsClientes = new ClsClientes();

            tb_cliente cliente = new tb_cliente();
            cliente.iDCliente = (Convert.ToInt32(txtIdCl.Text));
            cliente.nombreCliente = txtNomCl.Text;
            cliente.direccionCliente = txtDirecCl.Text;
            cliente.duiCliente = txtDuiCl.Text;
            clsClientes.updateCliente(cliente);

            Carga();
            Clear();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ClsClientes us = new ClsClientes();
            us.deleteUser(Convert.ToInt32(txtIdCl.Text));
            MessageBox.Show("Deleted");
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
