﻿using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_resto_equipo_17B
{
    public partial class ListaPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Pedidos> lista;
            PedidosNegocio negocio = new PedidosNegocio();

            lista = negocio.Listar();
            dgvPedidos.DataSource = lista;
            dgvPedidos.DataBind();

        }
    }
}