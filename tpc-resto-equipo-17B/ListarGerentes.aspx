<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarGerentes.aspx.cs" Inherits="tpc_resto_equipo_17B.ListarGerentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView runat="server" ID="dgvGerentes" CssClass="table" AutoGenerateColumns="false">  
        <Columns>
            <asp:BoundField headertext="IdGerente" datafield="IdGerente"   />
            <asp:BoundField headertext="Nombre" datafield="Nombre"   />
            <asp:BoundField headertext="Apellido" datafield="Apellido"   />
            <asp:BoundField headertext="IdUsuario" datafield="IdUsuario"   />
            <asp:BoundField headertext="Activo" datafield="Activo"   />
   
            <asp:CommandField  headerText="Eliminar" ShowSelectButton="true" selectText="☠️"    />
            <asp:CommandField  headerText="Modificar" ShowSelectButton="true" selectText="📎"  />       
        </Columns>


    </asp:GridView>


</asp:Content>
