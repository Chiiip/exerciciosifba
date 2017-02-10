<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCarrinho.aspx.cs" Inherits="WebApplication5.WebFormCarrinho" %>

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
            <h3>Meus Ingressos</h3>
            <form runat="server">
            <asp:GridView ID="dgCarrinho" runat="server" CellPadding="4" 
                ForeColor="#333333" GridLines="None"
                OnSelectedIndexChanged="dgCarrinho_SelectedIndexChanged" OnRowDeleting="dgCarrinho_RowDeleting" 
                >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowCancelButton="False" ShowSelectButton="True" />
                    <asp:CommandField ShowCancelButton="False" ShowDeleteButton="True" />
                </Columns>
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
                </asp:GridView><br />
            
            <asp:Label runat="server" ID="lblTotal" Text ="" /><br /><br />
                <asp:Label runat="server" ID="lblPagamento" Text ="Escolha o método de pagamento:" /><br />
                <asp:Panel runat="server" id="botoes">
                    <asp:RadioButton ID="btnCredito" Text="Cartão de Crédito" GroupName="botoes" runat="server"/> <br />
                    <asp:RadioButton ID="btnDebito" Text="Cartão de Débito" GroupName="botoes" runat="server"/> <br />
                    <asp:RadioButton ID="btnBoleto" Text="Boleto Bancário" GroupName="botoes" runat="server" /> <br />
               </asp:Panel> <br />
               <asp:Button runat="server" ID="btnFechar" Text="Fechar Compra" OnClick="btnFechar_Click" />
               <asp:Label runat="server" ID="lblFechado" Text ="" /><br />
            </form>
            </div>
        </div>
    </div>
        <div class="footer">
            <p>POPTickets - ingressos para eventos | Sistema desenvolvido pela empresa JKYPa | Todos os direitos reservados</p>
        </div>
</body>
</html>
