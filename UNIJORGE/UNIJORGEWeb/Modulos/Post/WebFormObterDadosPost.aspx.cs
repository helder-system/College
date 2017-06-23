using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UNIJORGEWeb.Modulos.Post
{
    public partial class WebFormObterDadosPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           


            Response.Write(Request.Form["txtNomeProfessor"].ToString());
            Response.Write(Request.Form["txtMateria"].ToString());
        }
    }
}