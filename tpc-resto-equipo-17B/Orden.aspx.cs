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
    public partial class Orden : System.Web.UI.Page
    {
        List<Ordenes> ListaOrden;   
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                OrdenNegocio objListar = new OrdenNegocio();
                ListaOrden = objListar.Listar();
                DgvOrden.DataSource = ListaOrden;
                DgvOrden.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("ERROR", ex.ToString());
            }

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("TomarPedido.aspx", false);
        }

        protected void BtnCerrarPedido_Click(object sender, EventArgs e)
        {
            OrdenNegocio negocio = new OrdenNegocio();
            try
            {
                negocio.EnviarPedido(4);
                Response.Redirect("Exitoso.aspx", false );

            }
            catch (Exception ex)
            {

                throw ex;
            }


            OrdenNegocio negocio = new OrdenNegocio();
            try
            {
                negocio.EnviarPedido(3);
                Response.Redirect("Exitoso.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        protected void DgvOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdArticulo = int.Parse(DgvOrden.SelectedDataKey["IdArticulo"].ToString());
            OrdenNegocio neg = new OrdenNegocio();
            neg.EliminarArti(IdArticulo);
            DgvOrden.DataSource = neg.Listar();
            DgvOrden.DataBind();


        }
    }
}