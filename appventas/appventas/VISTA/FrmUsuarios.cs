using System;
using appventas.MODEL;
using appventas.DAO;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
            Clear();
        }
        void Clear()
        {
            txtUsId.Clear();
            txtEmail.Clear();
            txtPass.Clear();
        }

        void Carga()
        {
            dataGridView1.Rows.Clear();
            ClsUsuarios usier = new ClsUsuarios();
            List<tb_usuario> Lista = usier.cargarDatosUsuarios();

            foreach (var iteracion in Lista)
            {

                dataGridView1.Rows.Add(iteracion.iDUsuario,iteracion.email,iteracion.contrasena);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String Email = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String Pass = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txtUsId.Text = Id;
            txtEmail.Text = Email;
            txtPass.Text = Pass;
        }

        private void btnGua_Click(object sender, EventArgs e)
        {
            ClsUsuarios clsUsuarios = new ClsUsuarios();
            tb_usuario usuario = new tb_usuario();

            usuario.email = txtEmail.Text;
            usuario.contrasena = txtPass.Text;
            clsUsuarios.SaveDatosUsuario(usuario);
            Carga();
            Clear();
        }

        private void btnACT_Click(object sender, EventArgs e)
        {
            ClsUsuarios cLsusuario = new ClsUsuarios();

            tb_usuario us = new tb_usuario();
            us.iDUsuario = (Convert.ToInt32(txtUsId.Text));
            us.email = txtEmail.Text;
            us.contrasena = txtPass.Text;
            cLsusuario.updateUsuario(us);

            Carga();
            Clear();
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            ClsUsuarios US = new ClsUsuarios();
            US.deleteUsuario(Convert.ToInt32(txtUsId.Text));
            MessageBox.Show("User Deleted");
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
