<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AGREGARUSUARIO.aspx.vb" Inherits="WEBEMPRESARIAL.AGREGARUSUARIO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 91%;
    }
    .auto-style5 {
        width: 99%;
    }
    .auto-style7 {
        height: 23px;
    }
    .auto-style9 {
        width: 152px;
    }
    .auto-style10 {
        height: 23px;
        width: 152px;
    }
    .auto-style14 {
        width: 293px;
        text-align: right;
    }
    .auto-style15 {
            width: 293px;
            height: 23px;
            text-align: right;
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
        .auto-style22 {
            text-align: center;
        }
        .auto-style23 {
            width: 100%;
        }
        .auto-style24 {
            width: 344px;
            height: 23px;
        }
        .auto-style25 {
            width: 723px;
            height: 23px;
        }
        .auto-style27 {
            width: 293px;
            height: 23px;
        }
        .auto-style28 {
            width: 306px;
        }
        .auto-style29 {
            width: 306px;
            height: 23px;
        }
        .auto-style30 {
            width: 344px;
            height: 392px;
        }
        .auto-style31 {
            width: 723px;
            height: 392px;
        }
        .auto-style32 {
            height: 392px;
        }
        .auto-style33 {
            height: 94px;
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
            <table class="auto-style3" style="background-color: #00FFCC; border-style: none; font-family: Arial; font-weight: bolder;">
                <tr>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">CODIGO DE EMPLEADO:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TXTCODIGO" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="BTNVALIDAR" runat="server" Text="VALIDAR" Width="97px" />
                    </td>
                    <td class="auto-style28">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">NOMBRE:</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="TXTNOMBRE" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style20"></td>
                    <td class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style18">TELEFONO:</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="TXTTELEFONO" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style20">CORREO:</td>
                    <td class="auto-style21">
                        <asp:TextBox ID="TXTCORREO" runat="server" ReadOnly="True" Width="145px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">DIRECCION:</td>
                    <td class="auto-style7" colspan="3">
                        <asp:TextBox ID="TXTDIRECCION" runat="server" ReadOnly="True" TextMode="MultiLine" Width="420px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">USUARIO:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TXTUSUARIO" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style7">CONTRASEÑA:</td>
                    <td class="auto-style29">
                        <asp:TextBox ID="TXTCONTRA" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">ACTIVO:</td>
                    <td class="auto-style10">
                        <asp:CheckBox ID="CHEACTIVO" runat="server" Enabled="False" />
                    </td>
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
                                    <asp:ImageButton ID="BTNGUARDAR" runat="server" Enabled="False" Height="90px" ImageUrl="~/IMG/GUARGAR.png" Width="90px" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HOTEL %>" InsertCommand="INSERT  INTO EMPLEADO  
VALUES 
(@ID,@NOMBRE,@TELE,@MAIL,@DIREC,@USER,@CONTRA,@CUENTA)" ProviderName="<%$ ConnectionStrings:HOTEL.ProviderName %>" SelectCommand="SELECT [id_empleado] FROM [empleado] WHERE ([id_empleado] = ?)">
                <InsertParameters>
                    <asp:ControlParameter ControlID="TXTCODIGO" Name="@ID" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TXTNOMBRE" Name="@NOMBRE" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TXTTELEFONO" Name="@TELE" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TXTCORREO" Name="@MAIL" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TXTDIRECCION" Name="@DIREC" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TXTUSUARIO" Name="@USER" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TXTCONTRA" Name="@CONTRA" PropertyName="Text" />
                    <asp:SessionParameter Name="@CUENTA" SessionField="ACTIVO" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="TXTCODIGO" Name="id_empleado" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </td>
        <td class="auto-style25"></td>
        <td class="auto-style7"></td>
    </tr>
</table>
</asp:Content>
