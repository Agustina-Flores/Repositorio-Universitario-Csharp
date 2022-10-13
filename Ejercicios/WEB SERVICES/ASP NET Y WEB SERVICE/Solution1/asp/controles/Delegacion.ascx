<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Delegacion.ascx.cs" Inherits="asp.controles.Delegacion" %>
 
<asp:RadioButtonList ID="radio" runat="server">
    <asp:ListItem>Sede Central</asp:ListItem>
    <asp:ListItem>Oasis Norte</asp:ListItem>
    <asp:ListItem>Oasis Sur</asp:ListItem>
</asp:RadioButtonList>

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="radio" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>


