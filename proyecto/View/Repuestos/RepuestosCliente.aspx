<%@ Page Title="" Language="C#" MasterPageFile="~/View/Repuestos/MPRepuestosClientes.master" AutoEventWireup="true" CodeBehind="RepuestosCliente.aspx.cs" Inherits="proyecto.View.Repuestos.RepuestosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
    <h2>Repuestos</h2>
    <asp:GridView DataKeyNames="id_repuestos" runat="server" ID="GridRepuestosClientes" AutoGenerateColumns="False" OnRowEditing="GridRepuestosClientes_RowEditing" OnRowUpdating="GridRepuestosClientes_RowUpdating" OnPageIndexChanging="GridRepuestosClientes_PageIndexChanging"  OnRowDeleting="GridRepuestosClientes_RowDeleting" OnRowCancelingEdit="GridRepuestosClientes_RowCancelingEdit" Height="1226px" Width="944px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridRepuestosClientes_SelectedIndexChanged">  
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

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Marca" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtMarca" runat="server" Text='<%# Eval("MARCA") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputMarca" runat="server" Text='<%# Eval("MARCA") %>'></asp:TextBox>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Modelo" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtModelo" runat="server" Text='<%# Eval("MODELO") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputModelo" runat="server" Text='<%# Eval("MODELO") %>'></asp:TextBox>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Numero Parte" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtN_Parte" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputN_Parte" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:TextBox>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Precio" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtPrecio" runat="server" Text='<%# Eval("PRECIO") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputPrecio" runat="server" Text='<%# Eval("PRECIO") %>'></asp:TextBox>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Stock" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Label ID="txtStock" runat="server" Text='<%# Eval("STOCK") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="inputStock" runat="server" Text='<%# Eval("STOCK") %>'></asp:TextBox>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="descripcion" HeaderStyle-Width="150px">
        <ItemTemplate>
                <asp:Label ID="txtDescripcion" runat="server" Text='<%# Eval("DESCRIPCION") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
                <asp:TextBox ID="inputDescripcion" runat="server" Text='<%# Eval("DESCRIPCION") %>'></asp:TextBox>
            </EditItemTemplate>
            <HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Imagen" HeaderStyle-Width="150px">
            <ItemTemplate>
                <asp:Image ID="ImagenBD" runat="server" Height="279px" Width="278px" BorderWidth="1px" 
                            ImageUrl='<%#"data:Image/png;base64,"+ Convert.ToBase64String((byte[])Eval("IMAGEN")) %>'></asp:Image>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:FileUpload ID="ImagenUpdate" runat="server"></asp:FileUpload>
            </EditItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
        </asp:TemplateField>
        

    </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
</asp:Content>
