﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultadoASP.aspx.cs" Inherits="asp.resultadoASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <h1>DATOS EN SESION:</h1>
   <form id="form1" runat="server">
       <asp:Table ID="tabla2" runat="server">
             <asp:TableRow>
                <asp:TableCell>
                    <b>Denominacion</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
               <asp:TableRow>
                <asp:TableCell>
                    <b>Rubro</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow> 
            <asp:TableRow>
                <asp:TableCell>
                    <b>Tipo</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
               <asp:TableRow>
                <asp:TableCell>
                    <b>Fecha Vencimiento</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <b>Stock Actual</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                    <b>Categoria Venta</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <b>Descripcion</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
              
           </asp:Table>
    </form>
</body>
</html>
