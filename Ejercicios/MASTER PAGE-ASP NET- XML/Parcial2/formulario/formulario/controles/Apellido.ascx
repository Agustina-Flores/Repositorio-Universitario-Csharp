<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Apellido.ascx.cs" Inherits="formulario.controles.Apellido" %>
<p>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtapellido" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtapellido" ErrorMessage="solo caracteres alfabeticos" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
    </p>

