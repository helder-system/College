using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO.Modulos.Materia;

namespace DAL
{
    public class MateriaDAO:Modulos.Generico.DBConnection<MateriaDTO>
    {

         public override void inserir(MateriaDTO objDTO)
        { 
            //Método não implementado
            abrirConexao();

            fecharConexao();

        }

        public override void remover(MateriaDTO objDTO)
        {
            //Método não implementado
            //A IMPLEMENTAR UM CÓDIGO PARA REMOVER UM LOGIN NO SISTEMA
        }

        public override void atualizar(MateriaDTO objDTO)
        {
            //Método não implementado
            //A IMPLEMENTAR UM CÓDIGO PARA ATUALIZAR UM LOGIN NO SISTEMA
        }

        public override List<MateriaDTO> consultar(MateriaDTO objDTO)
        {

            //Abrir conexão
            abrirConexao();

            //Parâmetros de comando
            SqlCommand objComandoSQL = new SqlCommand();
            objComandoSQL.Connection = obterConexao();

            objComandoSQL.CommandType = CommandType.Text;
            string strComando;
            strComando = "SELECT idMateria, descricaoMateria FROM desenvolvimentoweb.dbo.materia ";
            if (objDTO != null)
            {
                strComando = strComando + " WHERE idMateria = " + objDTO.idMateria;
            }
            strComando = strComando + " ORDER BY descricaoMateria ";
            objComandoSQL.CommandText = strComando;

            SqlDataReader objLeitorConsulta = objComandoSQL.ExecuteReader();

            List<MateriaDTO> listaRetorno;

            if (objLeitorConsulta.HasRows)
            {
                listaRetorno = new List<MateriaDTO>();
                MateriaDTO objLinhaRegistroDTO;

                //Fazer o loop nos resultados da consulta
                while (objLeitorConsulta.Read())
                {
                    objLinhaRegistroDTO = new MateriaDTO();
                    objLinhaRegistroDTO.idMateria = int.Parse(objLeitorConsulta["idMateria"].ToString());
                    objLinhaRegistroDTO.descricaoMateria = objLeitorConsulta["descricaoMateria"].ToString();
                    
                    listaRetorno.Add(objLinhaRegistroDTO);

                }
                //Console.WriteLine(objLeitorConsulta["usuario"]);
                //Console.WriteLine(objLeitorConsulta["senha"]);
                //retorno = true;
            }
            else
            {
                //Retornar vazio
                listaRetorno = null;
            }

            //Fechar conexão
            fecharConexao();

            return listaRetorno;
        }
        
        public List<AlunoDTO> consultarAlunosporMateria(MateriaDTO objDTO)
        {

            //Abrir conexão
            abrirConexao();

            //Parâmetros de comando
            SqlCommand objComandoSQL = new SqlCommand();
            objComandoSQL.Connection = obterConexao();

            objComandoSQL.CommandType = CommandType.Text;
            string strComando;
            strComando = "SELECT Aluno.idAluno, Aluno.nomeAluno, AlunoMateria.semestre FROM ";
            strComando = strComando + "Aluno INNER JOIN AlunoMateria ON Aluno.idAluno = AlunoMateria.idAluno ";
            //strComando = strComando + "WHERE AlunoMateria.idMateria = ";
            
            if (objDTO != null)
            {
                strComando = strComando + "WHERE AlunoMateria.idMateria = " + objDTO.idMateria;                
            }
            strComando = strComando + " ORDER BY Aluno.nomeAluno ";
            objComandoSQL.CommandText = strComando;

            SqlDataReader objLeitorConsulta = objComandoSQL.ExecuteReader();

            List<AlunoDTO> listaRetorno;

            if (objLeitorConsulta.HasRows)
            {
                listaRetorno = new List<AlunoDTO>();
                AlunoDTO objLinhaRegistroDTO;

                //Fazer o loop nos resultados da consulta
                while (objLeitorConsulta.Read())
                {
                    objLinhaRegistroDTO = new AlunoDTO();
                    objLinhaRegistroDTO.idAluno = int.Parse(objLeitorConsulta["idAluno"].ToString());
                    objLinhaRegistroDTO.nomeAluno = objLeitorConsulta["nomeAluno"].ToString();
                    objLinhaRegistroDTO.semestre = objLeitorConsulta["semestre"].ToString();
                    
                    listaRetorno.Add(objLinhaRegistroDTO);

                }
                //Console.WriteLine(objLeitorConsulta["usuario"]);
                //Console.WriteLine(objLeitorConsulta["senha"]);
                //retorno = true;
            }
            else
            {
                //Retornar vazio
                listaRetorno = null;
            }

            //Fechar conexão
            fecharConexao();

            return listaRetorno;
        }
    }
}
