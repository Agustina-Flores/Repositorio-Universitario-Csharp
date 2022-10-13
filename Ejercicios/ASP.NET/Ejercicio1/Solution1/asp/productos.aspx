<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="asp.productos" %>
<%@ Register Src="~/controles/Rubro.ascx" TagPrefix="uc1" TagName="Rubro" %>
<%@ Register Src="~/controles/Tipo.ascx" TagPrefix="uc2" TagName="Tipo" %>
<%@ Register Src="~/controles/CategoriaVenta.ascx" TagPrefix="uc3" TagName="CategoriaVenta" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Denominacion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtdeno" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdeno" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <uc1:Rubro runat="server" id="Rubro" />
             <br />
            <br />
            <uc2:Tipo runat="server" id="Tipo" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Stock Actual"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtstock" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtstock" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtstock" ErrorMessage="Debe ser un numero entre 0 y 10000" MaximumValue="10000" MinimumValue="0" Type="Integer"></asp:RangeValidator>

            &nbsp;&nbsp;
            <br />
            <br />
            <uc3:CategoriaVenta runat="server" id="CategoriaVenta" />
            <br />
            <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
&nbsp;<asp:TextBox ID="txtdes" runat="server" Height="126px" Width="351px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtdes" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        &nbsp;
            <asp:Button ID="btnSesion" runat="server" OnClick="btnSesion_Click" Text="Sesion" />
        </div>

        <h2>Datos </h2>
        <div id="div1" runat="server">

        </div>
    </form>
</body>
</html>
