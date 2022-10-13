<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="empleadoASP.aspx.cs" Inherits="asp.empleadoASP" %>
 <%@ Register Src="~/controles/Dni.ascx" TagPrefix="uc1" TagName="Dni" %>
 <%@ Register Src="~/controles/TipoContrato.ascx" TagPrefix="uc2" TagName="TipoContrato" %>
 <%@ Register Src="~/controles/Delegacion.ascx" TagPrefix="uc3" TagName="Delegacion" %>
 <%@ Register Src="~/controles/Estudios.ascx" TagPrefix="uc4" TagName="Estudios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  

    <asp:Table ID="tabla1" runat="server">
        <asp:TableRow>
                <asp:TableCell>

                </asp:TableCell>
                <asp:TableCell>
                    <h3 style="color:red">Administrar Empleado</h3>
                </asp:TableCell>
            </asp:TableRow>

         <asp:TableRow>
                <asp:TableCell>
                    <b>Apellido</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>            
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="txtapellido"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow> 
          <asp:TableRow>
                <asp:TableCell>
                    <b>Nombre</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>       
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="txtnombre"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
                    <b>DNI</b>
                </asp:TableCell>
                <asp:TableCell>
                    <uc1:Dni runat="server" id="Dni" />
                </asp:TableCell>
            </asp:TableRow>
         <asp:TableRow>
                <asp:TableCell>
                    <b>Tipo de Contrato</b>
                </asp:TableCell>
                <asp:TableCell>
                    <uc2:TipoContrato runat="server" id="TipoContrato" />
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
                    <b>Regimen Laboral</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="">Seleccion opcion</asp:ListItem>
                        <asp:ListItem>8 a 13</asp:ListItem>
                        <asp:ListItem>8 a 16</asp:ListItem>
                        <asp:ListItem>12 a 20</asp:ListItem>
                    </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
          <asp:TableRow>
                <asp:TableCell>
                    <b>Delegación</b>
                </asp:TableCell>
                <asp:TableCell>
                    <uc3:Delegacion runat="server" id="Delegacion" />
                </asp:TableCell>
            </asp:TableRow>
         <asp:TableRow>
                <asp:TableCell>
                    <b>Estudios</b>
                </asp:TableCell>
                <asp:TableCell>
                    <uc4:Estudios runat="server" id="Estudios" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="No puede trabajar en la sede central si tiene secundario incompleto" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
                <asp:TableCell>
                    <b>Descripción</b>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtdes" runat="server" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="txtdes"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>
         <asp:TableRow>
                <asp:TableCell>
                    
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button3" runat="server" Text="Guardar" OnClick="btnguardar_Click"/>
                    <asp:Button ID="Button4" runat="server" Text="Sesion" OnClick="btnSesion_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
     <h3 style="color:red">Administrar Empleado</h3>
  
    <div id="div1" runat="server">

    </div>
</asp:Content>
