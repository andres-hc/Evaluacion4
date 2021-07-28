<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="EditarPuntos.aspx.cs" Inherits="EstacionesServicio.EditarPuntos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <h3>Editar Punto Carga</h3>
    <br />
    <div>
        <div class="card">
            <div class="card-body">

                <div class="form-group">
                    <label for="idDdw">Seleccione ID a Editar</label>
                    <asp:DropDownList ID="idDdw" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="card">
            <div class="card-body">
                <div class="form-group">
                    <div class="form-group">
                        <label for="tipoDdw">Seleccione nuevo Tipo</label>
                        <asp:DropDownList ID="tipoDdw" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                    <br />
                    <div class="form-group">
                        <label for="capacidadTxt">Ingrese nueva capacidad maxima</label>
                        <asp:TextBox ID="capacidadTxt" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese Capacidad maxima" required></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <label for="fechaTxt">Ingrese nueva fecha vencimiento</label>
                        <asp:TextBox ID="fechaTxt" CssClass="form-control" type="date" runat="server" required></asp:TextBox>
                    </div>
                    <br />
                    <asp:Button ID="editarPtoBtn" runat="server" Text="Editar" CssClass="btn btn-primary" OnClick="editarPtoBtn_Click" />
                    <br />
                    <div>
                        <asp:Label ID="confirmacion" runat="server" CssClass="text-success"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
