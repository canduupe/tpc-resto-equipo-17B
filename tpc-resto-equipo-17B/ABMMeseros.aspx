<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMMeseros.aspx.cs" Inherits="tpc_resto_equipo_17B.ABM_Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-4 Separacion">
        <label><b>Nombre</b> </label>
        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="col-4 Separacion">
        <label><b>Apellido </b></label>
        <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="col-4 Separacion">
        <label><b>Usuario</b> </label>
        <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="col-4 Separacion">
        <label><b>Contraseña</b> </label>
        <asp:TextBox ID="txtContraseña" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="col-4 Separacion">   
        <asp:Button ID="btnAceptar" runat="server" class="btn-check" OnClick="btnAceptar_Click" Text="ACEPTAR" />
        <asp:Button ID="btnCancelar" runat="server" class="btn-danger" OnClick="btnCancelar_Click" Text="CANCELAR" />
    </div>

</asp:Content>
