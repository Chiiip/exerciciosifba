﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastroLocal.aspx.cs" Inherits="PopTickets.Telas.WebFormCadastroLocal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
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
            <form id="Form1" runat="server">
            <h3>Cadastro de Espaço de Eventos (local)</h3>
            <asp:Label runat="server" id="lblNomeLocal" Text="Nome do local"/>
            <asp:TextBox runat="server" ID="txtNomeLocal" /><br/>
            <asp:Label runat="server" id="lblDescricaoEvento" Text="Descrição"/>
            <asp:TextBox runat="server" ID="txtDescricaoLocal" /><br/>
            <asp:Label runat="server" id="lblLotacao" Text="Lotação"/>
            <asp:TextBox runat="server" ID="txtLotacao" /><br/>
            <asp:Label runat="server" id="lblEnderecoLocal" Text="Endereço"/>
            <asp:TextBox runat="server" ID="txtEnderecoLocal" /><br/><br/>
            <asp:Button runat="server" ID="btnCadastrar" Text="Enviar" OnClick="btnCadastrar_Click"/><br />
            <asp:Label runat="server" id="lblErro" Text=""/>
            <h3>Locais Cadastrados</h3>
            <asp:Label runat="server" id="txtLocaisCadastrados" Text=""/>
            <asp:DataGrid runat="server" ID="dgLocaisCadastrados" 
                ondeletecommand="dgLocaisCadastrados_DeleteCommand" 
                onselectedindexchanged="dgLocaisCadastrados_SelectedIndexChanged" 
                CellPadding="4" ForeColor="#333333" GridLines="None" >
                <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:ButtonColumn CommandName="Select" Text="Selecionar"></asp:ButtonColumn>
                    <asp:ButtonColumn CommandName="Delete" Text="Excluir"></asp:ButtonColumn>
                </Columns>
                <EditItemStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
            </form>
            </div>
        </div>
    </div>
        <div class="footer">
            <p>POPTickets - ingressos para eventos | Sistema desenvolvido pela empresa JKYPa | Todos os direitos reservados</p>
        </div>
</body>
</html>
