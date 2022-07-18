<%@ Page Title="" Language="C#" MasterPageFile="~/View/Clientes/MPClientes.master" AutoEventWireup="true" CodeBehind="InicioCliente.aspx.cs" Inherits="proyecto.View.Clientes.InicioCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    Bienvenido!

     <asp:LinkButton ID="cierraSesion" runat="server" OnClick="cierraSesion_Click">Cerrar Sesión</asp:LinkButton>
</asp:Content>
