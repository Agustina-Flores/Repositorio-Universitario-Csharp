﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Rubro.ascx.cs" Inherits="asp.controles.Rubro" %>
<asp:Label ID="Label1" runat="server" Text="Rubro"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>Selecciona una opcion</asp:ListItem>
    <asp:ListItem>Alimentos</asp:ListItem>
    <asp:ListItem>Limpieza</asp:ListItem>
    <asp:ListItem>Electronica</asp:ListItem>
</asp:DropDownList>

&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="campo requerido" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>


