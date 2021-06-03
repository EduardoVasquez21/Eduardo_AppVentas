using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDDetalle
    {
        public void guardardetalleventa(tb_detalleVenta detalle)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_detalleVenta tbDetalle = new tb_detalleVenta();
                tbDetalle.iDVenta = detalle.iDVenta;
                tbDetalle.iDProducto = detalle.iDProducto;
                tbDetalle.cantidad = detalle.cantidad;
                tbDetalle.precio = detalle.precio;
                tbDetalle.total = detalle.total;
                bd.tb_detalleVenta.Add(tbDetalle);
                bd.SaveChanges();


            }
        }
    }
}
