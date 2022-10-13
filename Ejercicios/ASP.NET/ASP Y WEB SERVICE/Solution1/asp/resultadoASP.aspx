<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultadoASP.aspx.cs" Inherits="asp.resultadoASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              
  <asp:Table ID="tabla2" runat="server">
             <asp:TableRow>
                <asp:TableCell>
                    <b>Apellido</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
               <asp:TableRow>
                <asp:TableCell>
                    <b>Nombre</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow> 
            <asp:TableRow>
                <asp:TableCell>
                    <b>Dni</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
               <asp:TableRow>
                <asp:TableCell>
                    <b>Tipo de Contrato</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <b>Regimen Laboral</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                    <b>Delegacion</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <b>Estudios</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
               <asp:TableRow>
                <asp:TableCell>
                    <b>Descripcion</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
            </asp:TableRow>
           </asp:Table>
        </div>
    </form>
</body>
</html>
