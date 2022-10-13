<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextBoxNoEmpty.ascx.cs" Inherits="TP_CreaciónControlesUsuario.ControlesUsuario.TextBoxNoEmpty" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Este campo es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>

