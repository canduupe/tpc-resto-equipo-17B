<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsignarMesero.aspx.cs" Inherits="tpc_resto_equipo_17B.AsignarMesero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <hr />
    <h2>Meseros activos</h2>

 <asp:GridView ID="dgvMeserosActivos" runat="server" CssClass="table" AutoGenerateColumns="false" DataKeyNames="IdMesero" OnSelectedIndexChanged="dgvMeserosActivos_SelectedIndexChanged">
     <Columns>
         <asp:BoundField HeaderText="IdMesero" DataField="IdMesero" />
         <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
         <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
         <asp:BoundField HeaderText="Activo" DataField="Activo"/>

         <asp:CommandField HeaderText="Asignar mesa" ShowSelectButton="true" SelectText="Asignar" />
      </Columns>
 </asp:GridView>

<div class="col-4 Separacion">
     <asp:Button ID="btnCancelar" runat="server" class="btn btn-outline-dark" OnClick="btnCancelar_Click" Text="Cancelar"/>
</div>

</asp:Content>
