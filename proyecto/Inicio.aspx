<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="proyecto.Default" %>
<asp:Content ID="BarraBuscar" ContentPlaceHolderID="buscadores" runat="server">
      <nav class="navbar navbar-black bg-black">
                        <formview class="form-inline">
                            <a class="navbar-brand">Selecciona tu auto&nbsp;&nbsp;&nbsp;&nbsp; </a>

                 <asp:Label runat="server" for="inputMarca">Marca</asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="DlMarca">
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
                 <asp:Label runat="server" for="inputModelo">Modelo</asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="DlModelo">
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
                 <asp:Label runat="server" for="inputAño">Año</asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:DropDownList runat="server" ID="DlAnio">
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="Buscar" runat="server" Text="Buscar" OnClick="Buscar_Click" />
                        </formview>
                    </nav>
</asp:Content>


<asp:Content ID="Productos" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:DataList DataKeyFiles="id_repuestos" runat="server" ID="dtProductos" 
        RepeatColumns="4" RepeatDirection="Horizontal" CellPadding="4" Height="863px" ForeColor="#333333" OnSelectedIndexChanged="dtProductos_SelectedIndexChanged" >  
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
        <ItemTemplate>
            <table>
                <tr>
                    <td style="text-align: center;" background-color="5f98f3">
                        <asp:Label ID="Label4" runat="server" Text="Nombre: "></asp:Label>
                        <asp:Label ID="txtNombre" runat="server" Text='<%# Eval("NOMBRE_REPUESTO") %>' Font-Bold="true"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: center;">
                        <asp:Image ID="ImagenBD" runat="server" Height="279px" Width="278px" BorderWidth="1px" 
                            ImageUrl='<%#"data:Image/png;base64,"+ Convert.ToBase64String((byte[])Eval("IMAGEN")) %>'></asp:Image>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: center;" background-color="5f98f3">
                        <asp:Label ID="Label3" runat="server" Text="Marca: "></asp:Label>
                        <asp:Label ID="txtMarca" runat="server" Text='<%# Eval("MARCA") %>' Font-Bold="true"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: center;" background-color="5f98f3">
                        <asp:Label ID="Label2" runat="server" Text="Modelo: "></asp:Label>
                        <asp:Label ID="txtModelo" runat="server" Text='<%# Eval("MODELO") %>' Font-Bold="true"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td style="text-align: center;">
                        <asp:Label ID="Label1" runat="server" Text="Numero de parte: $"></asp:Label>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("N_PARTE") %>'></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td style="text-align: center;">
                        <asp:Label ID="Label5" runat="server" Text="Descripción: $"></asp:Label>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("DESCRIPCION") %>'></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td style="text-align: center;">
                        <asp:Label ID="txtPeso" runat="server" Text="Precio: $"></asp:Label>
                        <asp:Label ID="txtPrecio" runat="server" Text='<%# Eval("PRECIO") %>'></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td style="text-align: center;">
                        <asp:LinkButton ID="AgregarProducto" runat="server" CommandArgument='<%# Eval("id_repuestos") %>'
                            CommandName="AgregarAlCarrito"> Agregar al Carrito</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
</asp:Content>