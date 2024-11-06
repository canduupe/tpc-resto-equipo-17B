using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class UsuarioNegocio
    {
        public bool Login(Usuarios usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Usuario, Contraseña, TipoUsuario from Usuarios where Usuario = @Usser AND Contraseña = @Pass");
                datos.setearParametro("@Usser", usuario.Usuario);
                datos.setearParametro("@Pass",usuario.Contraseña);

                datos.realizarLectura();

                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = (int)(datos.Lector["TipoUsuario"]) == 2 ? tipoUsuario.MESERO : tipoUsuario.GERENTE;

                    return true;
                }
                return false;   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
