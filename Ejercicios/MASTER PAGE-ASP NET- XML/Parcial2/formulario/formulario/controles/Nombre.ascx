<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Nombre.ascx.cs" Inherits="formulario.controles.Nombre" %>
<asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>



&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtnombre" ErrorMessage="RequiredFieldValidator">campo obligatorio</asp:RequiredFieldValidator>





&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtnombre" ErrorMessage="solo caracteres alfabeticos" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>






