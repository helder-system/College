<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaAlunosMateria.aspx.cs" Inherits="UNIJORGEWeb.Modulos.Consulta.ConsultaAlunosMateria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table> 
            <tr>    
                <td>  <asp:Label ID="lblMateria" runat="server" Text="Matéria:"></asp:Label>  </td>
                <td class="auto-style2">  <asp:DropDownList ID="cmbListaMateria" runat="server" style="margin-left: 0px" Width="189px" ></asp:DropDownList> </td>
            </tr>            
        </table>
        <asp:Button ID="btnObterAlunos" runat="server" Text="Obter Alunos" OnClick="btnObterAlunos_Click" />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1"> <asp:Label ID="Label1" runat="server" Text="Alunos:"></asp:Label>  
                    <br />
                    <asp:GridView ID="tabelaAluno" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" Width="408px">
                        <Columns>
                            <asp:BoundField DataField="idAluno" HeaderText="ID" ReadOnly="True" />
                            <asp:BoundField DataField="nomeAluno" HeaderText="Nome do Aluno" ReadOnly="True" />
                            <asp:BoundField DataField="semestre" HeaderText="Semestre" ReadOnly="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>            
        </table>
    </div>
    </form>
</body>
</html>
