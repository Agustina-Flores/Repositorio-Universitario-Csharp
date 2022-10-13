<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RangoHijosMenores.ascx.cs" Inherits="TP_CreaciónControlesUsuario.ControlesUsuario.RangoHijosMenores" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="No cumple con el rango permitido" ForeColor="Red" MaximumValue="18" MinimumValue="0" Type="Integer"></asp:RangeValidator>

