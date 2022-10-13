<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="articuloASP.aspx.cs" Inherits="asp.articuloASP" %>
<%@ Register Src="~/controles/CodigoBarra.ascx" TagPrefix="uc1" TagName="CodigoBarra" %>
<%@ Register Src="~/controles/Rubro.ascx" TagPrefix="uc2" TagName="Rubro" %>
<%@ Register Src="~/controles/Vencimiento.ascx" TagPrefix="uc3" TagName="Vencimiento" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family:Verdana; font-size:12px">
        <h3>Administrar Articulo</h3>
        <asp:Label ID="Label1" runat="server" Text="Articulo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtArticulo" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtArticulo" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
         <uc1:CodigoBarra runat="server" id="CodigoBarra" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Porcentaje Descuento"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtporcentaje" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtporcentaje" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
         <uc2:Rubro runat="server" id="Rubro" />
        <br />
        <br />
        <br />
        <br />
        <uc3:Vencimiento runat="server" id="Vencimiento" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="En Promocion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        <br />
        <br />
        <br />
        <h3>Administrar Articulo</h3>
        <div id="div1" runat="server"></div>
    </form>
</body>
</html>
