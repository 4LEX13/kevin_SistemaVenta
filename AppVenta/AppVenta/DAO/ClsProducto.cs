using AppVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DAO
{
    class ClsProducto
    {


        public List<tb_producto> cargarProductoFiltro(String filtro)

        {
            List<tb_producto> tb_Productos = new List<tb_producto>();

            using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
            {
                tb_Productos = (from listadeproductos in db.tb_producto
                                where listadeproductos.nombreProducto.Contains(filtro)
                                select listadeproductos).ToList();



            }

            return tb_Productos;
        }


        public void SaveDatosUser(tb_producto user)
        {
            try
            {
                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {

                    tb_producto userList = new tb_producto();

                    userList.nombreProducto = user.nombreProducto;
                    userList.precioProducto = user.precioProducto;
                    userList.estadoProducto = user.estadoProducto;

                    db.tb_producto.Add(userList);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteUser(int ID)
        {
            try
            {
                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {
                    int eliminar = Convert.ToInt32(ID);
                    tb_producto userList = db.tb_producto.Where(x => x.idProducto == eliminar).Select(x => x).FirstOrDefault();


                    db.tb_producto.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateUser(tb_producto user)
        {
            try
            {


                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {

                    int update = Convert.ToInt32(user.idProducto);
                    tb_producto userList = db.tb_producto.Where(x => x.idProducto == update).Select(x => x).FirstOrDefault();

                    userList.nombreProducto = user.nombreProducto;
                    userList.precioProducto = user.precioProducto;
                    userList.estadoProducto = user.estadoProducto;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }

    }
}

