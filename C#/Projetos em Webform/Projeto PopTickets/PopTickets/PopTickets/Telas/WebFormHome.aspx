﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormHome.aspx.cs" Inherits="WebApplication5.WebFormHome" %>

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
             <div id="compras" class="compras">
                <p>Você pode ter compras em aberto</p><br />
                <asp:HyperLink runat="server" NavigateUrl="~/Telas/WebFormCarrinho.aspx" Target="_blank" Text="Garantir a minha compra"></asp:HyperLink>
                 <a> | </a>
                <a onclick="document.getElementById('compras').style.display='none'">Ignorar</a>
             </div>

            <div id="festas" class="festas">
                <p>Você pode ver as festas que comprou</p><br />
                <asp:HyperLink runat="server" NavigateUrl="~/Telas/WebFormPerfil.aspx" Target="_blank" Text="Conferir meu histórico"></asp:HyperLink>
                 <a> | </a>
                <a onclick="document.getElementById('festas').style.display='none'">Ignorar</a>
             </div>

            <div id="fotos" class="fotos">
                <p>Você pode ver todas as fotos</p><br />
                <asp:HyperLink runat="server" NavigateUrl="http://www.instagram.com" Target="_blank" Text="Ir para galeria"></asp:HyperLink>
                 <a> | </a>
                <a onclick="document.getElementById('fotos').style.display='none'">Ignorar</a>
             </div>

            <div class="caixabusca">
            <form id="formPesquisa" runat="server">
            <asp:TextBox ID="txtPesquisa" runat="server" Font-Size="14" Width="1000" Height="20" Text="Digite aqui o nome do evento que você quer buscar"></asp:TextBox>
            <asp:Button runat="server" ID="btnPesquisa" Text="Buscar" OnClick="btnPesquisa_Click"/>
            </form>

            <h3>Eventos mais novos</h3>
            <asp:DataGrid runat="server" ID="dgResultado" CssClass="dgResultado"/>
            </div>


            </div>
        </div>
    </div>
        <div class="footer">
            <p>POPTickets - ingressos para eventos | Sistema desenvolvido pela empresa JKYPa | Todos os direitos reservados</p>
        </div>
</body>
</html>