<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroNoticia.aspx.cs" Inherits="SiteNoticias.CadastroNoticia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="divcorpo">
    <asp:Label ID="lblData" Text="Data" runat="server" Font-Names="Arial"/> </br>
    <asp:TextBox ID="txtData" runat="server"/> <br />
    <asp:Calendar ID="calendario" runat="server" onselectionchanged="calendario_SelectionChanged"/>
    <asp:Label ID="lblTitulo" Text="Título" runat="server" Font-Names="Arial"/> 
    <asp:TextBox ID="txtTitulo" runat="server"/> <br />
    <asp:Label ID="lblCategoria" Text="Categoria" runat="server" Font-Names="Arial"/> <br />
    <asp:DropDownList ID="listCategoria" runat="server"/> <br />
    <asp:Label ID="lblNoticia" Text="Notícia" runat="server" Font-Names="Arial"/> <br />
    <asp:TextBox ID="txtNoticia" runat="server" TextMode="MultiLine"/> <br />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" onclick="btnEnviar_Click" /> <br />
    <asp:DataGrid ID="dgNoticias" runat="server"/>
    </div>
    </form>
</body>
</html>
