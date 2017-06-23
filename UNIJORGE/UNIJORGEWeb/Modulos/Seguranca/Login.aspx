<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UNIJORGEWeb.Modulos.Seguranca.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 202px;
        }
        .auto-style2 {
            width: 88px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNomeUsuario" runat="server" Text="Usuário"></asp:Label>
                    :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtNomeUsuario" runat="server" Width="152px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                </td>
                <td class="auto-style1">

                    <asp:TextBox ID="txtSenha" runat="server" Width="152px" TextMode="Password" ></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnConfirmar" runat="server" OnClick="btnConfirmar_Click" Text="Confirmar" />
        <br />
        <br />
        
    
    </div>
    </form>
</body>
</html>
