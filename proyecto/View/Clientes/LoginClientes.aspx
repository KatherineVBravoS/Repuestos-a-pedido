<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="LoginClientes.aspx.cs" Inherits="proyecto.View.Clientes.LoginClientes" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <formview defaultbutton="btnLogin_Administrador">
        <div class="wrapper fadeInDown">
            <div id="formContent">
                <div class="fadeIn first">
                        <img class="auto-style8" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ6hVtYGub9FuB1t89n58tuhoF53S9LWfzBw&usqp=CAU" data-src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ6hVtYGub9FuB1t89n58tuhoF53S9LWfzBw&usqp=CAU" alt="" data-srcset="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ6hVtYGub9FuB1t89n58tuhoF53S9LWfzBw&usqp=CAU 194w, https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ6hVtYGub9FuB1t89n58tuhoF53S9LWfzBw&usqp=CAU 291w" sizes="(max-width: 97px) 100vw, 97px" srcset="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ6hVtYGub9FuB1t89n58tuhoF53S9LWfzBw&usqp=CAU 194w, https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ6hVtYGub9FuB1t89n58tuhoF53S9LWfzBw&usqp=CAU 291w">
                </div>
                <formview>
                    <asp:TextBox ID="txtLogin" CssClass="form-control" runat="server" placeholder="Correo Usuario"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" runat="server" placeholder="Contraseña"></asp:TextBox>
                    <asp:Label ID="txtError" Visible="false" CssClass="alert-danger" ForeColor="Red" runat="server"></asp:Label>
                    <asp:Button ID="btnLogin_Clientes" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary" OnClick="btnLogin_Clientes_Click"/>
                <div id="formFooter">
                    <a class="underlineHover" href="#">¿Olvidaste la Contraseña?</a>
                </div>

            </div>
        </div>
    </formview>
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style8 {
            width: 219px;
            height: 184px;
        }
    </style>
</asp:Content>

