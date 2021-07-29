<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarPunto.aspx.cs" Inherits="EstacionesServicio.IngresarPunto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3>Registrar Punto Carga</h3>
    <br />
    <div>
        <div class="card">
            <div class="card-body">
                <br />
                <div class="form-group">
                    <label for="idPuntoTxt">Identificador Punto Carga</label>
                    <asp:TextBox ID="idPuntoTxt" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese identificador unico" required></asp:TextBox>

                </div>
                <br />
                <div class="form-group">
                    <label for="capacidadTxt">Capacidad Maxima</label>
                    <asp:TextBox ID="capacidadTxt" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese Capacidad maxima" required></asp:TextBox>

                </div>
                <br />
                <div class="form-group">
                    <label for="tipoDdw">Tipo</label>
                    <asp:DropDownList ID="tipoDdw" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <br />
                <div class="form-group">
                    <label for="fechaTxt">Fecha Vencimiento</label>
                    <asp:TextBox ID="fechaTxt" CssClass="form-control" type="date" runat="server" required></asp:TextBox>
                </div>
                <br />

                <asp:Button ID="registrarPtoBtn" runat="server" Text="Registrar" CssClass="btn btn-outline-primary" OnClick="registrarPtoBtn_Click" />
                <br />
                <div>
                    <asp:Label ID="confirmacion" runat="server" CssClass="text-success"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="confirmacionneg" runat="server" CssClass="text-danger"></asp:Label>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
