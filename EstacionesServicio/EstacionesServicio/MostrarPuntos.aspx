<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarPuntos.aspx.cs" Inherits="EstacionesServicio.MostrarPuntos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando</span>
                </ProgressTemplate>
            </asp:UpdateProgress>

            <h3>Mostrar puntos de carga</h3>
            <br />
            <div>
                <label>-- Filtrar por tipo --</label><br />
                <asp:DropDownList ID="tipoDd" AutoPostBack="true" runat="server" OnSelectedIndexChanged="tipoDd_SelectedIndexChanged" Enabled="true">
                    <asp:ListItem Value="" Selected="True" Text="Todos"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Gasolina"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Electrico"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Hibrido"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="mt-5">
                <asp:GridView ID="puntosGrid" runat="server" AutoGenerateColumns="false" EmptyDataText="Aun no se han ingresado Puntos de Carga" CssClass="table table-hover" OnRowCommand="puntosGrid_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="IdPunto" DataField="IdPunto" />
                        <asp:BoundField HeaderText="Tipo" DataField="TipoTxt" />
                        <asp:BoundField HeaderText="Capacidad" DataField="Capacidad" />
                        <asp:BoundField HeaderText="Fecha Vencimiento" DataField="FechaVencimiento" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:TemplateField HeaderText="Eliminar">
                            <ItemTemplate>
                                <asp:Button runat="server" Text="ELIMINAR"
                                    CssClass="btn btn-danger" CommandName="eliminar"
                                    CommandArgument='<%# Eval("IdPunto") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
