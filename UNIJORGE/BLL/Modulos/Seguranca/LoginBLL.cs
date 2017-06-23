using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Modulos.Seguranca;
using DAL.Modulos.Seguranca;

namespace BLL.Modulos.Seguranca
{
    public class LoginBLL
    {
        public Boolean realizarLogin(LoginDTO objLoginDTO)
        {
            if (objLoginDTO.NomeUsuario.ToString() == "" ||
                objLoginDTO.SenhaUsuario.ToString() == "")
            {
                return false;
            }
            else
            {
                LoginDAO objLoginDAO = new LoginDAO();
                return objLoginDAO.realizarLogin(objLoginDTO);
            }
        }

        public void inserir(LoginDTO objLoginDTO)
        {
            LoginDAO objLoginDAO = new LoginDAO();

            objLoginDAO.inserir(objLoginDTO);

        }

        public List<LoginDTO> obterTodos()
        {
            LoginDAO objLoginDAO = new LoginDAO();

            return objLoginDAO.consultar(null);

        }
    }
}
