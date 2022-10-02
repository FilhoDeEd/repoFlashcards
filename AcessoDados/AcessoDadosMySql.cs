using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AcessoDados
{
    public static class AcessoDadosMySql
    {
        private static MySqlConnection Conexao;

        private static MySqlConnection CriarConexao()
        {
            Conexao = new MySqlConnection(@"Server=127.0.0.1;Port=5432;Database=ifsp;User Id=postgres;Password=1234;");
            Conexao.Open();
            return Conexao;
        }

        public static void FecharConexao()
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
                objComando.CommandType = objTipo;
                objComando.CommandText = strSql;
                objComando.CommandTimeout = 999999999;

                foreach (MySqlParameter objParametro in objParametros)
                    objComando.Parameters.Add(new MySqlParameter(objParametro.ParameterName, objParametro.Value));

                return objComando.ExecuteScalar();
            }
            catch (Exception ex)
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
                objComando.CommandType = objTipo;
                objComando.CommandText = strSql;
                objComando.CommandTimeout = 999999999;

                foreach (MySqlParameter objParametro in objParametros)
                    objComando.Parameters.Add(new MySqlParameter(objParametro.ParameterName, objParametro.Value));

                MySqlDataAdapter objAdaptador = new MySqlDataAdapter(objComando);
                DataTable objTabelaRecebeDados = new DataTable();

                objAdaptador.Fill(objTabelaRecebeDados);

                return objTabelaRecebeDados;
            }
            catch (Exception objErro)
            {
                throw new Exception(objErro.Message);
            }

        }
    }
}
