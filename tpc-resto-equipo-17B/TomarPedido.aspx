<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TomarPedido.aspx.cs" Inherits="tpc_resto_equipo_17B.TomarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <h1 class="text-center">CARTA   </h1>

<asp:GridView ID="dgvCartita" runat="server" CssClass="table" AutoGenerateColumns="false" DataKeyNames="IdArticulo, Precio" OnSelectedIndexChanged="dgvCartita_SelectedIndexChanged">
 <Columns>
     <asp:BoundField HeaderText="IdArticulo" DataField="IdArticulo" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
     <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
     <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
     <asp:BoundField HeaderText="Precio" DataField="Precio" />
     <asp:BoundField HeaderText="Tipo" DataField="Tipo" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
     <asp:BoundField HeaderText="CantidadDisponible" DataField="CantidadDisponible" />

     <asp:CommandField HeaderText="Agregar a Orden" ShowSelectButton="true" SelectText="🍲" />
     <%--<asp:CommandField HeaderText="El" ShowSelectButton="true" SelectText="📎" />--%>
 </Columns>
     </asp:GridView>



</asp:Content>
