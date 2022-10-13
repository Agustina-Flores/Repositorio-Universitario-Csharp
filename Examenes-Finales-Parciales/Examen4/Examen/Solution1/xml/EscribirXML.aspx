<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscribirXML.aspx.cs" Inherits="xml.EscribirXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Filas"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtfilas" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Columnas"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcolumnas" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btntabla" runat="server" OnClick="btntabla_Click" Text="Generar XML Tabla" />
        </div>
    </form>
</body>
</html>

