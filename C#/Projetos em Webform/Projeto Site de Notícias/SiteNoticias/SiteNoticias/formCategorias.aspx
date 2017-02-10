<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCategorias.aspx.cs" Inherits="SiteNoticias.formCategorias" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="divcorpo">
    <asp:Label ID="lblNome" Text="Nome" runat="server" Font-Names="Arial"/> 
    <asp:TextBox ID="txtNome" runat="server"/> <br />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" onclick="btnEnviar_Click" />
    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" />
    <asp:DataGrid ID="dgCategoria" runat="server"/>

    </div>
    </form>
</body>
</html>
