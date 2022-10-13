<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Vencimiento.ascx.cs" Inherits="asp.controles.Vencimiento" %>
<asp:Label ID="Label1" runat="server" Text="Vencimiento"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>Corto Plazo</asp:ListItem>
    <asp:ListItem>Largo Plazo</asp:ListItem>
</asp:RadioButtonList>

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="elegir una opcion" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>


