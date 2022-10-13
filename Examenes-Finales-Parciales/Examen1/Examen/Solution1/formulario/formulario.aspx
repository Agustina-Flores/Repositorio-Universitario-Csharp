<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario.aspx.cs" Inherits="formulario.formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 335px;
        }
    </style>
</head>
<body>
      <form id="form1" runat="server" style="font-family:Verdana; font-size:12px">
        <div class="auto-style1">

            <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtapellido" runat="server" OnTextChanged="txtapellido_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtapellido" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtapellido" ErrorMessage="solo caracteres alfabeticos" ValidationExpression="[a-zA-Z\s()\-]*$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="solo caracteres alfabeticos" ValidationExpression="[a-zA-Z\s()\-]*$"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Femenino</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nacionalidad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Selecciona una opcion</asp:ListItem>
                <asp:ListItem>Argentina</asp:ListItem>
                <asp:ListItem>Mexico</asp:ListItem>
                <asp:ListItem>Francia</asp:ListItem>
            </asp:DropDownList>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
&nbsp;<div id="div2" runat="server">
            </div>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Bloqueado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="checkbox" runat="server" />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Edad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtedad" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="edad entre 18 y 70 " MaximumValue="70 " MinimumValue="18" ControlToValidate="txtedad"></asp:RangeValidator>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Antecedentes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtant" runat="server" Height="55px" Width="326px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtant" ErrorMessage="campo obligatorio"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
        <br />
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
        </div>          
    </form>
    <br />
    <h2>Datos Cargados</h2>
     <div id="div1" runat="server">
        </div>
</body>
</html>

