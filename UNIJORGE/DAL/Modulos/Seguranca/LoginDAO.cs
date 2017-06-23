using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Modulos.Seguranca;

using System.Data;
using System.Data.SqlClient;

namespace DAL.Modulos.Seguranca
{
    public class LoginDAO:Modulos.Generico.DBConnection<LoginDTO>
    {
        //String strConexao = "Data Source=LABCOMIV0449;Initial Catalog=desenvolvimentoweb;User ID=sa;Password=sql1433";
        
        public Boolean realizarLogin(LoginDTO objLoginDTO)
        {
            //Associando e abrindo a conexão
            //SqlConnection objConexao = new SqlConnection(strConexao);
            //objConexao.Open();
            abrirConexao();

            //EXECUTAR O CÓDIGO
            SqlCommand objComandoSQL = new SqlCommand();
            objComandoSQL.Connection = obterConexao();

            objComandoSQL.CommandType = CommandType.Text;
            string strComando = "SELECT * FROM desenvolvimentoweb.dbo.usuario AS U ";	
            strComando = strComando + "WHERE u.usuario = '" + objLoginDTO.NomeUsuario + "' ";
            strComando = strComando + "and u.senha = '" + objLoginDTO.SenhaUsuario + "'";
            objComandoSQL.CommandText = strComando;

            SqlDataReader objLeitorConsulta = objComandoSQL.ExecuteReader();
            Boolean retorno;
            if (objLeitorConsulta.HasRows)
            {
                objLeitorConsulta.Read();
                Console.WriteLine(objLeitorConsulta["usuario"]);
                Console.WriteLine(objLeitorConsulta["senha"]);
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            //Fechar a conexão
            //objConexao.Close();
            fecharConexao();

            //Não está implementado o acesso a base
            //Será chamado para validar login/senha pelo banco
            return retorno;            
        }

        public override void inserir(LoginDTO objLoginDTO)
        { 
            //Método não implementado
            abrirConexao();

            SqlCommand objComandoSQL = new SqlCommand();
            objComandoSQL.Connection = obterConexao();

            objComandoSQL.CommandType = CommandType.Text;
            string strComando = "INSERT INTO desenvolvimentoweb.dbo.usuario (usuario, senha) VALUES ";
            strComando = strComando + "('" + objLoginDTO.NomeUsuario + "', '" + objLoginDTO.SenhaUsuario + "')";
            
            objComandoSQL.CommandText = strComando;

            objComandoSQL.ExecuteNonQuery();

            fecharConexao();

        }

        public override void remover(LoginDTO objDTO)
        {
            //Método não implementado
            //A IMPLEMENTAR UM CÓDIGO PARA REMOVER UM LOGIN NO SISTEMA
        }

        public override void atualizar(LoginDTO objDTO)
        {
            //Método não implementado
            //A IMPLEMENTAR UM CÓDIGO PARA ATUALIZAR UM LOGIN NO SISTEMA
        }

        public override List<LoginDTO> consultar(LoginDTO objDTO)
        {
            //Abrir conexão
            abrirConexao();

            //Parâmetros de comando
            SqlCommand objComandoSQL = new SqlCommand();
            objComandoSQL.Connection = obterConexao();

            objComandoSQL.CommandType = CommandType.Text;
            string strComando = "SELECT id, usuario, senha FROM desenvolvimentoweb.dbo.usuario U ORDER BY U.usuario ";
            objComandoSQL.CommandText = strComando;

            SqlDataReader objLeitorConsulta = objComandoSQL.ExecuteReader();

            List<LoginDTO> listaRetorno;

            if (objLeitorConsulta.HasRows)
            {
                listaRetorno = new List<LoginDTO>();
                LoginDTO objLinhaRegistroLoginDTO;

                //Fazer o loop nos resultados da consulta
                while (objLeitorConsulta.Read())
                {
                    objLinhaRegistroLoginDTO = new LoginDTO();
                    objLinhaRegistroLoginDTO.id = int.Parse(objLeitorConsulta["id"].ToString());
                    objLinhaRegistroLoginDTO.NomeUsuario = objLeitorConsulta["usuario"].ToString();
                    objLinhaRegistroLoginDTO.SenhaUsuario = objLeitorConsulta["senha"].ToString();

                    listaRetorno.Add(objLinhaRegistroLoginDTO);

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
