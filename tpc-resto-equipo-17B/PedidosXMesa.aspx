<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PedidosXMesa.aspx.cs" Inherits="tpc_resto_equipo_17B.PedidosXMesa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:GridView ID="dgvPxMesa" runat="server" CssClass="table" AutoGenerateColumns="false"  DataKeyNames="IdMesa"  OnSelectedIndexChanged="dgvPxMesa_SelectedIndexChanged">
    <Columns>
        <asp:BoundField HeaderText="IdMesa" DataField="IdMesa" />
        <asp:BoundField HeaderText="NumeroMesa" DataField="NumeroMesa" />
        <asp:BoundField HeaderText="Sector" DataField="Sector"/>

        <asp:CommandField HeaderText="Ver Pedidos" ShowSelectButton="true" SelectText="🙌" />

     </Columns>
</asp:GridView>




</asp:Content>
