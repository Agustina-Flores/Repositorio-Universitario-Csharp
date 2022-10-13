<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceCliente.aspx.cs" Inherits="formulario.WebServiceCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnxml" runat="server" Text="DatosXML" OnClick="btnxml_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="txtapellido" runat="server" Text=" "></asp:Label>
            <asp:Label ID="txtap" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="txtnombre" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Edad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="txtedad" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Nacionalidad"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="txtnac" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Antecedentes"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="txtant" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
