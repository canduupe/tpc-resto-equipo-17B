<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tpc_resto_equipo_17B._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <main>
    <section class="row" aria-labelledby="aspnetTitle">
        <div class="col-8 me-auto">
            <div>
                <h1 id="aspnetTitle" class="Separacion">LOGIN</h1>
            </div>

            <div class="Separacion">
                <asp:Label ID="Label1" runat="server" Text="USUARIO"></asp:Label>
                <asp:TextBox ID="txtUsser" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="Separacion">
                <asp:Label ID="lblContra" runat="server" Text="CONTRASEÑA"></asp:Label>
                <asp:TextBox ID="txtContra" class="form-control"  TextMode="Password"  runat="server"></asp:TextBox>
            </div>
            <div class="Separacion">
                <asp:Button ID="BtnIngresar" class="btn btn-primary" runat="server" OnClick="btnIngreso_Click" Text="Ingresar" />
            </div>
        </div>
    </section>
</main>

</asp:Content>
