using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;

namespace tpc_resto_equipo_17B
{
    public partial class ABM_Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {              
                Response.Redirect("Error.aspx", false);
            }
        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Mesero nuevo = new Mesero();
                MeseroNegocio negocio = new MeseroNegocio(); 
                
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;

                nuevo.contraseña = new Usuarios();
                nuevo.contraseña.Contraseña = txtContraseña.Text;
                nuevo.usuario = new Usuarios();
                nuevo.usuario.Usuario = txtUsuario.Text;
               
                negocio.AgregarSP(nuevo);
                
            }


            catch (Exception ex)
            {
                Session.Add("ERROR", ex);
                
            }


        }



        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx", false);
        }
    }



}