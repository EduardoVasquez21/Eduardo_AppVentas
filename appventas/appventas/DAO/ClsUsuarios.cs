using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsUsuarios
    {
        public List<tb_usuario> cargarDatosUsuarios()
        {
            List<tb_usuario> Lista;


            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_usuario.ToList();


            }
            return Lista;
        }

        public void SaveDatosUsuario(tb_usuario useer)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_usuario usuerList = new tb_usuario();

                    usuerList.email = useer.email;
                    usuerList.contrasena = useer.contrasena;
                    db.tb_usuario.Add(usuerList);
                    db.SaveChanges();

                    MessageBox.Show("Usuario Saved");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void updateUsuario(tb_usuario duser)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = (Convert.ToInt32(duser.iDUsuario));
                    tb_usuario uder = db.tb_usuario.Where(x => x.iDUsuario == update).Select(x => x).FirstOrDefault();

                    uder.email = duser.email;
                    uder.contrasena = duser.contrasena;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteUsuario(int iD)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_usuario useer = db.tb_usuario.Where(x => x.iDUsuario == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_usuario.Remove(useer);
                    db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }
    }
}
