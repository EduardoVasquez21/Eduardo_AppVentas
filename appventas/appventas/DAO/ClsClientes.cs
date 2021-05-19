using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsClientes
    {
        public List<tb_cliente> cargarDatosClientes()
        {
            List<tb_cliente> Lista;


            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_cliente.ToList();


            }
            return Lista;
        }

        public void SaveDatosUser(tb_cliente user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_cliente userList = new tb_cliente();

                    userList.nombreCliente = user.nombreCliente;
                    userList.direccionCliente = user.direccionCliente;
                    userList.duiCliente = user.duiCliente;
                    db.tb_cliente.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        public void updateCliente(tb_cliente user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = (Convert.ToInt32(user.iDCliente));
                    tb_cliente cliente = db.tb_cliente.Where(x => x.iDCliente == update).Select(x => x).FirstOrDefault();


                    cliente.nombreCliente = user.nombreCliente;
                    cliente.direccionCliente = user.direccionCliente;
                    cliente.duiCliente = user.duiCliente;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteUser(int iD)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_cliente cliente = db.tb_cliente.Where(x => x.iDCliente == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_cliente.Remove(cliente);
                    db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        //public List<tb_cliente> CargarComboCliente()
        //{
        //    List<tb_cliente> tb_Cliente = new List<tb_cliente>();
        //    using (sistema_ventasEntities db = new sistema_ventasEntities())
        //    {
        //        tb_Cliente = db.tb_cliente.ToList();


        //    }
        //    return tb_Cliente;
        //}
    }
}
