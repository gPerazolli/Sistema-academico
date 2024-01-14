using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using cl_models;


namespace cl_dal
{
    public class clsPeriodosDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public int obterNumeroPeriodosSigla(String parSigla)
        {
            int i = 0;

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select count(per_sigla) num from tbl_periodos" +
                                        " where per_sigla = @per_sigla;";
                _comandos.Parameters.AddWithValue("@per_sigla", parSigla);

                i = Convert.ToInt32(_comandos.ExecuteScalar());

                return i;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }

        public int GetNovoId()
        {
            Int32 novoId = 1;

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select (max(per_id) + 1) from tbl_periodos;";

                novoId = Int32.Parse(_comandos.ExecuteScalar().ToString());

                clsConnection.fecharConexao();
                return novoId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Inserir(clsPeriodos parPeriodos)
        {
            Int32 id = GetNovoId();

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "insert into tbl_periodos(per_id, per_nome, per_sigla)" +
                                        "values (@per_id, @per_nome, @per_sigla);";
                _comandos.Parameters.Add("@per_id", SqlDbType.Int).Value = id;
                _comandos.Parameters.Add("@per_nome", SqlDbType.VarChar).Value = parPeriodos.Per_nome;
                _comandos.Parameters.Add("@per_sigla", SqlDbType.VarChar).Value = parPeriodos.Per_sigla;

                _comandos.ExecuteNonQuery();

                clsConnection.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsPeriodos parPeriodos)
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "update tbl_periodos " +
                                        "  set per_nome = @per_nome, " +
                                        "  per_sigla = @per_sigla" +
                                        " where per_id = @per_id;";
                _comandos.Parameters.Add("@per_id", SqlDbType.Int).Value = parPeriodos.Per_id;
                _comandos.Parameters.Add("@per_nome", SqlDbType.VarChar).Value = parPeriodos.Per_nome;
                _comandos.Parameters.Add("@per_sigla", SqlDbType.VarChar).Value = parPeriodos.Per_sigla;

                _comandos.ExecuteNonQuery();

                clsConnection.fecharConexao();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int parIdPeriodo)
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "delete from tbl_periodos " +
                                        " where per_id = @per_id;";
                _comandos.Parameters.Add("@per_id", SqlDbType.Int).Value = parIdPeriodo;

                _comandos.ExecuteNonQuery();

                clsConnection.fecharConexao();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarTodos()
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select per_id, per_nome, per_sigla " +
                                        "from tbl_periodos " +
                                        "order by per_nome asc";

                _tabela = new DataTable();

                _adaptador = new SqlDataAdapter(_comandos);
                _adaptador.Fill(_tabela);

                return _tabela;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}