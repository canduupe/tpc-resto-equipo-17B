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
    public partial class MesasMeseros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Mesa> ListaMesa;
                MesaNegocio negocio = new MesaNegocio();
                ListaMesa = negocio.ListarPorMesero();
                repeaterCards.DataSource = ListaMesa;
                repeaterCards.DataBind();
            }

        }

        protected void btnIniciarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos nuevo = new Pedidos();
                PedidosNegocio negocio = new PedidosNegocio();
                string valor = ((Button)sender).CommandArgument;

                nuevo.FechaPedido = DateTime.Now;
                nuevo.IdMesa = int.Parse(valor);
                negocio.NuevoPedido(nuevo);

                Response.Redirect("TomarPedido.aspx", false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedidos nuevo = new Pedidos();
            PedidosNegocio negocio = new PedidosNegocio();
            string valor = ((Button)sender).CommandArgument;
            nuevo.IdMesa = int.Parse(valor);
            int id=negocio.LeerPedido(nuevo);
            
            Response.Redirect("TomarPedido.aspx?IdPedido=" + id, false);
        }
    }
}
