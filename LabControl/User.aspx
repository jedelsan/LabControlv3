<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="login.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid" style="height: 359px; width: 703px">
       
        <div style="float:; width: 243px; margin-left: 0px; height: 136px;" class="container" >
       
        <asp:Label ID="LblNombre" runat="server" Text="Nombre:"></asp:Label>


    &nbsp;&nbsp;&nbsp; <asp:Label ID="LblNombreUsuario" runat="server"></asp:Label>
            <br />
            <br />
        <asp:Label ID="Label1" runat="server" Text="Carnet:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblCarnetUsuario" runat="server"></asp:Label>
            <br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="Tipo:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblRolUsuario" runat="server"></asp:Label>
       
        <div style="float:none; width: 387px; height: 209px; margin-top: 46px;" class="container">
            <asp:LinkButton ID="btnCambiarContraseña" runat="server" OnClick="LinkButton1_Click">Cambiar Contraseña</asp:LinkButton>
            <br />
        <asp:Label ID="lblConVieja" runat="server" Text="Contraseña Antigua:" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtConVieja" TextMode="Password" runat="server" Visible="False" ></asp:TextBox>
            &nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
            <br />
        <asp:Label ID="lblConNueva" runat="server" Text="Contraseña Nueva:" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtConNueva" TextMode="Password" runat="server" Width="128px" Visible="False" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
&nbsp;
            <asp:Button ID="btnGuardarCon" runat="server" Text="Guardar" Visible="False" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Visible="False">Cancelar</asp:LinkButton>
            <br />
            <asp:Label ID="lblErrorCon" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="Red" Text="Error: Contraseña incorrecta" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblErrorCamposVacios" runat="server" Font-Bold="True" ForeColor="Red" Text="*Favor llenar todos los campos" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
        </div>
       
        </div>
     </div>
</asp:Content>
