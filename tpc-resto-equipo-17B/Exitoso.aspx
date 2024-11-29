<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exitoso.aspx.cs" Inherits="tpc_resto_equipo_17B.Exitoso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> ENVIO EXITOSO   </h1>
    <div>
        <h3>  Precione El Boton Para VOLVER  a Inciar Un Pedido :) </h3>
    </div>
    <div class="Separacion">   
        <asp:Button ID="btnVolver" runat="server" Text="VOLVER " OnClick="btnVolver_Click"  CssClass="btn btn-outline-secondary" />
    </div>
</asp:Content>
