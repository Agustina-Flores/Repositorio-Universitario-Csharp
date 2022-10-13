<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodigoBarra.ascx.cs" Inherits="asp.controles.CodigoBarra" %>
<asp:Label ID="Label2" runat="server" Text="Codigo Barra"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
<asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>


<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtcodigo" ErrorMessage="Debe contener 7 digitos" ValidationExpression="\d{7}"></asp:RegularExpressionValidator>


<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcodigo" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>



