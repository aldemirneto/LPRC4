using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class AcessoDadosMySQL
    {
        
        private static MySqlConnection Conexao;

        private static MySqlConnection CriarConexao()
        {
            Conexao = new MySqlConnection(@"Server=localhost;Database=LPRC4;User id=LPRC4; password=4leluia!;");
            Conexao.Open();
            return Conexao;
        }

        private static void FecharConexao()
        {
            if (Conexao != null)
            {
                Conexao.Close();
                Conexao = null;
            }
        }

        private static MySqlParameterCollection objParametros = new MySqlCommand().Parameters;

         
        public static void LimparParametros()
        {
            objParametros.Clear();
        }

        public static void AdicionarParametros(string strNomeParametro, object objValor)
        {
            objParametros.Add(new MySqlParameter(strNomeParametro, objValor));
        }

        public static object ExecutarManipulacao(CommandType objTipo, string strSql)
        {
            try
            {
                if (Conexao == null)
                    Conexao = CriarConexao();
                MySqlConnection objConexao = Conexao;
                MySqlCommand objComando = objConexao.CreateCommand();
                objComando.CommandText = strSql;   
                objComando.CommandType = objTipo;
                objComando.CommandTimeout = 999999999;
                foreach(MySqlParameter param in objComando.Parameters)
                    objComando.Parameters.Add(new MySqlParameter(param.ParameterName, param.Value));   
                return objComando.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static DataTable ExecutaConsultar(CommandType objTipo, string strSql)
        {
            try
            {
                if (Conexao == null)
                    Conexao = CriarConexao();
                MySqlConnection objConexao = Conexao;
                MySqlCommand objComando = objConexao.CreateCommand();
                objComando.CommandText = strSql;
                objComando.CommandType = objTipo;
                objComando.CommandTimeout = 999999999;
                foreach (MySqlParameter param in objComando.Parameters)
                    objComando.Parameters.Add(new MySqlParameter(param.ParameterName, param.Value));
                MySqlDataAdapter objAdaptador = new MySqlDataAdapter(objComando);
                DataTable objTabelaRecebeDados = new DataTable();
                objAdaptador.Fill(objTabelaRecebeDados);
                return objTabelaRecebeDados;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
