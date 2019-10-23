<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/carga.aspx">Cargar comentarios en el libro de visitas.</asp:HyperLink>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/listado.aspx">Lista del Libro</asp:HyperLink>
        </p>
    </form>
</body>
</html>
