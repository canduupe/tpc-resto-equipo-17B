<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="tpc_resto_equipo_17B.AgregarArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-4 Separacion">
        <label><b>Nombre</b> </label>
        <asp:TextBox ID="txtNombreArt" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="col-4 Separacion">
        <label><b>Descripción</b> </label>
        <asp:TextBox ID="txtDescripcionArt" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="col-4 Separacion">
        <label><b>Precio</b> </label>
        <asp:TextBox ID="txtPrecioArt" CssClass="form-control" runat="server"></asp:TextBox>
    </div>   
    
    <div class="col-4 Separacion">
        <label for="disabledSelect"><b>Tipo</b></label>
        <asp:DropDownList ID="CBTipoArt" runat="server" CssClass="btn btn-outline-dark dropdown-toggle"> </asp:DropDownList>
    </div>

    <div class="col-4 Separacion">
        <label><b>Cantidad disponible</b> </label>
        <asp:TextBox type="number" ID="txtCantidadArt" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="col-4 Separacion">
        <asp:Button ID="btnAgregarArt" runat="server" class="btn btn-outline-dark" OnClick="btnAgregarArt_Click" Text="Agregar"/>
        <asp:Button ID="btnCancelar" runat="server" class="btn btn-outline-dark" OnClick="btnCancelar_Click" Text="Cancelar"/>
    </div>

     <asp:UpdatePanel ID="UpdatePanel2" runat="server">
 <ContentTemplate>

     <div class="col-4 Separacion">
        <asp:Button ID="btnEliminarArt" runat="server" Text="Eliminar Articulo" OnClick="btnEliminarArt_Click" CssClass="btn btn-danger"/>
    

    <%if (ConfirmarEliminacionArt) { %> 

        <div class="mb-3 Separacion">
            <asp:CheckBox text = "Confirmar Eliminacion"  ID="ConfirmarEliArt"   runat="server"  /> 
            <asp:Button ID ="btnConfirmaArt" runat="server" Text="ELIMINAR" onclick="btnConfirmaArt_Click" CssClass="btn btn-outline-danger"/>
        </div>

      <% } %>

    </div>

         </ContentTemplate>  
     </asp:UpdatePanel>
    </asp:Content>
