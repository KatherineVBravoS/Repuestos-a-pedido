<%@ Page Title="" Language="C#" MasterPageFile="~/View/Usuario/MPUsuario.master" AutoEventWireup="true" CodeBehind="AgregarAdministrador.aspx.cs" Inherits="proyecto.View.Usuario.AgregarAdministrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <formview id="form1" runat="server">
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputNombreAdministrador">Usuario</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputNombreAdministrador"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputContrasena">Contraseña</asp:Label>
                <asp:TextBox runat="server" type="password" class="form-control" ID="inputContrasena"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputConfirmContrasena">Confirme Contraseña</asp:Label>
                <asp:TextBox runat="server" type="password" class="form-control" ID="inputConfirmContrasena"></asp:TextBox>
            </div>
        </div>
    <div class="row justify-content-center">
            <asp:Button ID="btnAgregar_Administrador" runat="server" Text="Agregar Usuario" CssClass="btn btn-primary" OnClientClick="return confirm('Desea Agregar este usuario Administrador?');" OnClick="btnAgregar_Administrador_Click" />
        </div>
</formview>
<script type="text/javascript">
    window.onload = function () {
        var txtPassword = document.getElementById("<%=inputContrasena.ClientID%>");
        var txtConfirmPassword = document.getElementById("<%=inputConfirmContrasena.ClientID%>");
        txtPassword.onchange = ConfirmPassword;
        txtConfirmPassword.onkeyup = ConfirmPassword;
        function ConfirmPassword() {
            txtConfirmPassword.setCustomValidity("");
            if (txtPassword.value != txtConfirmPassword.value) {
                txtConfirmPassword.setCustomValidity("Las contraseñas no coinciden.");
            }
        }
    }
</script>
</asp:Content>
