<%@ Page Title="" Language="C#" MasterPageFile="~/View/Cambios/Cambios.master" AutoEventWireup="true" CodeBehind="ListaCambios.aspx.cs" Inherits="proyecto.View.Cambios.ListaCambios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
    <h2>Ver Datos Repuestos</h2>
    <asp:GridView DataKeyNames="n_parte" runat="server" ID="GridCambios" AutoGenerateColumns="False" OnRowEditing="GridCambios_RowEditing" OnRowUpdating="GridCambios_RowUpdating" OnPageIndexChanging="GridCambios_PageIndexChanging"  OnRowDeleting="GridCambios_RowDeleting" OnRowCancelingEdit="GridCambios_RowCancelingEdit">  
    <Columns>
       <asp:TemplateField HeaderText="Numero de parte" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputNParte" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputNParte" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombre Producto" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputProducto" runat="server" Text='<%# Eval("NOMBRE_PRODUCTO") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputProducto" runat="server" Text='<%# Eval("NOMBRE_PRODUCTO") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Cantidad" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputCantidad" runat="server" Text='<%# Eval("CANTIDAD") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputCantidad" runat="server" Text='<%# Eval("CANTIDAD") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Boleta o Factura" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputBoleta" runat="server" Text='<%# Eval("BOLETA_FACTURA") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputBoleta" runat="server" Text='<%# Eval("BOLETA_FACTURA") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Rut" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="inputRut" runat="server" Text='<%# Eval("RUT") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputRut" runat="server" Text='<%# Eval("RUT") %>'></asp:TextBox>
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
