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
    public partial class FrmDocumentos : Form
    {
        public FrmDocumentos()
        {
            InitializeComponent();
            Carga();
            Clear();
        }
        void Clear()
        {
            txtDocId.Clear();
            txtDocTipo.Clear();
        }


        void Carga()
        {
            dtgDoc.Rows.Clear();
            ClsDocs doc = new ClsDocs();
            List<tb_documento> Lista = doc.cargarDatosDoc();

            foreach (var iteracion in Lista)
            {

                dtgDoc.Rows.Add(iteracion.iDDocumento, iteracion.nombreDocumento);
            }
        }

        private void dtgDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgDoc.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgDoc.CurrentRow.Cells[1].Value.ToString();

            txtDocId.Text = Id;
            txtDocTipo.Text = Nombre;
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClsDocs dox = new ClsDocs();
            tb_documento documento = new tb_documento();
            documento.nombreDocumento = txtDocTipo.Text;
            dox.SaveDatosDoc(documento);
            Carga();
            Clear();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            ClsDocs clsDocs = new ClsDocs();

            tb_documento docu = new tb_documento();
            docu.iDDocumento = (Convert.ToInt32(txtDocId.Text));
            docu.nombreDocumento = txtDocTipo.Text;
            clsDocs.updateDatos(docu);

            Carga();
            Clear();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            ClsDocs docxx = new ClsDocs();
            docxx.deleteDatos(Convert.ToInt32(txtDocId.Text));
            MessageBox.Show("Document Deleted");
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
