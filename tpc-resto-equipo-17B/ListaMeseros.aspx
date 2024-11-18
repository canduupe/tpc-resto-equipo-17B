<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMeseros.aspx.cs" Inherits="tpc_resto_equipo_17B.ListaMeseros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .oculto{
            display: none;
        }
    </style>

    <hr />

    <h2>Todos los meseros</h2>

    <asp:GridView ID="dgvMeseros" runat="server" CssClass="table" AutoGenerateColumns="false" DataKeyNames="IdMesero" OnSelectedIndexChanged="dgvMeseros_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="IdMesero" DataField="IdMesero" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="IdUsuario" DataField="IdUsuario" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
            <asp:BoundField HeaderText="Activo" DataField="Activo"/>

            <asp:CommandField HeaderText="Eliminar" ShowSelectButton="true" SelectText="☠️" />
            <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="📎" />

         </Columns>
    </asp:GridView>

    <div>
            <asp:Button ID="btnAgregarMesero" runat="server" class="btn btn-outline-dark" Onclick="btnAgregarMesero_Click" Text="Agregar"/>
    </div>

</asp:Content>

