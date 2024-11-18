<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarGerentes.aspx.cs" Inherits="tpc_resto_equipo_17B.ListarGerentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
    .oculto{
        display: none;
    }
    </style>

    <hr />
    <asp:GridView runat="server" ID="dgvGerentes" CssClass="table" AutoGenerateColumns="false" DataKeyNames="IdGerente" OnSelectedIndexChanged="dgvGerentes_SelectedIndexChanged">  
        <Columns>
            <asp:BoundField headertext="IdGerente" datafield="IdGerente"   />
            <asp:BoundField headertext="Nombre" datafield="Nombre"   />
            <asp:BoundField headertext="Apellido" datafield="Apellido"   />
            <asp:BoundField headertext="IdUsuario" datafield="IdUsuario" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
            <asp:BoundField headertext="Activo" datafield="Activo" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
   
            <asp:CommandField  headerText="Eliminar" ShowSelectButton="true" selectText="☠️"    />
            <asp:CommandField  headerText="Modificar" ShowSelectButton="true" selectText="📎"  />       
        </Columns>

    </asp:GridView>
        <div>
            <asp:Button ID="btnAgregarGerente" runat="server" class="btn btn-outline-dark" Onclick="btnAgregarGerente_Click" Text="Agregar"/>
        </div>
</asp:Content>
