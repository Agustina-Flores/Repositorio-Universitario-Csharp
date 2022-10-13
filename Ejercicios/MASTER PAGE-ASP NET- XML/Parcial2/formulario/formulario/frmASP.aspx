<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="frmASP.aspx.cs" Inherits="formulario.frmASP" %>
<%@ Register src="controles/Apellido.ascx" tagname="Apellido" tagprefix="uc1" %>
<%@ Register src="controles/Nombre.ascx" tagname="Nombre" tagprefix="uc2" %>
<%@ Register src="controles/Sexo.ascx" tagname="Sexo" tagprefix="uc3" %>
<%@ Register src="controles/Nacionalidad.ascx" tagname="Nacionalidad" tagprefix="uc4" %>
<%@ Register src="controles/Edad.ascx" tagname="Edad" tagprefix="uc6" %>
<%@ Register src="controles/Antecedentes.ascx" tagname="Antecedentes" tagprefix="uc7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .table {
            font-family:Verdana;
            font-size:12px;
            border: thin;
            
        }
    </style>
</head>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" style="font-family:Verdana; font-size:12px">
   
    <uc1:Apellido ID="Apellido1" runat="server" />
    <uc2:Nombre ID="Nombre1" runat="server" />
    <br />
    <br />
    <br />
    <uc3:Sexo ID="Sexo1" runat="server" />
    <br />
    <br />
    <br />
    <uc4:Nacionalidad ID="Nacionalidad1" runat="server" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Bloqueado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox runat="server" ID="CheckBox" />

    <br />
    <br />
    <uc6:Edad ID="Edad1" runat="server" />
    <br />
    <br />
    <br />
    <uc7:Antecedentes ID="Antecedentes1" runat="server" />
    <br />
    <br />
   <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
    &nbsp;<asp:Button ID="btnsesion" runat="server" Text="Sesion" OnClick="Button2_Click" />
    <br />
    <br />
       <div id="div1" runat="server">
        </div>
         </form>
</asp:Content>
