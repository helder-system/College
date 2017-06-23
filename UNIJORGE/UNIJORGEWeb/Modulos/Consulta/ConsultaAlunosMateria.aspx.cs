using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using DTO;

namespace UNIJORGEWeb.Modulos.Consulta
{
    public partial class ConsultaAlunosMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<DTO.Modulos.Materia.MateriaDTO> listaMateria = new List<DTO.Modulos.Materia.MateriaDTO>();
                BLL.Modulos.Materia.MateriaBLL objMateriaBLL = new BLL.Modulos.Materia.MateriaBLL();

                listaMateria = objMateriaBLL.obterTodos();
                cmbListaMateria.DataSource = listaMateria;
                cmbListaMateria.DataTextField = "descricaoMateria";
                cmbListaMateria.DataValueField = "idMateria";

                cmbListaMateria.DataBind();
            }
        }

        protected void btnObterAlunos_Click(object sender, EventArgs e)
        {

            DTO.Modulos.Materia.MateriaDTO objMateriaDTO = null;

            if (cmbListaMateria.SelectedIndex != -1)
            { 
                objMateriaDTO = new DTO.Modulos.Materia.MateriaDTO();
                objMateriaDTO.idMateria = int.Parse(cmbListaMateria.SelectedValue.ToString());
            }
            
            BLL.Modulos.Materia.MateriaBLL objMateriaBLL = new BLL.Modulos.Materia.MateriaBLL();
            List<DTO.Modulos.Materia.AlunoDTO> listaAlunos = new List<DTO.Modulos.Materia.AlunoDTO>();

            listaAlunos = objMateriaBLL.obterAlunosPorMateria(objMateriaDTO);

            this.tabelaAluno.DataSource = listaAlunos;
            

            tabelaAluno.DataBind();

        }
    }
}