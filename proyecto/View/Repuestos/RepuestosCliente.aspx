<%@ Page Title="" Language="C#" MasterPageFile="~/View/Repuestos/MPRepuestosClientes.master" AutoEventWireup="true" CodeBehind="RepuestosCliente.aspx.cs" Inherits="proyecto.View.Repuestos.RepuestosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
    <h2>Repuestos</h2>
    <asp:GridView DataKeyNames="id_repuestos" runat="server" ID="GridRepuestosClientes" AutoGenerateColumns="False" OnRowEditing="GridRepuestosClientes_RowEditing" OnRowUpdating="GridRepuestosClientes_RowUpdating" OnPageIndexChanging="GridRepuestosClientes_PageIndexChanging"  OnRowDeleting="GridRepuestosClientes_RowDeleting" OnRowCancelingEdit="GridRepuestosClientes_RowCancelingEdit" Height="1419px" Width="1038px">  
    <Columns>
        <asp:TemplateField HeaderText="ID">
            <ItemTemplate>
                <asp:Label ID="Id_repuestos" runat="server" Text=' <%#Eval("id_repuestos")%>'></asp:Label>
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
                <asp:Label ID="txtPrecio" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputPrecio" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:TextBox>
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
        <EditItemTemplate>
                <asp:TextBox ID="inputDescripcion" runat="server" Text='<%# Eval("DESCRIPCION") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Imagen" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Image ID="ImagenBD" runat="server" Height="279px" Width="278px" BorderWidth="1px" 
                            ImageUrl='<%#"data:Image/png;base64,"+ Convert.ToBase64String((byte[])Eval("IMAGEN")) %>'></asp:Image>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:FileUpload ID="ImagenUpdate" runat="server"></asp:FileUpload>
            </EditItemTemplate>
        </asp:TemplateField>
        

    </Columns>
    </asp:GridView>
</asp:Content>
