﻿using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class PxMesa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PedidosNegocio negocio = new PedidosNegocio();
            int idMesa = int.Parse(Request.QueryString["IdMesa"].ToString());
            dgvPxMesA.DataSource = negocio.PxMesa(idMesa);
            dgvPxMesA.DataBind();

        }
    }
}