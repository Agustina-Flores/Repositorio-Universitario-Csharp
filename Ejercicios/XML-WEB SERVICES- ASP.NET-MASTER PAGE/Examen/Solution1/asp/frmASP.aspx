<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="frmASP.aspx.cs" Inherits="asp.frmASP" %>
 <%@ Register Src="~/controles/NombreApellido.ascx" TagPrefix="uc1" TagName="NombreApellido" %>
 <%@ Register Src="~/controles/Nacionalidad.ascx" TagPrefix="uc2" TagName="Nacionalidad" %>
 <%@ Register Src="~/controles/Edad.ascx" TagPrefix="uc3" TagName="Edad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="font-family:Verdana; font-size:12px">
<uc1:NombreApellido runat="server" id="NombreApellido" />
       &nbsp;
       <br />
       <asp:Label ID="Label1" runat="server" Text="Sexo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RadioButtonList ID="RadioButtonList1" runat="server">
           <asp:ListItem>Masculino</asp:ListItem>
           <asp:ListItem>Femenino</asp:ListItem>
       </asp:RadioButtonList>
       <br />
       <br />
       <uc2:Nacionalidad runat="server" id="Nacionalidad" />
        <br />
       <br />
       <asp:Label ID="Label2" runat="server" Text="Bloqueado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:CheckBox ID="CheckBox1" runat="server" />
       <br />
       <br />
        <br />
       <br />
    <uc3:Edad runat="server" id="Edad" />
       <br />
       <br />
       <asp:Label ID="Label3" runat="server" Text="Antecedentes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtant" runat="server" Height="99px" Width="255px"></asp:TextBox>
       &nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtant" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
       <br />
       <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
       &nbsp;&nbsp;&nbsp;
       <asp:Button ID="btnSesion" runat="server" OnClick="btnSesion_Click" Text="Sesion" />
       <br />
       <br />
       <br />

       <div>
        <h1>Datos Nuevos</h1>

        <asp:Table ID="TableDatos" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Apellido</asp:TableCell>
                <asp:TableCell runat="server">Nombre</asp:TableCell>
                <asp:TableCell runat="server">Sexo</asp:TableCell>
                <asp:TableCell runat="server">Nacionalidad</asp:TableCell>
                <asp:TableCell runat="server">Bloqueado</asp:TableCell>
                <asp:TableCell runat="server">Edad</asp:TableCell>
                 <asp:TableCell runat="server">Antecedentes</asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </div>
         <h1>Datos Cargados XML</h1>
        <pre runat="server" id="datosxml"> </pre>
    </form>
</asp:Content>
