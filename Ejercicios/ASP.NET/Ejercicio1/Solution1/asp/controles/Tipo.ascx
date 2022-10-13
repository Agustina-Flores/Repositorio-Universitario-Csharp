<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tipo.ascx.cs" Inherits="asp.controles.Tipo" %>
<asp:Label ID="Label1" runat="server" Text="Tipo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>Con Vencimiento</asp:ListItem>
    <asp:ListItem>Sin Vencimiento</asp:ListItem>
</asp:RadioButtonList>

<p>
&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
</p>
  <asp:Panel runat="server" CssClass="verFlex" ID="PTipo">
   <asp:TextBox TextMode="Date" runat="server" ID="TextBoxFechaVencimiento" Enabled="false" Visible="false"></asp:TextBox>
 <asp:RequiredFieldValidator Enabled="false" ID="RFVFechaVencimiento" runat="server" ErrorMessage="Falta fecha de vencimiento." ControlToValidate="TextBoxFechaVencimiento"></asp:RequiredFieldValidator>
 </asp:Panel>