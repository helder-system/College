using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO.Modulos.Materia;
using DAL;

namespace BLL.Modulos.Materia
{
    public class MateriaBLL
    {

        public List<MateriaDTO> obterTodos()
        {
            MateriaDAO objMateriaDAO = new MateriaDAO();

            return objMateriaDAO.consultar(null);
        }

        public List<AlunoDTO> obterAlunosPorMateria(MateriaDTO objMateriaDTO)
        { 
            MateriaDAO objMateriaDAO = new MateriaDAO();

            return objMateriaDAO.consultarAlunosporMateria(objMateriaDTO);
        }
    }
}
