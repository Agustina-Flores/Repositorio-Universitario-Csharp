<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rubro.ascx.cs" Inherits="asp.controles.Rubro" %>
<asp:Label ID="Label1" runat="server" Text="Rubro"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Value="0">Seleccionar una opcion</asp:ListItem>
    <asp:ListItem>Alimentos</asp:ListItem>
    <asp:ListItem>Bebidas</asp:ListItem>
    <asp:ListItem>Limpieza</asp:ListItem>
</asp:DropDownList>

&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" InitialValue="0" runat="server" ControlToValidate="DropDownList1" ErrorMessage="elegir una opcion"></asp:RequiredFieldValidator>


