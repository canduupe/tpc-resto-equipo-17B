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
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (!Helper.EsGerente(Session["Usuario"]))
            {
                Response.Redirect("Error.aspx", false);
            }
            */

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

                negocio.agregarSP(nuevo);
                Response.Redirect("Articulos.aspx", false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}