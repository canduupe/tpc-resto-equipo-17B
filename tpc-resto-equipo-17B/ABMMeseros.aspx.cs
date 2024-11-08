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
        public bool ConfirmarEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }

            ConfirmarEliminacion = false;
            //Modificacion
            if (Request.QueryString["id"] != null && !IsPostBack)
            {
                MeseroNegocio negocio = new MeseroNegocio();
                List<Mesero> lista = negocio.listar2(Request.QueryString["id"].ToString());
                Mesero meseroseleccionado = lista[0];

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                Usuarios seleccionadoUsuario = new Usuarios();
                seleccionadoUsuario = usuarioNegocio.ObtenerUsuario(meseroseleccionado.IdUsuario);

                txtNombre.Text = meseroseleccionado.Nombre;
                txtApellido.Text = meseroseleccionado.Apellido;
                txtUsuario.Text = seleccionadoUsuario.Usuario;
                txtContraseña.Text = seleccionadoUsuario.Contraseña;
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

                Usuarios usuarios = new Usuarios();
                usuarios.Usuario = txtUsuario.Text; 
                usuarios.Contraseña = txtContraseña.Text;
               

                if(Request.QueryString["id"] != null)
                {
                    nuevo.IdMesero = int.Parse(Request.QueryString["id"].ToString());///le cargo el ID
                    negocio.Modificar(nuevo, usuarios);
                }
                else
                    negocio.AgregarSP(nuevo, usuarios);


                Response.Redirect("ListaMeseros.aspx", false);
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


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmarEliminacion = true;
        }
        protected void btnConfirmaEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfirmarEli.Checked)
                {
                    MeseroNegocio negocio = new MeseroNegocio();
                    List<Mesero> meseList = negocio.listar2(Request.QueryString["Id"].ToString());
                    Mesero Seleccionado = meseList[0];

                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    Usuarios seleccionadoUsuario = new Usuarios();
                    seleccionadoUsuario = usuarioNegocio.ObtenerUsuario(Seleccionado.IdUsuario);

                    negocio.Eliminar(Seleccionado.IdUsuario);

                    Response.Redirect("ListaMeseros.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
            }
        }
    }

}