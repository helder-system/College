<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="UNIJORGEWeb.Modulos.CadastroBasico.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="conteudoEsquerda" runat="server">
    <table>
        <tr>
            <td>Coluna1 Linha1 :</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>            
        </tr>
        <tr>
            <td>Coluna1 Linha2 :</td>
            <td> <asp:Button ID="Button1" runat="server" Text="Button" /> </td>
        </tr>
    </table>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudoCentro" runat="server">
</asp:Content>
