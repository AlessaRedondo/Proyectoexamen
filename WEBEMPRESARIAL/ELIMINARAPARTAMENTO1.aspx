<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ELIMINARAPARTAMENTO1.aspx.vb" Inherits="WEBEMPRESARIAL.ELIMINARAPARTAMENTO1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">



    .auto-style5 {
        width: 99%;
    }
        .auto-style34 {
            width: 344px;
            height: 21px;
        }
        .auto-style35 {
            width: 723px;
            height: 21px;
        }
        .auto-style36 {
            height: 21px;
        }
        .auto-style30 {
            width: 344px;
            height: 392px;
        }
        .auto-style31 {
            width: 723px;
            height: 392px;
        }
        .auto-style3 {
        width: 91%;
    }
    .auto-style14 {
        width: 293px;
        text-align: right;
    }
    .auto-style9 {
        width: 152px;
    }
        .auto-style22 {
            text-align: center;
        }
        .auto-style28 {
            width: 306px;
        }
        .auto-style18 {
            width: 293px;
            text-align: right;
            height: 26px;
        }
        .auto-style19 {
            width: 152px;
            height: 26px;
        }
        .auto-style20 {
            height: 26px;
        }
        .auto-style21 {
            width: 306px;
            height: 26px;
        }
        .auto-style15 {
            width: 293px;
            height: 23px;
            text-align: right;
        }
        .auto-style7 {
        height: 23px;
    }
    .auto-style10 {
        height: 23px;
        width: 152px;
    }
        .auto-style29 {
            width: 306px;
            height: 23px;
        }
        .auto-style27 {
            width: 293px;
            height: 23px;
        }
        .auto-style23 {
            width: 100%;
        }
        .auto-style33 {
            height: 94px;
        }
        .auto-style32 {
            height: 392px;
        }
        .auto-style24 {
            width: 344px;
            height: 23px;
        }
        .auto-style25 {
            width: 723px;
            height: 23px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style5">
        <tr>
            <td class="auto-style34"></td>
            <td class="auto-style35"></td>
            <td class="auto-style36">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/MENUPRINCIPAL.aspx">REGRESAR</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style30"></td>
            <td class="auto-style31">
                <table class="auto-style3" style="background-color: #808080; border-style: none; font-family: Arial; font-weight: bolder;">
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style28">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style14">ID APARTAMENTO :</td>
                        <td class="auto-style9">
                            <asp:TextBox ID="TXTCODIGO" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style22">
                            <asp:Button ID="BTNVALIDAR" runat="server" Text="VALIDAR" Width="97px" />
                        </td>
                        <td class="auto-style28">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style18">NUMERO:</td>
                        <td class="auto-style19">
                            <asp:TextBox ID="TXTNUMERO" runat="server" ReadOnly="True" Width="50px"></asp:TextBox>
                        </td>
                        <td class="auto-style20"></td>
                        <td class="auto-style21"></td>
                    </tr>
                    <tr>
                        <td class="auto-style18">PISO:</td>
                        <td class="auto-style19">
                            <asp:TextBox ID="TXTPISO" runat="server" ReadOnly="True" Width="47px"></asp:TextBox>
                        </td>
                        <td class="auto-style20">ESTADO:</td>
                        <td class="auto-style21">
                            <asp:DropDownList ID="LTESTADO" runat="server">
                                <asp:ListItem>DISPONIBLE</asp:ListItem>
                                <asp:ListItem>RESERVADO</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">PRECIO:</td>
                        <td class="auto-style7" colspan="3">
                            <asp:TextBox ID="TXTPRECIO" runat="server" Width="48px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">TIPO DE APARTAMENTO:</td>
                        <td class="auto-style10">
                            <asp:TextBox ID="TXTTIPO" runat="server" Width="48px"></asp:TextBox>
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                        <td class="auto-style29">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style7"></td>
                        <td class="auto-style29"></td>
                    </tr>
                    <tr>
                        <td class="auto-style27"></td>
                        <td class="auto-style10"></td>
                        <td class="auto-style22" colspan="2" rowspan="2">
                            <table class="auto-style23">
                                <tr>
                                    <td class="auto-style33" style="border-style: inherit">
                                        <asp:ImageButton ID="BTNGUARDAR" runat="server" Enabled="False" Height="90px" ImageUrl="~/IMG/ELIMINAR 3.png" Width="90px" />
                                    </td>
                                    <td class="auto-style33" style="border-style: inherit">
                                        <asp:ImageButton ID="BTNCANCELAR" runat="server" Enabled="False" Height="70px" ImageUrl="~/IMG/CANCELAR1.png" TabIndex="90" Width="100px" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style27"></td>
                        <td class="auto-style10"></td>
                    </tr>
                </table>
            </td>
            <td class="auto-style32"></td>
        </tr>
        <tr>
            <td class="auto-style24">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HOTEL %>" ProviderName="<%$ ConnectionStrings:HOTEL.ProviderName %>" SelectCommand="SELECT * FROM [apartamento] WHERE ([id_apartamento] = ?)" DeleteCommand="DELETE FROM HABITACION
WHERE ID_HABITACION=@ID">
                    <DeleteParameters>
                        <asp:ControlParameter ControlID="TXTCODIGO" Name="@ID" PropertyName="Text" />
                    </DeleteParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TXTCODIGO" Name="id_apartamento" PropertyName="Text" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td class="auto-style25"></td>
            <td class="auto-style7"></td>
        </tr>
    </table>
</asp:Content>
