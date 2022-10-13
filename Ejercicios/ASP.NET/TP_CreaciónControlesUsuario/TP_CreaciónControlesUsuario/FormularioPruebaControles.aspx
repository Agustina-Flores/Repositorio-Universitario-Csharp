<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioPruebaControles.aspx.cs" Inherits="TP_CreaciónControlesUsuario.FormularioPruebaControles" %>

<%@ register src="~/ControlesUsuario/TextBoxNoEmpty.ascx" tagprefix="uc1" tagname="TextBoxNoEmpty" %>
<%@ register src="~/ControlesUsuario/TextBoxCuit.ascx" tagprefix="uc1" tagname="TextBoxCuit" %>
<%@ register src="~/ControlesUsuario/TexBoxMayorEdad.ascx" tagprefix="uc1" tagname="TexBoxMayorEdad" %>
<%@ register src="~/ControlesUsuario/RadioButtonSex.ascx" tagprefix="uc1" tagname="RadioButtonSex" %>
<%@ register src="~/ControlesUsuario/ComboPaises.ascx" tagprefix="uc1" tagname="ComboPaises" %>
<%@ register src="~/ControlesUsuario/RangoHijosMenores.ascx" tagprefix="uc1" tagname="RangoHijosMenores" %>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h2 style="text-align:center">Registración de Ayuda Social por Hijos</h2>
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
            <asp:TableRow>
                <asp:TableCell>
                    Apellido
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:TextBoxNoEmpty runat="server" id="TextBoxNoEmpty" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Nombre
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:TextBoxNoEmpty runat="server" id="TextBoxNoEmpty1" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    N° de CUIT
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:TextBoxCuit runat="server" ID="TextBoxCuit" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Edad del Solicitante
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:TexBoxMayorEdad runat="server" id="TexBoxMayorEdad" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Sexo
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:RadioButtonSex runat="server" ID="RadioButtonSex" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Nacionalidad
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:ComboPaises runat="server" ID="ComboPaises" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    N° de Hijos Menores de Edad
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:RangoHijosMenores runat="server" ID="RangoHijosMenores" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Text="Validar" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>


    </div>
    </form>
</body>
</html>
