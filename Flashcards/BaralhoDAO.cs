using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using Entidades;
using System.Data;

namespace Flashcards
{
    public class BaralhoDAO
    {
        public List<Baralho> List()
        {
            List<Baralho> lista = new List<Baralho>();
            try
            {
                DataTable? objDataTable = null;
                string strSQL = "select Id_Baralho, Nome from tblBaralhos";
                objDataTable = AcessoDadosMySql.ExecutaConsultar(CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }

                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Baralho objNovoBaralho = new Baralho();
                    objNovoBaralho.IdBaralho = objLinha["Id_Baralho"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Baralho"]) : 0;
                    objNovoBaralho.Nome = objLinha["Nome"] != DBNull.Value ? Convert.ToString(objLinha["Nome"]) : "";

                    lista.Add(objNovoBaralho);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public bool Create(Baralho baralho)
        {
            try
            {
                AcessoDadosMySql.LimparParametros();

                object? objRetorno = null;
                if (baralho != null)
                {
                    AcessoDados.AcessoDadosMySql.AdicionarParametros("@intIdBaralho", baralho.IdBaralho);
                    AcessoDados.AcessoDadosMySql.AdicionarParametros("@vchNome", baralho.Nome);

                    string strSQL = "insert into tblBaralho (Nome) values ( @vchNome); select CURRVAL('Id_Baralho_seq');";
                    objRetorno = AcessoDadosMySql.ExecutarManipulacao(CommandType.Text, strSQL);
                }

                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                        return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Baralho baralho)
        {
            try
            {
                AcessoDadosMySql.LimparParametros();

                object? objRetorno = null;
                if (baralho != null)
                {
                    AcessoDadosMySql.AdicionarParametros("@intIdBaralho", baralho.IdBaralho);
                    AcessoDadosMySql.AdicionarParametros("@vchNome", baralho.Nome);

                    string strSQL = "update tblBanda set descricao_banda = @vchDescricao_banda where cod_banda = @intCod_banda; select @intCod_banda;";
                    objRetorno = AcessoDadosMySql.ExecutarManipulacao(CommandType.Text, strSQL);
                }

                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                        return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Baralho baralho)
        {
            try
            {
                AcessoDadosMySql.LimparParametros();

                object? objRetorno = null;
                if (baralho != null)
                {
                    AcessoDadosMySql.AdicionarParametros("@intCod_banda", baralho.IdBaralho);

                    string strSQL = "delete from tblBanda where IdBaralho = @intIdBaralho; select @intIdBaralho;";
                    objRetorno = AcessoDadosMySql.ExecutarManipulacao(CommandType.Text, strSQL);
                }

                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                        return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
