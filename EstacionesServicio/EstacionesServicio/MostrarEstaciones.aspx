<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarEstaciones.aspx.cs" Inherits="EstacionesServicio.MostrarEstaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando...</span>
                </ProgressTemplate>

            </asp:UpdateProgress>

            <h3>Mostrar estaciones de servicio</h3>

            <div class="mt-5">
                <asp:GridView ID="estacionesGrid" runat="server" AutoGenerateColumns="false" EmptyDataText="Aun no se han ingresado Estaciones de Servicio." CssClass="table table-hover" OnRowCommand="estacionesGrid_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="Id Estacion" DataField="IdEstacion" />
                        <asp:BoundField HeaderText="Capacidad Maxima" DataField="Capacidad" />
                        <asp:TemplateField HeaderText="Eliminar">
                            <ItemTemplate>
                                <asp:Button runat="server" Text="ELIMINAR"
                                    CssClass="btn btn-danger" CommandName="eliminar"
                                    CommandArgument='<%# Eval("IdEstacion") %>'></asp:Button>

                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
