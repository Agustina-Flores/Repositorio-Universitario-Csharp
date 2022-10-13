<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NombreApellido.ascx.cs" Inherits="asp.controles.NombreApellido" %>
<asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtapellido" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtapellido" ErrorMessage="solo caracteres alfabeticos" ValidationExpression="[a-zA-Z\s()\-]*$"></asp:RegularExpressionValidator>
&nbsp;<p>
    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;
   <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="solo caracteres alfabeticos" ValidationExpression="[a-zA-Z\s()\-]*$"></asp:RegularExpressionValidator>
</p>
<p>
    &nbsp;</p>

