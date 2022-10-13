<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dni.ascx.cs" Inherits="asp.controles.Dni" %>
<asp:TextBox ID="txtdni" runat="server"></asp:TextBox>
&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdni" ErrorMessage="Este campo es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtdni" ErrorMessage="Debe contener 8 dígitos" ForeColor="Red" ValidationExpression="\d{8}"></asp:RegularExpressionValidator>
&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtdni" ErrorMessage="Solo debe contener números" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>