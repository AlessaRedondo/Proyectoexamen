<%@ Page Title="LOGIN" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="LOGIN.aspx.vb" Inherits="WEBEMPRESARIAL.LOGIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 484px;
        }
        .auto-style6 {
            height: 23px;
            width: 484px;
        }
        .auto-style7 {
            height: 23px;
            text-align: right;
            font-family: ARIA;
            font-weight: bold;
        }
        .auto-style8 {
            text-align: right;
            font-family: ARIA;
            font-weight: bold;
        }
        .auto-style9 {
            width: 108px;
        }
        .auto-style10 {
            height: 23px;
            width: 108px;
        }
        .auto-style11 {
            width: 112px;
        }
        .auto-style12 {
            height: 23px;
            width: 112px;
        }
        .auto-style13 {
            width: 76px;
        }
        .auto-style14 {
            height: 23px;
            width: 76px;
        }
        .auto-style15 {
            text-align: center;
        }
        .auto-style16 {
            width: 424px;
        }
        .auto-style17 {
            height: 23px;
            width: 424px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style6"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style5">
                <table class="auto-style3" style="background-image: url('IMG/fondo2.jpg'); background-repeat: no-repeat; border-style: double; border-width: medium">
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style13">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style13">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style10"></td>
                        <td class="auto-style4"></td>
                        <td class="auto-style12"></td>
                        <td class="auto-style14"></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style13">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9"><b></b></td>
                        <td class="auto-style8">USUARIO:</td>
                        <td class="auto-style11">
                            <asp:TextBox ID="TXTUSUARIO" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style13">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style10"></td>
                        <td class="auto-style7">CONTRASEÑA:</td>
                        <td class="auto-style12">
                            <asp:TextBox ID="TXTCONTRASEÑA" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td class="auto-style14"></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style11">&nbsp;</td>
                        <td class="auto-style13">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style15" colspan="2" rowspan="2">
                            <asp:ImageButton ID="IBMLOGIN" runat="server" Height="90px" ImageUrl="~/IMG/ENTRAR.png" TabIndex="90" Width="90px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td></td>
                        <td class="auto-style11"></td>
                        <td class="auto-style13"></td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HOTEL %>" ProviderName="<%$ ConnectionStrings:HOTEL.ProviderName %>" SelectCommand="SELECT [nombre_empleado], [USUARIO], [CONTRASEÑA], [CUENTA] FROM [empleado] WHERE ([USUARIO] = ?)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TXTUSUARIO" Name="USUARIO" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style4"></td>
        </tr>
    </table>
</asp:Content>
