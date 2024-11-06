using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public static class Helper
    {
        public static bool SessionActiva(Object obj) //resive object asi es una clase generica ya que puede revisar cualquiero cosa
        {
            Usuarios usuarios = obj != null ? (Usuarios)obj : null;
            if (usuarios != null && usuarios.Id != 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }



        /*public static bool EsAdmin(Object user)
        {
            Usuarios usuarios = user != null ? (Usuarios)user : null;
            return usuarios;

        }*/

        public static bool EsAdmin(object user)
        {
            Usuarios usuarios = user as Usuarios; 

            
            return usuarios != null && usuarios.TipoUsuario == tipoUsuario.GERENTE;
        }



    }
}
