<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMesa.aspx.cs" Inherits="tpc_resto_equipo_17B.AgregarMesa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mb-3">
            <label  class="form-label">Numero de mesa</label>
           <asp:TextBox ID="txtNumeroMesa" runat="server"></asp:TextBox>
            
        </div>

         <div class="mb-3">
            <label  class="form-label">Sector</label>
            <asp:TextBox ID="txtSector" runat="server"></asp:TextBox>
        </div>
   
    <div>
         <asp:Button ID="btnAgregarM" runat="server" class="btn btn-outline-dark" OnClick="btnAgregarM_Click" Text="Agregar mesa"/>
    </div>
</asp:Content>
