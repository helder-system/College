using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DAL.Modulos.Generico
{
    public abstract class DBConnection<objetoGenerico> where objetoGenerico: class
    {
        String strConexao = "Data Source=LABCOMIV0449;Initial Catalog=desenvolvimentoweb;User ID=sa;Password=sql1433";
        SqlConnection objConexao; 
            
        public DBConnection()
        {
            objConexao = new SqlConnection(strConexao);
        }

        public SqlConnection obterConexao()
        {
            return objConexao;
        }

        public void abrirConexao()
        {
            objConexao.Open();
        }

        public void fecharConexao()
        {
            objConexao.Close();
        }

        public abstract void inserir(objetoGenerico objDTO);

        public abstract void remover(objetoGenerico objDTO);

        public abstract void atualizar(objetoGenerico objDTO);

        public abstract List<objetoGenerico> consultar(objetoGenerico objDTO);

        
    }
}
