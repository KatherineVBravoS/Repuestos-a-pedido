<%@ Page Title="" Language="C#" MasterPageFile="~/View/Usuario/MPUsuario.master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="proyecto.Repuestos.VerUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

    <h2>Ver Usuarios</h2>
    <asp:GridView DataKeyNames="id_administrador" runat="server" ID="GridUsuariosAdministrador" AutoGenerateColumns="False" OnRowEditing="GridUsuariosAdministrador_RowEditing" OnRowUpdating="GridUsuariosAdministrador_RowUpdating" OnPageIndexChanging="GridUsuariosAdministrador_PageIndexChanging"  OnRowDeleting="GridUsuariosAdministrador_RowDeleting" OnRowCancelingEdit="GridUsuariosAdministrador_RowCancelingEdit">  
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
                <asp:Label ID="Id_administrador" runat="server" Text=' <%#Eval("id_administrador")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombre" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtNombreAdministrador" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputNombreAdministrador" runat="server" Text='<%# Eval("nombre") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Contraseña" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtContraAdministrador" type="password" runat="server" Text="***********"></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputContraAdministrador" runat="server" Text='<%# Eval("contrasena") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Editar" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:LinkButton ID="LkB1" runat="server" CommandName="Edit">Editar</asp:LinkButton>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:LinkButton ID="LkB2" runat="server" CommandName="Update">Update</asp:LinkButton>
                <asp:LinkButton ID="LkB3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Eliminar" HeaderStyle-Width="100px">
            <ItemTemplate>
                <asp:LinkButton ID="LkB11" runat="server" CommandName="Delete" OnClientClick="return confirm('Está seguro que desea eliminar este registro?');" >Eliminar</asp:LinkButton>
            </ItemTemplate>
            </asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Content>