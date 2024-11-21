<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orden.aspx.cs" Inherits="tpc_resto_equipo_17B.Orden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView runat="server" Id="DgvOrden" CssClass ="table"  AutoGenerateColumns="false"  DataKeyNames="IdArticulo, IdPedido"  OnSelectedIndexChanged="DgvOrden_SelectedIndexChanged">
      <Columns>

          <asp:BoundField HeaderText="IdPedido" DataField="IdPedido" />
          <asp:BoundField HeaderText="IdArticulo" DataField="IdArticulo" />
          <asp:BoundField HeaderText="Mesero" DataField="Mesero" />
          <asp:BoundField HeaderText="Precio" DataField="Precio" />
          <asp:BoundField HeaderText="Activo" DataField="Activo" />


          <asp:CommandField HeaderText="ELIMINAR" ShowSelectButton="true" SelectText="Delete" />

      </Columns>
 </asp:GridView>

     <div class="col-4 d-flex gap-2">
         <asp:Button ID="BtnVolver" runat="server" Text="Volver"  CssClass="btn btn-outline-warning" OnClick="BtnVolver_Click"/>
         <asp:Button ID="BtnCerrarPedido" runat="server" Text="Cerrar pedido" CssClass="btn btn-outline-success" OnClick="BtnCerrarPedido_Click"/>
     </div>

</asp:Content>
