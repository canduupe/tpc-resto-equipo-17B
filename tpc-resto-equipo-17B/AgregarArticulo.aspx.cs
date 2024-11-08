using NEGOCIO;
using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class AgregarArticulo : System.Web.UI.Page
    {
        public bool ConfirmarEliminacionArt { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }
            ConfirmarEliminacionArt = false;

            try
            {
                if (!IsPostBack)
                {
                    TipoArticuloNegocio negocio = new TipoArticuloNegocio();
                    List<TipoArticulo> lista = negocio.listar();

                    CBTipoArt.DataSource = lista;
                    CBTipoArt.DataValueField = "Id";
                    CBTipoArt.DataTextField = "Descripcion";
                    CBTipoArt.DataBind();
                }

                string Id = Request.QueryString["Id"] != null ? Request.QueryString["Id"].ToString() : "";
                if (Id != "" && !IsPostBack)
                {
                    
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    Articulo selecionado = (negocio.listar2(Id))[0];

                    txtNombreArt.Text = selecionado.Nombre;
                    txtDescripcionArt.Text = selecionado.Descripcion;
                    txtPrecioArt.Text = selecionado.Precio.ToString();
                    txtCantidadArt.Text = selecionado.CantidadDisponible.ToString();

                    CBTipoArt.SelectedValue = selecionado.Tipo.ToString();
                
                    }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnAgregarArt_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo nuevo = new Articulo();
                ArticuloNegocio negocio = new ArticuloNegocio();

                nuevo.Nombre = txtNombreArt.Text;
                nuevo.Descripcion = txtDescripcionArt.Text;
                nuevo.Precio = int.Parse(txtPrecioArt.Text);
                nuevo.CantidadDisponible = int.Parse(txtCantidadArt.Text);
                nuevo.Tipo = int.Parse(CBTipoArt.SelectedValue);

                if (Request.QueryString["Id"] != null)
                {
                    nuevo.IdArticulo = int.Parse(Request.QueryString["Id"].ToString());
                    negocio.modificarSP(nuevo);
                }
                else { 
                negocio.agregarSP(nuevo);
                 }
                Response.Redirect("Articulos.aspx", false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulos.aspx", false);
        }

        protected void btnEliminarArt_Click(object sender, EventArgs e)
        {
            ConfirmarEliminacionArt = true;
        }

        protected void btnConfirmaArt_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfirmarEliminacionArt)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.eliminar(int.Parse(Request.QueryString["Id"].ToString()));
                    Response.Redirect("Articulos.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
            }
        }
    }
}