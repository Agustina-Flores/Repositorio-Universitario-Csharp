<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="TP_WEB_SERVICES.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server" BorderStyle="Dashed" HorizontalAlign="Center">
            <asp:TableRow>
                <asp:TableCell>
                    <h3>Longitud</h3>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Quiero Convertir:<br />
                    <asp:TextBox ID="txtN" runat="server"></asp:TextBox><br />
                    <asp:DropDownList ID="DropUnidad1" runat="server" Width="99%">
                        <asp:ListItem Value="kilometro" Text="Kilómetro (Km)"></asp:ListItem>
                        <asp:ListItem Value="micrometro" Text="Micrómetro (µm)"></asp:ListItem>
                    </asp:DropDownList><br />
                    A:<br />
                    <asp:DropDownList ID="DropUnidad2" runat="server" Width="99%">
                        <asp:ListItem Value="kilometro" Text="Kilómetro (Km)"></asp:ListItem>
                        <asp:ListItem Value="metro" Text="Metro (m)"></asp:ListItem>
                        <asp:ListItem Value="decimetro" Text="Decímetro (dm)"></asp:ListItem>
                        <asp:ListItem Value="centimetro" Text="Centímetro (cm)"></asp:ListItem>
                        <asp:ListItem Value="milimetro" Text="Milímetro (mm)"></asp:ListItem>
                        <asp:ListItem Value="micrometro" Text="Micrómetro (µm)"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Right">
                    <asp:Button ID="Button1" runat="server" Text="Convertir" OnClick="Button1_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
