using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DTO;
using BLL.Modulos.Seguranca;

namespace UNIJORGEWeb
{
    public partial class MainWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Executar código para iniciar a página  
                Session["usuario"] = "";
                LoginBLL objLoginBLL = new LoginBLL();
                List<DTO.Modulos.Seguranca.LoginDTO> listaLogin = objLoginBLL.obterTodos();

                cmbListaUsuarios.DataSource = listaLogin;
                cmbListaUsuarios.DataTextField = "nomeUsuario";
                cmbListaUsuarios.DataValueField = "id";

                cmbListaUsuarios.DataBind();

             }
            else
            { 
                //Executar código de página carregada
                Session["usuario"] = txtNomeUsuario.Text;

            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*string strQuery;
            strQuery = "nomeSistema=" + txtNomeSistema.Text;
            strQuery = strQuery + "&permissao=" + DropDownList1.Items[DropDownList1.SelectedIndex].Value.ToString();
            Response.Redirect("SegundoForm.aspx?" + strQuery);
            */
        }

        protected void btnOutro_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("www.unijorge.edu.br");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DTO.Modulos.Seguranca.LoginDTO objLoginDTO = new DTO.Modulos.Seguranca.LoginDTO();
            objLoginDTO.NomeUsuario = txtNomeUsuario.Text;
            objLoginDTO.SenhaUsuario = txtSenha.Text;

            LoginBLL objLoginBLL = new LoginBLL();
            objLoginBLL.inserir(objLoginDTO);

           
        }
    }
}