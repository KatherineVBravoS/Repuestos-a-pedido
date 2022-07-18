<%@ Page Title="" Language="C#" MasterPageFile="~/View/Administrador/MPAdministrador.master" AutoEventWireup="true" CodeBehind="Panel_Administrador.aspx.cs" Inherits="proyecto.View.Administrador.Panel_Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    Bienvenido Administrador!<div id="pie" class="auto-style1">

        <asp:LinkButton ID="cierraSesion" runat="server" OnClick="cierraSesion_Click">Cerrar Sesión</asp:LinkButton>
   </div>
</asp:Content>

