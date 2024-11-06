<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMMeseros.aspx.cs" Inherits="tpc_resto_equipo_17B.ABM_Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-4 Separacion">  
        <label> <b>Nombre</b> </label>
        <asp:TextBox ID="txtNombre"  Cssclass="form-control"  runat="server"></asp:TextBox>
    </div>
    <div class="col-4 Separacion">  
        <label> <b>Apellido </b> </label>
        <asp:TextBox ID="txtApellido" Cssclass="form-control"   runat="server"></asp:TextBox> 
    </div>
    <div class="col-4 Separacion">  
        <label> <b>Usuario</b> </label>
        <asp:TextBox ID="txtUsuario" Cssclass="form-control"  runat="server"></asp:TextBox> 
    </div>







</asp:Content>
