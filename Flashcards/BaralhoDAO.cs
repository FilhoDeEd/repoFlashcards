using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    /*
    public class BaralhoDAO
    {
        public List<Baralho> List()
        {
            List<Baralho> lista = new List<Baralho>();
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select Id_Baralho, Nome from tblBaralhos";
                objDataTable = AcessoDadosPostgres.ExecutaConsultar(CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }

                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Baralho objNovaBaralho = new Baralho();
                    objNovaBaralho.IdBaralho = objLinha["Id_Baralho"] != DBNull.Value ? Convert.ToInt32(objLinha["Id_Baralho"]) : 0;
                    objNovaBaralho.Nome = objLinha["Nome"] != DBNull.Value ? Convert.ToString(objLinha["Nome"]) : "";

                    lista.Add(objNovaBanda);
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
                AcessoDadosPostgres.LimparParametros();

                object objRetorno = null;
                if (Baralho != null)
                {
                    AcessoDados.AcessoDadosMySql.AdicionarParametros("@intId_Baralho", baralho.Id_Baralho);
                    AcessoDados.AcessoDadosMySql.AdicionarParametros("@vchNome", baralho.Nome);

                    string strSQL = "insert into tblBaralho (Nome) values ( @vchNome); select CURRVAL('Id_Baralho_seq');";
                    objRetorno = AcessoDadosPostgres.ExecutarManipulacao(CommandType.Text, strSQL);
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

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        public bool Edit(Banda banda)
        {
            try
            {
                AcessoDadosPostgres.LimparParametros();

                object objRetorno = null;
                if (banda != null)
                {
                    AcessoDadosPostgres.AdicionarParametros("@intCod_banda", banda.Codigo);
                    AcessoDadosPostgres.AdicionarParametros("@vchDescricao_banda", banda.Descricao);

                    string strSQL = "update tblBanda set descricao_banda = @vchDescricao_banda where cod_banda = @intCod_banda; select @intCod_banda;";
                    objRetorno = AcessoDadosPostgres.ExecutarManipulacao(CommandType.Text, strSQL);
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

        public bool Delete(Banda banda)
        {
            try
            {
                AcessoDadosPostgres.LimparParametros();

                object objRetorno = null;
                if (banda != null)
                {
                    AcessoDadosPostgres.AdicionarParametros("@intCod_banda", banda.Codigo);

                    string strSQL = "delete from tblBanda where cod_banda = @intCod_banda; select @intCod_banda;";
                    objRetorno = AcessoDadosPostgres.ExecutarManipulacao(CommandType.Text, strSQL);
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
    */
}
