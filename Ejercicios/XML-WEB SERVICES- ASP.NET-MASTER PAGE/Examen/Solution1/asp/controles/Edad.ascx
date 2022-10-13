<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Edad.ascx.cs" Inherits="asp.controles.Edad" %>
<asp:Label ID="Label1" runat="server" Text="Edad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtedad" runat="server"></asp:TextBox>

&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtedad" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtedad" ErrorMessage="Debe ser un numero entre 18 y 70" MaximumValue="70" MinimumValue="18" Type="Integer"></asp:RangeValidator>

