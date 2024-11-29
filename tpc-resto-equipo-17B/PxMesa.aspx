<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PxMesa.aspx.cs" Inherits="tpc_resto_equipo_17B.PxMesa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView runat="server"  ID="dgvPxMesA"   class="table"  AutoGenerateColumns="false">   

        <Columns>
            <asp:BoundField  HeaderText="IdPedido" Datafield="IdPedido" />
            <asp:BoundField  HeaderText="IdMesa" Datafield="IdMesa" />
        </Columns>


    </asp:GridView>       






</asp:Content>
