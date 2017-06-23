<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMethodPost.aspx.cs" Inherits="UNIJORGEWeb.Modulos.Post.WebMethodPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="WebFormObterDadosPost.aspx">
    <div>
    
    </div>
        <asp:Label ID="lblNomeProfessor" runat="server" Text="Professor"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtNomeProfessor" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lblMateria" runat="server" Text="Matéria: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMateria" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviarPost" runat="server" Text="Enviar Post" />
        <br />
    </form>
</body>
</html>
