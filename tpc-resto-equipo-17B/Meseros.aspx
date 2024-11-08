<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Meseros.aspx.cs" Inherits="tpc_resto_equipo_17B.Meseros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h2 id="aspnetTitle">Perfil mesero</h2>

    <div class="d-flex align-items-start">
        <div class="nav flex-column nav-pills me-3" id="v-pills-tab" role="tablist" aria-orientation="vertical">

            <asp:Button ID="btnMesasAsig" runat="server" class="nav-link" data-bs-toggle="pill" type="button" data-bs-target="#v-pills-settings" role="tab" aria-controls="v-pills-settings" aria-selected="false" Text="Mesas Asignadas"/>

            <asp:Button ID="btnPedidos" runat="server" class="nav-link" data-bs-toggle="pill" type="button" data-bs-target="#v-pills-settings" role="tab" aria-controls="v-pills-settings" aria-selected="false" Text="Pedidos"/>

            <asp:Button ID="btnListar" runat="server" class="nav-link" data-bs-toggle="pill" type="button" data-bs-target="#v-pills-settings" role="tab" aria-controls="v-pills-settings" aria-selected="false" Onclick="btnListar_Click" Text="Listar Meseros"/>

        </div>
       <div class="tab-content" id="v-pills-tabContent">
        <div class="tab-pane fade show active" id="v-pills-home" role="tabpanel" aria-labelledby="v-pills-home-tab" tabindex="0">...</div>
        <div class="tab-pane fade" id="v-pills-profile" role="tabpanel" aria-labelledby="v-pills-profile-tab" tabindex="0">...</div>
        <div class="tab-pane fade" id="v-pills-settings" role="tabpanel" aria-labelledby="v-pills-settings-tab" tabindex="0">...</div>
    </div>
</div>
 </asp:Content>
