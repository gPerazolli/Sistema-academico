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
    public class clsDisciplinasDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;

        public int obterNumeroDisciplinasSigla(String parSigla)
        {
            int i = 0;

            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "select count(dis_sigla) num from tbl_disciplinas" +
                                        " where dis_sigla = @dis_sigla;";
                _comandos.Parameters.AddWithValue("@dis_sigla", parSigla);

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
                _comandos.CommandText = "select (max(dis_id) + 1) from tbl_disciplinas";

                novoId = Int32.Parse(_comandos.ExecuteScalar().ToString());

                _conexao.Close();

                return novoId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Inserir(clsDisciplinas parDisciplinas)
        {
            Int32 id;

            try
            {
                id = GetNovoId();

                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "insert into tbl_disciplinas(dis_id, dis_nome, dis_sigla, dis_observacoes)" +
                                        "values (@dis_id, @dis_nome, @dis_sigla, @dis_observacoes)";
                _comandos.Parameters.Add("@dis_id", SqlDbType.Int).Value = id;
                _comandos.Parameters.Add("@dis_nome", SqlDbType.VarChar).Value = parDisciplinas.Dis_nome;
                _comandos.Parameters.Add("@dis_sigla", SqlDbType.VarChar).Value = parDisciplinas.Dis_sigla;
                _comandos.Parameters.Add("@dis_observacoes", SqlDbType.VarChar).Value = parDisciplinas.Dis_observacoes;

                _comandos.ExecuteNonQuery();

                _conexao.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsDisciplinas parDisciplinas)
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "update tbl_disciplinas " +
                                        " set dis_nome = @dis_nome, " +
                                        "  dis_sigla = @dis_sigla, " +
                                        "  dis_observacoes = @dis_observacoes " +
                                        " where dis_id = @dis_id;";
                _comandos.Parameters.Add("@dis_id", SqlDbType.VarChar).Value = parDisciplinas.Dis_id;
                _comandos.Parameters.Add("@dis_nome", SqlDbType.VarChar).Value = parDisciplinas.Dis_nome;
                _comandos.Parameters.Add("@dis_sigla", SqlDbType.VarChar).Value = parDisciplinas.Dis_sigla;
                _comandos.Parameters.Add("@dis_observacoes", SqlDbType.VarChar).Value = parDisciplinas.Dis_observacoes;

                _comandos.ExecuteNonQuery();

                _conexao.Close();
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message); 
            }
        }

        public void Excluir(int parIdDisciplinas)
        {
            try
            {
                _conexao = clsConnection.obterConexao();

                _comandos = new SqlCommand();
                _comandos.Connection = _conexao;
                _comandos.CommandText = "delete from tbl_disciplinas " +
                                        " where dis_id = @dis_id;";
                _comandos.Parameters.Add("@dis_id", SqlDbType.VarChar).Value = parIdDisciplinas;

                _comandos.ExecuteNonQuery();

                _conexao.Close();
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
                _comandos.CommandText = "select dis_id, dis_nome, dis_sigla, dis_observacoes" +
                                        " from tbl_disciplinas " +
                                        " order by dis_nome asc;";

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
