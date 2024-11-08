<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="tpc_resto_equipo_17B.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center">CARTA   </h1>


   <asp:GridView ID="dgvCarta" runat="server" CssClass="table" AutoGenerateColumns="false" DataKeyNames="IdArticulo" OnSelectedIndexChanged="dgvCarta_SelectedIndexChanged">
    <Columns>
        <asp:BoundField HeaderText="IdArticulo" DataField="IdArticulo" />
        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
        <asp:BoundField HeaderText="Precio" DataField="Precio" />
        <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
        <asp:BoundField HeaderText="CantidadDisponible" DataField="CantidadDisponible" />

        <asp:CommandField HeaderText="Eliminar" ShowSelectButton="true" SelectText="☠️" />
        <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="📎" />
    </Columns>
        </asp:GridView>

    <div>
        <asp:Button ID="AgregarArt" runat="server" class="btn btn-outline-dark" OnClick="AgregarArt_Click" Text="Agregar"/> 
    </div>

</asp:Content>
