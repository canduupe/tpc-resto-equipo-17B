﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mesas.aspx.cs" Inherits="tpc_resto_equipo_17B.Mesas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <hr />

<div class="row">
  <asp:Repeater ID="repeaterCards" runat="server">
    <ItemTemplate>
      <div class="col-sm-6 mb-3 mb-sm-0">
        <div class="card">
          <div class="card-body">
            <!-- Enlazar el título de cada tarjeta -->
            <h5 class="card-title">Mesa <%# Eval("NumeroMesa") %></h5>
            <!-- Enlazar el texto de cada tarjeta -->
            <p class="card-text">Sector: <%# Eval("Sector") %></p>
            <asp:Button ID="btnAsignar" runat="server" class="btn btn-outline-dark" OnClick="btnAsignar_Click" Text="Asignar"/>
          </div>
        </div>
      </div>
    </ItemTemplate>
  </asp:Repeater>
</div>
    <hr />
<div>
     <asp:Button ID="btnAgregarMesa" runat="server" class="btn btn-outline-dark" OnClick="btnAgregarMesa_Click" Text="Agregar mesa"/>
</div>
</asp:Content>
