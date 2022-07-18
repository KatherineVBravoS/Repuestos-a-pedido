<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaAdministrador.Master" AutoEventWireup="true" CodeBehind="AdministrarCotizaciones.aspx.cs" Inherits="proyecto.View.Cotizar.AdministrarCotizaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
    <h2>Ver Cotizaciones</h2>
    <asp:GridView DataKeyNames="chasis" runat="server" ID="GridVerCotizacion" AutoGenerateColumns="False" OnRowEditing="GridVerCotizacion_RowEditing" OnRowUpdating="GridVerCotizacion_RowUpdating" OnPageIndexChanging="GridVerCotizacion_PageIndexChanging"  OnRowDeleting="GridVerCotizacion_RowDeleting" OnRowCancelingEdit="GridVerCotizacion_RowCancelingEdit">  
    <Columns>
    <asp:TemplateField HeaderText="Nombre">
            <ItemTemplate>
                <asp:Label ID="inputNombre" runat="server" Text=' <%#Eval("nombre")%>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputNombre" runat="server" Text='<%# Eval("nombre") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Telefono" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputTelefono" runat="server" Text='<%# Eval("telefono") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputTelefono" runat="server" Text='<%# Eval("telefono") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Correo" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputCorreo" runat="server" Text='<%# Eval("correo") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputCorreo" runat="server" Text='<%# Eval("correo") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Chasis" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputChasis" runat="server" Text='<%# Eval("chasis") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputChasis" runat="server" Text='<%# Eval("chasis") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Cotizacion" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputProductos" runat="server" Text='<%# Eval("producto_cotizar") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputProductos" runat="server" Text='<%# Eval("producto_cotizar") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Editar" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:LinkButton ID="lkbEditar" runat="server" CommandName="Edit">Editar</asp:LinkButton>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:LinkButton ID="LkBUpdate" runat="server" CommandName="Update">Aceptar</asp:LinkButton>
                <asp:LinkButton ID="LkBCancelar" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Eliminar" HeaderStyle-Width="100px">
            <ItemTemplate>
                <asp:LinkButton ID="LkBEliminar" runat="server" CommandName="Delete" OnClientClick="return confirm('Está seguro que desea eliminar este registro?');" >Eliminar</asp:LinkButton>
            </ItemTemplate> 
            </asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Content>


