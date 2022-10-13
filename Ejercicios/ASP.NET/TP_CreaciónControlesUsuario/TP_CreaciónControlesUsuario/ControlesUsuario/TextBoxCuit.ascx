<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextBoxCuit.ascx.cs" Inherits="TP_CreaciónControlesUsuario.ControlesUsuario.TextBoxCuit" %>
<asp:TextBox ID="txtCuit" runat="server"></asp:TextBox>
<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtCuit" ErrorMessage="El cuit no es válido" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>

