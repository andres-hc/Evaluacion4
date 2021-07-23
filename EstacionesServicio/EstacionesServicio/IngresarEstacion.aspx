<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarEstacion.aspx.cs" Inherits="EstacionesServicio.IngresarEstacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <br />
        <h3 class="align-content-center">Registrar Estacion Servicio</h3>
        <br />
        <div class="card">
            <div class="card-body">

                <div class="mb-3">
                    <label for="idEstacionTxt" class="form-label">Ingresar ID </label>
                    <asp:TextBox type="number" runat="server" class="form-control" id="idEstacionTxt" placeholder="Ingrese identificador unico" required></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="capacidadTxt" class="form-label">Ingresar capacidad maxima </label>
                    <asp:TextBox type="number" runat="server" class="form-control" id="capacidadTxt" placeholder="Ingrese capacidad maxima" required></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Button ID="registrarEstacion" runat="server" class="btn btn-primary" OnClick="registrarEstacion_Click" Text="Registrar"/>
                </div>
                <br />
                <div>
                    <asp:Label ID="confirmacion" runat="server" CssClass="text-success"></asp:Label>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
