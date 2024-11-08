<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMGerentes.aspx.cs" Inherits="tpc_resto_equipo_17B.ABMGerentes" %>
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
    <asp:Button ID="btnAceptar" runat="server" Cssclass="btn btn-secondary" OnClick="btnAceptar_Click" Text="ACEPTAR" />
    <div class="col-4 Separacion">
        <asp:Button ID="btnCancelar" runat="server" Cssclass="btn btn-dark" OnClick="btnCancelar_Click" Text="CANCELAR" />
    </div>
</div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <div class="row Separacion">   
        <div class="col-6 Separacion">   
            <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR GERENTE" onclick="btnEliminar_Click"  CssClass="btn btn-danger"/>
        </div>

        <%if (ConfirmaEliminacion) { %> 

            <div class="mb-3 Separacion">
                <asp:CheckBox text = "Confirmar Eliminacion"  ID="Confirmar"   runat="server"  /> 
                <asp:Button ID = "btnConfirmaEliminacion" runat="server" Text="ELIMINAR" onclick="btnConfirmaEliminacion_Click" CssClass="btn btn-outline-danger"/>
            </div>

          <% } %>
        </ContentTemplate>    
    </asp:UpdatePanel>

  


</asp:Content>
