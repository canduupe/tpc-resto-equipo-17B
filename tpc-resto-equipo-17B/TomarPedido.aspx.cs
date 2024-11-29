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
    public partial class TomarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

            List<Articulo> articuloLista;

            ArticuloNegocio objListar = new ArticuloNegocio();
            articuloLista = objListar.listar();
            dgvCartita.DataSource = articuloLista;
            dgvCartita.DataBind();

            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void dgvCartita_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IdArti = int.Parse(dgvCartita.SelectedDataKey["IdArticulo"].ToString());
                float Preci = float.Parse(dgvCartita.SelectedDataKey["Precio"].ToString());
                int mese = int.Parse(Session["Meser"].ToString());
                int IdPedido = 4; //int.Parse(Request.QueryString["IdPedido"].ToString());
                


                PedidosNegocio negocio = new PedidosNegocio();
                negocio.AgregarConSp(IdArti, mese, IdPedido, Preci);
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
            }

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MesasMeseros.aspx", false);
        }

        protected void btnDetalle_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Orden.aspx", false);
        }
    }
}