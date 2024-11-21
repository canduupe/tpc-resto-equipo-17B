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
    }
}