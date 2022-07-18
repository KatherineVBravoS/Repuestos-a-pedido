<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Cotizar.aspx.cs" Inherits="proyecto.Vistas.Cotizar.Cotizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <formview>
        <h2>Cotice</h2>
        <div class="form-row">
            <div class="col-md-6 mb-3">
                <label for="inputNombre">Nombre</label>&nbsp;
                <asp:TextBox ID="inputNombre" runat="server" placeholder="Ej: Fernando" Width="495px"></asp:TextBox>
           </div>
            <div class="col-md-6 mb-3">
                <label for="inputTelefono">Telefono</label>&nbsp;
                <asp:TextBox ID="inputTelefono" runat="server" placeholder="Ej: 932587874" Width="495px"></asp:TextBox>
            </div>
            <div class="col-md-6 mb-3">
                <label for="inputCorreo">Correo</label>&nbsp;
                <asp:TextBox ID="inputCorreo" runat="server" placeholder="Ej: maria1232@gmail.com" Width="495px"></asp:TextBox>
            </div>
        </div>
  <div class="form-row">
      <div class="col-md-6 mb-3">
          <label for="inputChasis">Chasis / VIN</label>&nbsp;
          <asp:TextBox ID="inputChasis" runat="server" placeholder="Ej: 12345678901234567" Width="495px"></asp:TextBox>
       </div>
      
  </div>
        <div class="form-group">
            <label for="inputArea">Productos a Cotizar</label>&nbsp;
            <asp:TextBox ID="inputProductos" runat="server" Height="95px" placeholder="Ej: Buenas tardes solicito cotizacion....." Width="495px"></asp:TextBox>
        </div>
        <asp:Button ID="Cotiza" runat="server" Text="Cotizar" OnClick="Cotiza_Click" />
</formview>
</asp:Content>
