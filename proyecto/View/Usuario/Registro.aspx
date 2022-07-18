<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="proyecto.View.Usuario.Registro" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <formview id="form1" runat="server">
        <h2>Registro</h2>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputNombre">Nombre</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputNombre4" placeholder="Ej: Juan Ignacio" Width="500px"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputApellido4">Apellido</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputApellido4" placeholder="Ej: Perez Basualto" Width="499px"></asp:TextBox>
             </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputDireccion">Direccion</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputDireccion" placeholder="Ej: Matucana 100" Width="490px"></asp:TextBox>
             </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputCiudad">Ciudad</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputCiudad" placeholder="Ej: Santiago" Width="347px"></asp:TextBox>
             </div>
         </div>
         <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputRut">Rut</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputRut" placeholder="Ej: 10024544-5" Width="364px"></asp:TextBox>
             </div>
            <div class="form-group col-md-5">
                <asp:Label runat="server" for="inputTelefono4">Telefono</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputTelefono4" placeholder="+569 " Width="510px"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputCorreo">Correo</asp:Label>
                <asp:TextBox runat="server" type="email" class="form-control" ID="inputCorreo" placeholder="ejemplo@ejemplo.cl" Width="526px" Height="54px"></asp:TextBox>
             </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputConfirmarCorreo">Confirmar Correo</asp:Label>
                <asp:TextBox runat="server" type="email" class="form-control" ID="inputConfirmarCorreo" placeholder="ejemplo@ejemplo.cl" Width="427px" Height="53px"></asp:TextBox>
             </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputContrasenaCliente">Contraseña</asp:Label>
                <asp:TextBox runat="server" type="password" class="form-control" ID="inputContrasenaCliente" Width="476px" ></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputConfirmarContrasenaCliente">Confirmar Contraseña</asp:Label>
                <asp:TextBox runat="server" type="password" class="form-control" ID="inputConfirmarContrasenaCliente" Width="480px" ></asp:TextBox>
            </div>
        </div>
        <div class="row justify-content-center">
            <asp:Button ID="btnRegistroUser" runat="server" Text="Registrarse" CssClass="btn btn-primary" OnClientClick="return confirm('Desea Registrarse?');" OnClick="btnRegistroUser_Click" />
        </div>
</formview>
<script type="text/javascript">
    window.onload = function () {
        var txtPassword = document.getElementById("<%=inputContrasenaCliente.ClientID%>");
        var txtConfirmPassword = document.getElementById("<%=inputConfirmarContrasenaCliente.ClientID%>");
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
<asp:Content ID="Content4" runat="server" contentplaceholderid="head">
    </asp:Content>

