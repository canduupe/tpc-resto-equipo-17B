<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMesa.aspx.cs" Inherits="tpc_resto_equipo_17B.AgregarMesa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-4 Separacion">
          <label><b>Numero de mesa</b> </label>
         <asp:TextBox ID="txtNumeroMesa" CssClass="form-control" runat="server"></asp:TextBox>           
    </div>

    <div class="col-4 Separacion">
           <label><b>Sector</b> </label>
          <asp:TextBox ID="txtSector" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

     <div class="col-4 Separacion">
         <asp:Button ID="btnAgregarM" runat="server" class="btn btn-outline-dark" OnClick="btnAgregarM_Click" Text="Agregar mesa"/>
         <asp:Button ID="btnCancelarM" runat="server" Cssclass="btn btn-dark" onclick="btnCancelarM_Click" Text="Cancelar" />
    </div>

</asp:Content>
