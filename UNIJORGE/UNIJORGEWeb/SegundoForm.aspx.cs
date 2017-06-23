using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNIJORGEWeb
{
    public partial class SegundoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.QueryString);
            Response.Write("<br/>");
            Response.Write("Usuário: " + Session["usuario"] + "<br/>");
            Response.Write("NomeSistema: " + Request.Params["nomeSistema"] + "<br/>");
            Response.Write("Permissão: " + Request.Params["permissao"] + "<br/>");
            TextBox1.Text = "Usuário: " + Session["usuario"];
        }
    }
}