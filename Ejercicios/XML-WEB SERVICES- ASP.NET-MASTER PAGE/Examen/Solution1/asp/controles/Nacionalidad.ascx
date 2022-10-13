<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Nacionalidad.ascx.cs" Inherits="asp.controles.Nacionalidad" %>
<asp:Label ID="Label1" runat="server" Text="Nacionalidad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server"> 
    <asp:ListItem Value="">Seleccionar opcion</asp:ListItem>
    <asp:ListItem>Argentina</asp:ListItem>
    <asp:ListItem>Mexico</asp:ListItem>
    <asp:ListItem>Francia</asp:ListItem>
</asp:DropDownList>

&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="elegir opcion"></asp:RequiredFieldValidator>


