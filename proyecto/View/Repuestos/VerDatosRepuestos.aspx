<%@ Page Title="" Language="C#" MasterPageFile="~/View/Repuestos/MPRepuestos.master" AutoEventWireup="true" CodeBehind="VerDatosRepuestos.aspx.cs" Inherits="proyecto.Repuestos.VerDatosRepuestos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
    <h2>Ver Datos Repuestos</h2>
    <asp:GridView DataKeyNames="id_repuestos" runat="server" ID="GridRepuestos" AutoGenerateColumns="False" OnRowEditing="GridRepuestos_RowEditing" OnRowUpdating="GridRepuestos_RowUpdating" OnPageIndexChanging="GridRepuestos_PageIndexChanging"  OnRowDeleting="GridRepuestos_RowDeleting" OnRowCancelingEdit="GridRepuestos_RowCancelingEdit">  
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
                <asp:Label ID="Id_repuesto" runat="server" Text=' <%#Eval("id_repuestos")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombre" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtNombre" runat="server" Text='<%# Eval("NOMBRE_REPUESTO") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputNombre" runat="server" Text='<%# Eval("NOMBRE_REPUESTO") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Marca" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtMarca" runat="server" Text='<%# Eval("MARCA") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputMarca" runat="server" Text='<%# Eval("MARCA") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Modelo" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtModelo" runat="server" Text='<%# Eval("MODELO") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputModelo" runat="server" Text='<%# Eval("MODELO") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Numero Parte" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtN_PARTE" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputN_PARTE" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Precio" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtPrecio" runat="server" Text='<%# Eval("PRECIO") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputPrecio" runat="server" Text='<%# Eval("PRECIO") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Stock" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtStock" runat="server" Text='<%# Eval("STOCK") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputStock" runat="server" Text='<%# Eval("STOCK") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="descripcion" HeaderStyle-Width="150px">
        <ItemTemplate>
                <asp:Label ID="txtDescripcion" runat="server" Text='<%# Eval("DESCRIPCION") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
                <asp:TextBox ID="inputDescripcion" runat="server" Text='<%# Eval("DESCRIPCION") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Imagen" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Image ID="ImagenBD" runat="server" Height="100px" Width="100px"
                    ImageUrl='<%#"data:Image/png;base64,"+ Convert.ToBase64String((byte[])Eval("IMAGEN")) %>'></asp:Image>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:FileUpload ID="ImagenUpdate" runat="server"></asp:FileUpload>
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
