<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PxM.aspx.cs" Inherits="tpc_resto_equipo_17B.PxM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <asp:GridView ID="dgvPeM" runat="server" CssClass="table" AutoGenerateColumns="false">
    <Columns>

        <asp:BoundField HeaderText="IdPedido" DataField="IdPedido" />
        <asp:BoundField HeaderText="Mesero" DataField="Mesero" />
        


     </Columns>
</asp:GridView>



</asp:Content>
