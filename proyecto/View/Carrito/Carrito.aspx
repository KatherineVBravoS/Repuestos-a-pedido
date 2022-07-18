<%@ Page Title="" Language="C#" MasterPageFile="~/View/Carrito/MPCarrito.master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="proyecto.Vistas.Carrito.Carrito" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Shopping Cart</h1></div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        DataKeyNames="id_administrador"
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="Nombre" HeaderText="ID" SortExpression="ProductID" />        
        <asp:BoundField DataField="Product.ProductName" HeaderText="Name" />        
        <asp:BoundField DataField="Product.UnitPrice" HeaderText="Price (each)" DataFormatString="{0:c}"/>     
        <asp:TemplateField   HeaderText="Quantity">            
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox> 
                </ItemTemplate>        
        </asp:TemplateField>    
        <asp:TemplateField HeaderText="Item Total">            
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) *  Convert.ToDouble(Item.Product.UnitPrice)))%>
                </ItemTemplate>        
        </asp:TemplateField> 
        <asp:TemplateField HeaderText="Remove Item">            
                <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>        
        </asp:TemplateField>    
        </Columns>    
    </asp:GridView>
    <div> 
            <table class="w-100">
                <tr>
                    <td style="width: 432px; height: 31px"> 
        <h2 class="titulo" style="width: 180px">Resumen del pedido</h2>
                    </td>
                    <td style="height: 31px"></td>
                    <td style="height: 31px"></td>
                </tr>
                <tr>
                    <td style="width: 432px; height: 32px;">Sub Total</td>
                    <td style="height: 32px"></td>
                </tr>
                <tr>
                    <td style="width: 432px">Envio</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 432px">Descuento</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 432px">Total</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 432px">
                    <a href="/View/Carrito/Pago.aspx" class="btn btn-block primary" title="Proceder al Pago">Proceder al Pago</a>                    

                    </td>
                    
                </tr>
            </table>
        <div></div>


        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong> 
    </div>
    <br />
</asp:Content>

