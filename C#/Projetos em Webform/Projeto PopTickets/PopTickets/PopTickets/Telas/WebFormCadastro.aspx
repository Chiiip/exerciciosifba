<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastro.aspx.cs" Inherits="PopTickets.Telas.WebFormCadastro" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            <form runat="server">
            <h3>Cadastro de usuário</h3>
            <asp:Label runat="server" id="lblNome" Text="Nome"/>
            <asp:TextBox runat="server" ID="txtNome" /><br/>
            <asp:Label runat="server" id="lblEmail" Text="E-mail"/>
            <asp:TextBox runat="server" ID="txtEmail" /><br/>
            <asp:Label runat="server" id="lblSenha" Text="Senha"/>
            <asp:Textbox TextMode="Password" runat="server" ID="txtSenha" /><br/>
            <asp:Label runat="server" id="lblConfirma" Text="Confirmação"/>
            <asp:Textbox TextMode="Password" runat="server" ID="txtConfirma" /><br/>
            <asp:Label runat="server" id="lblData" Text="Data de Nascimento"/>
            <asp:TextBox runat="server" ID="txtData" /><br/>
            <asp:Label runat="server" id="lblCPF" Text="CPF (somente números)"/>
            <asp:TextBox runat="server" ID="txtCPF" /><br/>
            <asp:Label runat="server" id="lblEndereco" Text="Endereço"/>
            <asp:TextBox runat="server" ID="txtEndereco" /><br/><br/>
            <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" OnClick="btnCadastrar_Click"/><br />
            <asp:Label runat="server" id="lblErro" Text=""/>
            </form>
            </div>
        </div>
    </div>
        <div class="footer">
            <p>POPTickets - ingressos para eventos | Sistema desenvolvido pela empresa JKYPa | Todos os direitos reservados</p>
        </div>
</body>
</html>