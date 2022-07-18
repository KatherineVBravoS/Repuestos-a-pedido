<%@ Page Title="" Language="C#" MasterPageFile="~/View/Clientes/MPClientes.master" AutoEventWireup="true" CodeBehind="RecuperarContraseñaCliente.aspx.cs" Inherits="proyecto.View.Clientes.RecuperarContraseñaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
   
    <div id="formContent">
        <br />Cambiar Contraseña
        <br />
        <br />
        <br />
                Contraseña Actual:
        <asp:TextBox ID="txtContrasenaActual" runat="server" CssClass="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
        <br />

                    Nueva Contraseña:&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                    <br />
                     Confirme Contraseña
        <asp:TextBox ID="txtConfirmContrasena" runat="server" CssClass="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnCambiarContraseña" runat="server" CssClass="btn btn-primary" OnClick="btnCambiar_Contraseña_Click" Text="Cambiar Contraseña" />
        <asp:Label ID="txtError" runat="server" CssClass="alert-danger" ForeColor="Red" Visible="false"></asp:Label>
         </div>
    </asp:Content>
