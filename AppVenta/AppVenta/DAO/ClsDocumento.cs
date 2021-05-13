using AppVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DAO
{
    class ClsDocumento
    {
        public List<tb_documento> cargarDatoUserList()

        {
            List<tb_documento> Lista;

            using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
            {
                Lista = db.tb_documento.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(tb_documento user)
        {
            try
            {
                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {

                    tb_documento userList = new tb_documento();

                    userList.nombreDocumento = user.nombreDocumento;



                    db.tb_documento.Add(userList);
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
                    tb_documento userList = db.tb_documento.Where(x => x.iDDocumento == eliminar).Select(x => x).FirstOrDefault();


                    db.tb_documento.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateUser(tb_documento user)
        {
            try
            {


                using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
                {

                    int update = Convert.ToInt32(user.iDDocumento);
                    tb_documento userList = db.tb_documento.Where(x => x.iDDocumento == update).Select(x => x).FirstOrDefault();

                    userList.nombreDocumento = user.nombreDocumento;

                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}

