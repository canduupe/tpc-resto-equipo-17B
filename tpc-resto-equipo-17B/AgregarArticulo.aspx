<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="tpc_resto_equipo_17B.AgregarArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form>
  <div class="mb-3">
    <label  class="form-label">Nombre</label>
    <input type="text" class="form-control" id="txtNombreArt" aria-describedby="emailHelp">
  </div>
  <div class="mb-3">
    <label class="form-label">Descripción</label>
    <input type="text" class="form-control" id="txtDescripcionArt">
  </div>
   <div class="mb-3">
  <label class="form-label">Precio</label>
  <input type="number" class="form-control" id="txtPrecioArt">
</div>
         <div class="mb-3">
      <label for="disabledSelect" class="form-label">Tipo</label>
      <select id="tipoArt" class="form-select">
        <option>Disabled select</option>
      </select>
    </div>
           <div class="mb-3">
  <label class="form-label">Cantidad Disponible</label>
  <input type="number" class="form-control" id="txtCantidadArt">
</div>
  
  <button type="submit" class="btn btn-primary">Agregar</button>
</form>

</asp:Content>
