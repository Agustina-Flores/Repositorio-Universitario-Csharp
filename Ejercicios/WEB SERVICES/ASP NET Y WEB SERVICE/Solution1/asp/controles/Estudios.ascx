<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Estudios.ascx.cs" Inherits="asp.controles.Estudios" %>
<p>
&nbsp;</p>
&nbsp;<asp:CheckBoxList ID="cbEstudios" runat="server">
    <asp:ListItem>Secundario Incompleto</asp:ListItem>
    <asp:ListItem>Secundario Completo</asp:ListItem>
    <asp:ListItem>Terciario Completo</asp:ListItem>
    <asp:ListItem>Universitario Completo</asp:ListItem>
</asp:CheckBoxList>
<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Este campo es obligatorio" ForeColor="Red" OnServerValidate="ValidarCheckBox"></asp:CustomValidator>
