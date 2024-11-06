using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public static class Helper
    {
        public static bool SessionActiva(Object user) 
        {
            Usuarios usuarios = user != null ? (Usuarios)user : null;
            if (usuarios != null && usuarios.Id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EsGerente(object user)
        {
            Usuarios usuarios = user as Usuarios; 
            return usuarios != null && usuarios.TipoUsuario == tipoUsuario.GERENTE;
        }
    }
}
