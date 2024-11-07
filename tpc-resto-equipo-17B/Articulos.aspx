<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="tpc_resto_equipo_17B.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center">CARTA   </h1>


    <asp:GridView ID="dgvCarta" runat="server" CssClass="table" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="IdGerente" DataField="IdGerente" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="IdUsuario" DataField="IdUsuario" />
            <asp:BoundField HeaderText="Activo" DataField="Activo" />

            <asp:CommandField HeaderText="Eliminar" ShowSelectButton="true" SelectText="☠️" />
            <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="📎" />
        </Columns>



    </asp:GridView>

    <div>
        <asp:Button ID="AgregarArt" runat="server" OnClick="AgregarArt_Click" Text="Agregar" />
        <asp:Button ID="ModificarArt" runat="server" Text="Modificar" />
        <asp:Button ID="EliminarArt" runat="server" Text="Eliminar" />
    </div>

</asp:Content>
