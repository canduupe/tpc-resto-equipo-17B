<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tpc_resto_equipo_17B._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">

            <div class="col-2"></div>
            <div class="col">
                <div>
                    <h1 id="aspnetTitle">INGRESO</h1>
                </div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="USUARIO"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblContra" runat="server" Text="CONTRASEÑA"></asp:Label>
                    <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="Button1" runat="server" OnClick="btnIngreso_Click" Text="Ingresar" />
                </div>
            </div>
            <div class="col-2"></div>
           
        </section>
    </main>

</asp:Content>
