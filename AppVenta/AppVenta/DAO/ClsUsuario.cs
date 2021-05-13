using AppVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DAO
{
    class ClsUsuario
    {
        public List<tb_usuario> cargarDatoUserList()

        {
            List<tb_usuario> Lista;

            using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
            {
                Lista = db.tb_usuario.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(tb_usuario user)
        {
            try
            {
                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {

                    tb_usuario userList = new tb_usuario();

                    userList.email = user.email;
                    userList.contrasena = user.contrasena;


                    db.tb_usuario.Add(userList);
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
                    tb_usuario userList = db.tb_usuario.Where(x => x.iDUsuario == eliminar).Select(x => x).FirstOrDefault();


                    db.tb_usuario.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateUser(tb_usuario user)
        {
            try
            {


                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {

                    int update = Convert.ToInt32(user.iDUsuario);
                    tb_usuario userList = db.tb_usuario.Where(x => x.iDUsuario == update).Select(x => x).FirstOrDefault();

                    userList.email = user.email;
                    userList.contrasena = user.contrasena;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}

