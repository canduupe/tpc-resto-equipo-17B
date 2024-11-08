<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="tpc_resto_equipo_17B.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center">CARTA   </h1>


    <asp:GridView ID="dgvCarta" runat="server" CssClass="table">
      

    </asp:GridView>

    <div>
        <asp:Button ID="AgregarArt" runat="server" class="btn btn-outline-dark" OnClick="AgregarArt_Click" Text="Agregar"/> 
        <asp:Button ID="ModificarArt" runat="server" class="btn btn-outline-dark" Text="Modificar"/>
        <asp:Button ID="EliminarArt" runat="server" class="btn btn-outline-dark" Text="Eliminar"/>
    </div>

</asp:Content>
