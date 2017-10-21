<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarClientes.aspx.cs" Inherits="ClientesWebApp.ListarClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h2>Listado de Clientes</h2>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvClientes" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
