<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Antecedentes.ascx.cs" Inherits="formulario.controles.Antecedentes" %>
<asp:Label ID="Label1" runat="server" Text="Antecedentes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtante" runat="server" Height="77px" Width="274px"></asp:TextBox>

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtante" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>


