﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPerfil.aspx.cs" Inherits="WebApplication5.WebFormPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="../Content/Site.css" rel="stylesheet" type="text/css" />
<link href="../Content/bootstrap.css" rel="stylesheet" type="text/css" />
<link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <div id="wrap">
       <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                   <img src="Images/poptickets.png" width="410" height="70">
                    <img id="imagemperfil" src="Images/icone_perfil.png" width="80" height="40">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Telas/WebFormPerfil.aspx" Target="_blank" Text="Minha conta"></asp:HyperLink>
                    <img id="imagemcarrinho" src="Images/carrinho.png" width="40" height="40">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Telas/WebFormCarrinho.aspx" Target="_blank" Text="Carrinho"></asp:HyperLink>
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Telas/WebFormHome.aspx" Target="_blank" Text="Home"></asp:HyperLink></li>
                        <li><a> | </a></li>
                        <li><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Telas/WebFormShow.aspx" Target="_blank" Text="Show"></asp:HyperLink></li>
                        <li><a> | </a></li>
                        <li><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Telas/WebFormTeatro.aspx" Target="_blank" Text="Teatro"></asp:HyperLink></li>
                        <li><a> | </a></li>
                        <li><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Telas/WebFormCarnaval.aspx" Target="_blank" Text="Carnaval"></asp:HyperLink></li>
                        <li><a> | </a></li>
                        <li><asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Telas/WebFormContato.aspx" Target="_blank" Text="Contato"></asp:HyperLink></li>
                    </ul>
                </div>
            </div>
        </div>

        <div id="main">
            <div class="container body-content">

            <h3>Perfil de usuário</h3>
            <form runat="server">
            <asp:Label runat="server" ID="lblNome" Text="" /><br /><br />
            <asp:Button runat="server" ID="btnDados" Text="Editar meus dados" CssClass="botao" OnClick="btnDados_Click"/>
            <asp:Button runat="server" ID="btnCarrinho" Text="Meu Carrinho" CssClass="botao" OnClick="btnCarrinho_Click"/>
            <asp:Button runat="server" ID="btnLogout" Text="Logout" CssClass="botao" OnClick="btnLogout_Click"/>
            <h3>Histórico de compras</h3>
            <asp:GridView ID="dgIngresso" runat="server" CellPadding="4" 
                ForeColor="#333333" GridLines="None" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            </form>
            </div>
        </div>
    </div>
        <div class="footer">
            <p>POPTickets - ingressos para eventos | Sistema desenvolvido pela empresa JKYPa | Todos os direitos reservados</p>
        </div>
</body>
</html>

