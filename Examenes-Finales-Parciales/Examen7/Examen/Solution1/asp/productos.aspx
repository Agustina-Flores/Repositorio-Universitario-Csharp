<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="asp.productos" %>
<%@ Register src="controles/Rubro.ascx" tagname="Rubro" tagprefix="uc1" %>
<%@ Register src="controles/Tipo.ascx" tagname="Tipo" tagprefix="uc2" %>
<%@ Register src="controles/CategoriaVenta.ascx" tagname="CategoriaVenta" tagprefix="uc3" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 431px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         
        <asp:Label ID="Label1" runat="server" Text="Denominacion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtden" runat="server"></asp:TextBox>
         &nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtden" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
         <br />
        <uc1:Rubro ID="Rubro1" runat="server" />
        <br />
         <br />
        <uc2:Tipo ID="Tipo" runat="server" />
        <asp:Label ID="Label2" runat="server" Text="Stock Actual"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtstock" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtstock" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
        &nbsp;
        <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtstock" EnableClientScript="False" ErrorMessage="rango de 0 a 10000" ForeColor="Red" MaximumValue="10000" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        <br />
        <uc3:CategoriaVenta ID="CategoriaVenta" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtdes" runat="server" CssClass="auto-style1" Height="81px" Width="265px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtdes" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;<br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    &nbsp;
        <asp:Button ID="btnSesion" runat="server" Text="Sesion" OnClick="btnSesion_Click" />
         <div id="div1" runat="server">
        </div>
    </form>
</body>
</html>
