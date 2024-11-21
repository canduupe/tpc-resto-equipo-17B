using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

namespace tpc_resto_equipo_17B
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            try
            {
                usuario = new Usuarios(txtUsser.Text, txtContra.Text, false);
                if (usuarioNegocio.Login(usuario))
                {
                    Session.Add("usuario", usuario);
                    if(usuario.TipoUsuario == tipoUsuario.MESERO)
                    {
                        Session.Add("Meser", usuario.Id);
                    }
                    
                    Response.Redirect("Articulos.aspx", false);
                }
                else
                {
                    Session.Add("ERROR", "Revise su usuario o contraseña, si el problema persiste, usted no pertenece al resto Rudo´s");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}