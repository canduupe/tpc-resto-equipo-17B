<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="tpc_resto_equipo_17B.AgregarArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form>
  <div class="mb-3">
    <label  class="form-label">Nombre</label>
      <asp:TextBox ID="txtNombreArt" runat="server"></asp:TextBox>
  </div>
  <div class="mb-3">
    <label class="form-label">Descripción</label>
      <asp:TextBox ID="txtDescripcionArt" runat="server"></asp:TextBox>
  </div>
   <div class="mb-3">
  <label class="form-label">Precio</label>
  <asp:TextBox ID="txtPrecioArt" runat="server"></asp:TextBox>
</div>             
         <div class="mb-3">
      <label for="disabledSelect" class="form-label">Tipo</label>
      <asp:DropDownList ID="CBTipoArt" runat="server" CssClass="btn btn-outline-dark dropdown-toggle"> </asp:DropDownList>
    </div>
           <div class="mb-3">
  <label class="form-label">Cantidad Disponible</label>
  <asp:TextBox type="number" ID="txtCantidadArt" runat="server"></asp:TextBox>
</div>
        <asp:Button ID="btnAgregarArt" runat="server" class="btn btn-outline-dark" OnClick="btnAgregarArt_Click" Text="Agregar"/>
        <asp:Button ID="btnCancelar" runat="server" class="btn btn-outline-dark" OnClick="btnCancelar_Click" Text="Cancelar"/>
</form>

</asp:Content>
