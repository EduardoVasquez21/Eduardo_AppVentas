using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsProductos
    {
        public List<tb_producto> cargarDatosProducto()
        {
            List<tb_producto> Lista;


            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_producto.ToList();


            }
            return Lista;
        }

        public void SaveDatosProducto(tb_producto product)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_producto productList = new tb_producto();

                    productList.nombreProducto = product.nombreProducto;
                    productList.precioProducto = product.precioProducto;
                    productList.estadoProducto = product.estadoProducto;
                    db.tb_producto.Add(productList);
                    db.SaveChanges();

                    MessageBox.Show("Product Saved");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void updateProducto(tb_producto proof)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = (Convert.ToInt32(proof.idProducto));
                    tb_producto Prodd = db.tb_producto.Where(x => x.idProducto == update).Select(x => x).FirstOrDefault();

                    Prodd.nombreProducto = proof.nombreProducto;
                    Prodd.precioProducto = proof.precioProducto;
                    Prodd.estadoProducto = proof.estadoProducto;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteProducto(int iD)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    tb_producto dPro = db.tb_producto.Where(x => x.idProducto == Eliminar).Select(x => x).FirstOrDefault();
                    db.tb_producto.Remove(dPro);
                    db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        public List<tb_producto> CargarProductosFiltro(String filtro)
        {
            List<tb_producto> tb_Productos = new List<tb_producto>();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_Productos = (from listadproductos in db.tb_producto
                                where listadproductos.nombreProducto.Contains(filtro)
                                select listadproductos).ToList();
            }
            return tb_Productos;
        }

        public List<tb_producto> BuscarProducto(int codigo)
        {
            List<tb_producto> tb_Productos = new List<tb_producto>();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_Productos = (from listadproductos in db.tb_producto
                                where listadproductos.idProducto == codigo
                                select listadproductos).ToList();
            }
            return tb_Productos;
        }
    }
}
