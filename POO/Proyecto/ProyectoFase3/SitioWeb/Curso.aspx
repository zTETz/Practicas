﻿<%@ Page Language="C#" MasterPageFile="PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="SitioWeb.Curso" %>


<asp:Content ID="ContenidoHeader" ContentPlaceHolderID="ContenidoHeader" runat="server">
    <!--Codigo para el header-->
</asp:Content>

<asp:Content ID="ContenidoMain" ContentPlaceHolderID="ContenidoMain" runat="server">
    <form id="form1" runat="server">

        <div>
            <h1>Listado de Cursos</h1>
            <hr />
        </div>
        <div class="row">
            <div class="input-field col s6">
                <label>Nombre Curso</label> 
                <br />
                <asp:TextBox ID="txtBuscar" runat="server" class=""></asp:TextBox>
            </div>
            <div class="input-field col s6">
                <asp:Button class="btn" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscarProducto_Click" />
                <asp:Button class="btn btn-info" ID="btnAgregar" runat="server" Text="Agregar Nuevo" OnClick="btnAgregar_Click" />
                <asp:Button class="btn btn-warning" ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            </div>
            <br />
        </div>
        <div class="formulario">
            <asp:GridView ID="grdLista" runat="server" AutoGenerateColumns="False" AllowPaging="True" EmptyDataText="No existen registros para mostrar" Width="100%" OnPageIndexChanging="grdLista_PageIndexChanging" PageSize="8" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server" CommandArgument='<%# Eval("ID_Curso").ToString() %>' CommandName="Modificar" OnCommand="lnkModificar_Command">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" CommandArgument='<%# Eval("ID_Curso").ToString() %>' CommandName="Eliminar" OnCommand="lnkEliminar_Command1">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField Visible="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("ID_Curso").ToString() %>' CommandName="Seleccionar" OnCommand="lnkSeleccionar_Command1">Seleccionar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ID_Curso" HeaderText="ID_Curso" />
                    <asp:BoundField DataField="ID_Nota" HeaderText="ID_Nota" />
                    <asp:BoundField DataField="ID_Idioma" HeaderText="ID_Idioma" />
                    <asp:BoundField DataField="NombreCurso" HeaderText="NombreCurso" />
                    <asp:BoundField DataField="CantidadCursos" HeaderText="CantidadCursos" />
                    <asp:BoundField DataField="HorasCurso" HeaderText="HorasCurso" />
                    <asp:BoundField DataField="HorasSincronicas" HeaderText="HorasSincronicas" />
                    <asp:BoundField DataField="HorasAsincronicas" HeaderText="HorasAsincronicas" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</asp:Content>


<asp:Content ID="ContenidoFooterDefault" ContentPlaceHolderID="ContenidoFooter" runat="server">
</asp:Content>

