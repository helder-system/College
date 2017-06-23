using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Modulos.Seguranca
{
    public class LoginDTO
    {
        public int id { get; set; }
        private string nomeUsuario;
        private string senhaUsuario;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string SenhaUsuario
        {
            get { return senhaUsuario; }
            set { senhaUsuario = value; }
        }

    }
}
