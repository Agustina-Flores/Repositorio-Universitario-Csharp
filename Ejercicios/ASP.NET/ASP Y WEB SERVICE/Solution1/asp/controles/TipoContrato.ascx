<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TipoContrato.ascx.cs" Inherits="asp.controles.TipoContrato" %>
&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Value="">Seleccionar opcion</asp:ListItem>
    <asp:ListItem>Planta Permanente</asp:ListItem>
    <asp:ListItem>Contratado</asp:ListItem>
    <asp:ListItem>Pasante</asp:ListItem>
</asp:DropDownList>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="elegir una opcion"></asp:RequiredFieldValidator>


