<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mesas.aspx.cs" Inherits="tpc_resto_equipo_17B.Mesas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <hr />

<div class="row">
  <asp:Repeater ID="repeaterCards" runat="server">
    <ItemTemplate>
      <div class="col-sm-6 mb-3 mb-sm-0">
        <div class="card">
          <div class="card-body">
            <h5 class="card-title">Mesa <%# Eval("NumeroMesa") %></h5>
            <p class="card-text">Sector: <%# Eval("Sector") %></p>
            <asp:Button ID="btnAsignar" runat="server" class="btn btn-outline-dark" OnClick="btnAsignar_Click" Text="Asignar" commandArgument='<%# Eval("IdMesa") %>' CommandName="IdMesaSelec" />             
            <asp:Button ID="btnEliminar" runat="server" class="btn btn-outline-danger" OnClick="btnEliminar_Click" Text="Eliminar" commandArgument='<%# Eval("IdMesa") %>' CommandName="IdMesaSelec" />  
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
