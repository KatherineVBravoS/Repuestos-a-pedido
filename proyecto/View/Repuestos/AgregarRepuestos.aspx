<%@ Page Title="" Language="C#" MasterPageFile="~/View/Repuestos/MPRepuestos.master" AutoEventWireup="true" CodeBehind="AgregarRepuestos.aspx.cs" Inherits="proyecto.Repuestos.AgregarRepuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <script src="../../JS/validacion.js"></script>
    <formview id="Repuestos" runat="server">
        <asp:LinkButton ID="Atras" runat="server" OnClick="Atras_Click">Volver atras</asp:LinkButton>
        <h2>Agregar Repuesto</h2>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputNombreRepuesto1">Repuesto</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" id="inputNombreRepuesto1" placeholder="Ej: Espejo" Width="495px"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputMarca">Marca</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" id="inputMarca" placeholder="Ej: Chevrolet" Width="537px"></asp:TextBox>
            </div>
        </div>

        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputModelo">Modelo</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputModelo" placeholder="Ej: Tracker" Width="529px"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputModelo">Numero de parte</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="TextBox1" placeholder="Ej: 105023" Width="529px"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputPrecio">Precio</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputPrecio" placeholder="Ej: 10000" Width="171px"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" for="inputSTock">Stock</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputStock" placeholder="Ej: 10" OnTextChanged="inputStock_TextChanged" Width="136px"></asp:TextBox>
                <br />
            <div class="form-group col-md-6" style="left: -10px; top: 0px">
                <asp:Label runat="server" for="inputDescripcion">Descripcion</asp:Label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="inputDescripcion" placeholder="Ej: este articulo..." Width="529px"></asp:TextBox>
            </div>
            </div>
        </div>

        <div class="row justify-content-center">
            <asp:FileUpload ID="uploadImage" runat="server" />
            <br />
        </div>
        <div class="row justify-content-center">
            <asp:Image ID="imgUploaded" runat="server" Width="250" Height="250" BorderColor="Black" BorderStyle="Solid" BorderWidth="1" onchange="mostarimagen()"  />
            <br />
            <br />
            <br />
            <br />
        </div>
        <div class="row justify-content-center">
            <asp:Button ID="btnEnviar_cambio" runat="server" Text="Agregar Repuesto" CssClass="btn btn-primary" OnClientClick="return confirm('Desea Agregar este respuesto?');" OnClick="btnAgregar_Repuesto_Click" />
        </div>
</formview>
     </asp:Content>
