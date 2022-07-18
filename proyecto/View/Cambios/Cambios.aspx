<%@ Page Title="" Language="C#" MasterPageFile="~/View/Cambios/Cambios.master" AutoEventWireup="true" CodeBehind="Cambios.aspx.cs" Inherits="proyecto.Cambios.AdministrarCambios" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <script src="../../JS/validacion.js"></script>
    <formview id="Repuestos" runat="server">
        <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
        <h2>Cambios / Devoluciones</h2>
    <div class="form-row">
        <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputNParte">Numero de partes</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputNumeroParte" placeholder="Ej: 1502145" Width="171px"></asp:TextBox>
        </div>
        <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputProducto">Nombre Producto</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputProducto" placeholder="Ej: espejo" Width="171px"></asp:TextBox>
        </div>
        <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputCantidad">Cantidad</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputCantidad" placeholder="Ej: 1" Width="163px"></asp:TextBox>
        </div>
        <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputBoleta">Boleta o Factura</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputBoleta" placeholder="Ej: Boleta" Width="171px"></asp:TextBox>
        </div>
        <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputRut">Rut cliente</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputRut" placeholder="Ej: 15021455-5" Width="171px"></asp:TextBox>
        </div>
         <div class="row justify-content-center">
                        <asp:Button ID="btnEnviar_cambio" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClientClick="return confirm('Desea Agregar este respuesto?');" OnClick="btnEnviar_Cambio_Click" />
        </div>
        </div>

</formview>
</asp:Content>