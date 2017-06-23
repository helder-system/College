using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Modulos.Seguranca;
using DTO.Modulos.Seguranca;

namespace UNIJORGEWeb.Modulos.Seguranca
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Armazenando as informações na camada de transferência
            LoginDTO objLoginDTO = new LoginDTO();
            objLoginDTO.NomeUsuario=txtNomeUsuario.Text;
            objLoginDTO.SenhaUsuario=txtSenha.Text;

            //Chamada da classe de negócio para realização de login
            LoginBLL objLoginBLL = new LoginBLL();

            if (objLoginBLL.realizarLogin(objLoginDTO))
            {
                //Verdadeira. 
                //1 - Armazenar o usuário
                //2 - Redirecionar para a página principal
                Response.Redirect("~/MainWebForm.aspx");
                Session["usuario"] = objLoginDTO;
            }
            else
            {
                //Parte falsa
                Response.Redirect("~/Modulos/Seguranca/Login.aspx");
            }

        }
    }
}