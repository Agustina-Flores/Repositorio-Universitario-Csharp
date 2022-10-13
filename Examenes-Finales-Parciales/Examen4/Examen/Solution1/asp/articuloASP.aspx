<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="articuloASP.aspx.cs" Inherits="asp.articuloASP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
 <%@ Register Src="~/controles/CodigoBarra.ascx" TagPrefix="uc1" TagName="CodigoBarra" %>
 <%@ Register Src="~/controles/Rubro.ascx" TagPrefix="uc2" TagName="Rubro" %>
 <%@ Register Src="~/controles/Vencimiento.ascx" TagPrefix="uc3" TagName="Vencimiento" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <body>
         <script runat="server">
             protected void VerFechaVencimiento(object sender, EventArgs e)
             {

                 if (txtpromocion.Checked == true)
                 {

                     this.Label6.Visible = true;
                     this.TextBoxFechaVencimiento.Enabled = true;
                     this.TextBoxFechaVencimiento.Visible = true;
                     this.RFVFechaVencimiento.Enabled = true;
                 }
                 else
                 {
                     this.Label6.Visible = false;
                     this.TextBoxFechaVencimiento.Enabled = false;
                     this.TextBoxFechaVencimiento.Visible = false;

                 }


             }
        </script>
        <h2>Administrar Articulo</h2>
         <form id="form1" runat="server" style="font-family:Verdana; font-size:12px">

             <asp:Label ID="Label1" runat="server" Text="Articulo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="txtarticulo" runat="server"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtarticulo" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
             <br />
             <br />
             <uc1:CodigoBarra runat="server" id="CodigBarra" />
             <br />
             <br />
             <br />

             <asp:Label ID="Label2" runat="server" Text="Porcentaje Descuento"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="txtporcentaje" runat="server"></asp:TextBox>
             &nbsp;
             <br />
             <br />
             <br />
               <br />
             <br />
             <uc2:Rubro runat="server" id="Rubro" />
             &nbsp;
             <br />
             <br />
             <br />
             <br />
             <br />
                 <br />
             <br />
             <uc3:Vencimiento runat="server" id="Vencimiento" />
             <br />
             <br />
             <br />

             <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
             &nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPrecio" ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
             <br />
&nbsp;<br />

             <asp:Label ID="Label4" runat="server" Text="En Promocion"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:CheckBox ID="txtpromocion" runat="server" AutoPostBack="true" oncheckedchanged="VerFechaVencimiento"/>
             
             <asp:Panel runat="server" CssClass="verFlex" ID="PPromocion">
                 
             <asp:Label ID="Label6" runat="server" Text="Fecha de Vencimiento"  Visible="false"></asp:Label>
                 &nbsp;&nbsp;&nbsp;
            <asp:TextBox TextMode="Date" runat="server" ID="TextBoxFechaVencimiento" Enabled="false" Visible="false"></asp:TextBox>
            <asp:RequiredFieldValidator Enabled="false" ID="RFVFechaVencimiento" runat="server" ErrorMessage="Falta fecha de vencimiento." ControlToValidate="TextBoxFechaVencimiento"></asp:RequiredFieldValidator>
        </asp:Panel>
             <br />
             <br />
             <br />
             <br />
             <br />
             <asp:Button ID="btnguardar" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
             <br />
             <br />
             </form>

         <h2>Administrar Articulo</h2>

        <div id="div1" runat="server">

        </div>
    </body>
</asp:Content>
 
