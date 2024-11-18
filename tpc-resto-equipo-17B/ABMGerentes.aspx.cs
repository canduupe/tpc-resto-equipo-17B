using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class ABMGerentes : System.Web.UI.Page
    {
        public bool ConfirmaEliminacion{ get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }

            ConfirmaEliminacion = false;

            if (Request.QueryString["Id"]!= null && !IsPostBack)
            {
                GerenteNegocio negocio = new GerenteNegocio();
                List<Gerente> gerentesList = negocio.listar2(Request.QueryString["Id"].ToString());
                Gerente gerenteSeleccionado = gerentesList[0];

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                Usuarios seleccionadoUsuario = new Usuarios();
                seleccionadoUsuario = usuarioNegocio.ObtenerUsuario(gerenteSeleccionado.IdUsuario);

                txtNombre.Text = gerenteSeleccionado.Nombre;
                txtApellido.Text = gerenteSeleccionado.Apellido;
                txtUsuario.Text = seleccionadoUsuario.Usuario;
                txtContraseña.Text = seleccionadoUsuario.Contraseña;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Gerente nuevo = new Gerente();
            GerenteNegocio negocio = new GerenteNegocio();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;

            Usuarios usuarios = new Usuarios();
            usuarios.Usuario = txtUsuario.Text;
            usuarios.Contraseña = txtContraseña.Text;


            if (Request.QueryString["id"] != null)
            {
                nuevo.IdGerente = int.Parse(Request.QueryString["Id"].ToString());///le cargo el ID
                negocio.Modificar(nuevo, usuarios);
            }
            else
                negocio.AgregarSP(nuevo, usuarios);

            Response.Redirect("ListarGerentes.aspx", false);
            
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarGerentes.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmaEliminacion = true;
        }

        protected void btnConfirmaEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (Confirmar.Checked)
                {
                    GerenteNegocio negocio = new GerenteNegocio();
                    List<Gerente> gerentesList = negocio.listar2(Request.QueryString["Id"].ToString());
                    Gerente gerenteSeleccionado = gerentesList[0];

                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    Usuarios seleccionadoUsuario = new Usuarios();
                    seleccionadoUsuario = usuarioNegocio.ObtenerUsuario(gerenteSeleccionado.IdUsuario);

                    negocio.Eliminar(gerenteSeleccionado.IdUsuario);

                    Response.Redirect("ListarGerentes.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
            }
        }
    }
    
}