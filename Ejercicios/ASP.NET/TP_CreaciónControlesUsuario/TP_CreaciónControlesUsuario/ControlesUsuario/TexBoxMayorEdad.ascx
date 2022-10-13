<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TexBoxMayorEdad.ascx.cs" Inherits="TP_CreaciónControlesUsuario.ControlesUsuario.TexBoxMayorEdad" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Debe ser mayor de edad" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" Display ="Dynamic"></asp:CustomValidator>

