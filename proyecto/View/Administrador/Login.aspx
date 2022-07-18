<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="proyecto.View.Administrador.Login" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <formview defaultbutton="btnLogin_Administrador">
        <div class="wrapper fadeInDown">
            <div id="formContent">
                <div class="fadeIn first">
                        <img src="../../images/administrador.png" id="icon" width="50" height="200" />
                </div>
                <formview>
                    <asp:TextBox ID="txtLogin" CssClass="form-control" runat="server" placeholder="Nombre Usuario"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" runat="server" placeholder="Contraseña"></asp:TextBox>
                    <asp:Label ID="txtError" Visible="false" CssClass="alert-danger" ForeColor="Red" runat="server"></asp:Label>
                    <asp:Button ID="btnLogin_Administrador" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary" OnClick="btnLogin_Administrador_Click"/>
                <div id="formFooter">
                    <a class="underlineHover" href="#">Olvido la Contraseña?</a>
                </div>

            </div>
        </div>
    </formview>
</asp:Content>
