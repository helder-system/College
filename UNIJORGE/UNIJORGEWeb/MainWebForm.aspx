<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWebForm.aspx.cs" Inherits="UNIJORGEWeb.MainWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Minha Primeira Aplicação WEB </title>
    <style type="text/css">
        .auto-style1 {
            width: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div style="height: 181px">
    
        <table> 

            <tr>
                <td class="auto-style1"> <asp:Label ID="lblNomeUsuario" runat="server" Text="Usuario:"></asp:Label> </td>
                <td> <asp:TextBox ID="txtNomeUsuario" runat="server" Width="190px"></asp:TextBox> </td>
            </tr>
            <tr>
                <td> <asp:Label ID="lblSenhaUsuario" runat="server" Text="Senha:"></asp:Label> </td>
                <td> <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox> </td>
            </tr>
            
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Inserir" />

        <br />

        <table>            
            <tr>
                <td> ListaUsuarios: </td>
                <td> <asp:DropDownList ID="cmbListaUsuarios" runat="server"></asp:DropDownList> </td>
            </tr>
        </table>
        
        
        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" Visible="true" ToolTip="Meu Botão" OnClick="btnConfirmar_Click" />
        
        <table> 
            <tr> </tr>
            <tr> </tr>
            <tr> </tr>
        </table>
        
    
    </div>
    </form>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="idEndereco" Visible="False" />
            <asp:BoundField DataField="endereco" HeaderText="Endereco" />
            <asp:BoundField DataField="cep" HeaderText="CEP" />
        </Columns>
    </asp:GridView>
    
</body>
</html>
