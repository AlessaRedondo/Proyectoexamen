<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="MENUPRINCIPAL.aspx.vb" Inherits="WEBEMPRESARIAL.MENUPRINCIPAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style7 {
            width: 152px;
            color: #FFFFFF;
        }
    .auto-style8 {
        font-weight: bold;
        color: #008000;
    }
    .auto-style9 {
        color: #008000;
    }
    .auto-style10 {
        font-weight: bold;
    }
    .auto-style11 {
        width: 160px;
        color: #FFFFFF;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
        <tr>
            <td colspan="3">
                <hr />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Panel ID="Panel1" runat="server" BackColor="#000066">
                    <table class="auto-style3">
                        <tr>
                            <td class="auto-style11">USUARIO EN LINEA :</td>
                            <td>
                                <asp:Label ID="LBLUSUARIO" runat="server" CssClass="auto-style8" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">NOMBRE:</td>
                            <td>
                                <asp:Label ID="LBLNOMBRE" runat="server" CssClass="auto-style9" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" CssClass="auto-style10" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px">
                                    <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <DynamicMenuStyle BackColor="#F7F6F3" />
                                    <DynamicSelectedStyle BackColor="#5D7B9D" />
                                    <Items>
                                        <asp:MenuItem Text="HABITCIONES" Value="HABITCIONES">
                                            <asp:MenuItem Text="AGREGAR" Value="AGREGAR" NavigateUrl="~/AGREGARHABITACION.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ACTUALIZAR" Value="ACTUALIZAR" NavigateUrl="~/ACTUALIZARHABITACION.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ELIMINAR" Value="ELIMINAR" NavigateUrl="~/ELIMINARHABITACION.aspx"></asp:MenuItem>
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="RESERVAS" Value="RESERVAS"></asp:MenuItem>
                                        <asp:MenuItem Text="COTIZACIONES" Value="COTIZACIONES"></asp:MenuItem>
                                        <asp:MenuItem Text="APARTAMENTOS" Value="APARTAMENTOS">
                                            <asp:MenuItem Text="AGREGAR" Value="AGREGAR" NavigateUrl="~/AGREGARAPARTAMENTO.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ACTUALIZAR" Value="ACTUALIZAR" NavigateUrl="~/ACTUALIZARAPARTAMENTO.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ELIMINAR" Value="ELIMINAR" NavigateUrl="~/ELIMINARAPARTAMENTO1.aspx"></asp:MenuItem>
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="EMPLEADOS" Value="EMPLEADOS">
                                            <asp:MenuItem Selected="True" Text="NUEVO" Value="NUEVO" NavigateUrl="~/AGREGARUSUARIO.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ACTUALIZAR" Value="ACTUALIZAR" NavigateUrl="~/ACTUALIZAR.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ELIMINAR" Value="ELIMINAR" NavigateUrl="~/Eliminar.aspx"></asp:MenuItem>
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="CLIENTE" Value="CLIENTE">
                                            <asp:MenuItem Text="AGREGAR" Value="AGREGAR" NavigateUrl="~/NUEVOCLIENTE1.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ACTUALIZAR" Value="ACTUALIZAR" NavigateUrl="~/ACTUALIZARCLIENTE.aspx"></asp:MenuItem>
                                            <asp:MenuItem Text="ELIMINAR" Value="ELIMINAR" NavigateUrl="~/ELIMINARCLIENTE.aspx"></asp:MenuItem>
                                        </asp:MenuItem>
                                    </Items>
                                    <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <StaticSelectedStyle BackColor="#5D7B9D" />
                                </asp:Menu>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
