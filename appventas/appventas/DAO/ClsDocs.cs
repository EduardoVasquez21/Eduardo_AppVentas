using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsDocs
    {
        public List<tb_documento> cargarDatosDoc()
        {
            List<tb_documento> Listas;


            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Listas = db.tb_documento.ToList();


            }
            return Listas;
        }

        public void SaveDatosDoc(tb_documento doc)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_documento DocList = new tb_documento();

                    DocList.nombreDocumento = doc.nombreDocumento;
                    db.tb_documento.Add(DocList);
                    db.SaveChanges();

                    MessageBox.Show("Document Saved");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        public void updateDatos (tb_documento docc)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = (Convert.ToInt32(docc.iDDocumento));
                    tb_documento docs = db.tb_documento.Where(x => x.iDDocumento == update).Select(x => x).FirstOrDefault();

                    docs.nombreDocumento = docc.nombreDocumento;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteDatos(int iD)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_documento docx = db.tb_documento.Where(x => x.iDDocumento == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_documento.Remove(docx);
                    db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        //public List<tb_documento> CargarComboDoc()
        //{
        //    List<tb_documento> tb_Documentos = new List<tb_documento>();


        //    using (sistema_ventasEntities db = new sistema_ventasEntities())
        //    {
        //        tb_Documentos = db.tb_documento.ToList();


        //    }
        //    return tb_Documentos;
        //}
    }
}
