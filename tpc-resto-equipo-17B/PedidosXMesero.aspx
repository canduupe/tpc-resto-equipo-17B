<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidosXMesero.aspx.cs" Inherits="tpc_resto_equipo_17B.PedidosXMesero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <asp:GridView ID="dgvPxM" runat="server" CssClass="table" AutoGenerateColumns="false" DataKeyNames="IdMesero"  OnSelectedIndexChanged="dgvPxM_SelectedIndexChanged">
     <Columns>
         <asp:BoundField HeaderText="IdMesero" DataField="IdMesero" />
         <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
         <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
         <asp:BoundField HeaderText="IdUsuario" DataField="IdUsuario" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
         <asp:BoundField HeaderText="Activo" DataField="Activo"/>

         <asp:CommandField HeaderText="Ver Pedidos" ShowSelectButton="true" SelectText="🙌" />

      </Columns>
 </asp:GridView>



</asp:Content>
