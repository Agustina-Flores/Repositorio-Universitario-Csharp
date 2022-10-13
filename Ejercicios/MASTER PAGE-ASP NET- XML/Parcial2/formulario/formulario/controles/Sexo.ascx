
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sexo.ascx.cs" Inherits="formulario.controles.Sexo" %>
<asp:Label ID="Label1" runat="server" Text="Sexo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>Masculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
</asp:RadioButtonList>

<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>


