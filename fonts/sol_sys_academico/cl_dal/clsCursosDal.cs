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
    public  class clsCursosDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public int obterNumeroCursosSigla(String parSigla)
        {
            int i = 0;
            
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select count(cur_sigla) num from tbl_cursos" +
                                        " where cur_sigla = @cur_sigla;";
                _comandos.Parameters.AddWithValue("@cur_sigla", parSigla);

                i = Convert.ToInt32(_comandos.ExecuteScalar());

                return i;
            }
            catch (Exception ex)
            {
                return -1;
                throw new Exception(ex.Message);
            }
        }

        public Int32 GetNovoId()
        {
            Int32 novoId = 1;

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select (max(cur_id) + 1) from tbl_cursos";

                novoId = Int32.Parse(_comandos.ExecuteScalar().ToString());

                _conexao.Close();

                return novoId;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Inserir(clsCursos parCursos)
        {
            Int32 id;
            id = GetNovoId();

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "insert into tbl_cursos(cur_id, cur_nome, cur_sigla, cur_observacoes)" +
                                        "values (@cur_id, @cur_nome, @cur_sigla, @cur_observacoes)";
                _comandos.Parameters.Add("@cur_id", SqlDbType.Int).Value = id;
                _comandos.Parameters.Add("@cur_nome", SqlDbType.VarChar).Value = parCursos.Cur_nome;
                _comandos.Parameters.Add("@cur_sigla", SqlDbType.VarChar).Value = parCursos.Cur_sigla;
                _comandos.Parameters.Add("@cur_observacoes", SqlDbType.VarChar).Value = parCursos.Cur_observacoes;

                _comandos.ExecuteNonQuery();

                _conexao.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsCursos parCursos)
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "update tbl_cursos " +
                                        " set cur_nome = @cur_nome, " +
                                        "  cur_sigla = @cur_sigla, " +
                                        "  cur_observacoes = @cur_observacoes " +
                                        " where cur_id = @cur_id;";
                _comandos.Parameters.Add("@cur_id", SqlDbType.Int).Value = parCursos.Cur_id;
                _comandos.Parameters.Add("@cur_nome", SqlDbType.VarChar).Value = parCursos.Cur_nome;
                _comandos.Parameters.Add("@cur_sigla", SqlDbType.VarChar).Value = parCursos.Cur_sigla;
                _comandos.Parameters.Add("@cur_observacoes", SqlDbType.VarChar).Value = parCursos.Cur_observacoes;

                _comandos.ExecuteNonQuery();

                _conexao.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int parIdCursos)
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "delete from tbl_cursos " +
                                        " where cur_id = @cur_id;";
                _comandos.Parameters.Add("@cur_id", SqlDbType.Int).Value = parIdCursos;

                _comandos.ExecuteNonQuery();

                _conexao.Close();
            }
            catch (Exception ex)
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
                _comandos.CommandText = "select cur_id, cur_nome, cur_sigla, cur_observacoes" +
                                        " from tbl_cursos " +
                                        " order by cur_nome asc";

                _tabela = new DataTable();

                _adaptador = new SqlDataAdapter(_comandos);
                _adaptador.Fill(_tabela);

                return _tabela;
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

    }
}
