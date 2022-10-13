<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodigoBarra.ascx.cs" Inherits="asp.controles.CodigoBarra" %>
<asp:Label ID="Label1" runat="server" Text="Codigo Barras"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcodigo" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;

<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtcodigo" ErrorMessage="Debe contener 7 digitos" ValidationExpression="\d{7}"></asp:RegularExpressionValidator>