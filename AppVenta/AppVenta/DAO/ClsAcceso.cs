using AppVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DAO
{
    class ClsAcceso
    {
        public int Acceso(string usuario, string password)
        {
            int variabledeacceso = 0;

            using (sistema_ventasEntities3 bd = new sistema_ventasEntities3() )
            {

                var consulta = from user in bd.tb_usuario
                               where user.email == usuario && user.contrasena == password
                               select user;

                if (consulta.Count()>0)
                {
                    variabledeacceso = 1;
                    
                }


            }

            return variabledeacceso;

        }



    }
}
