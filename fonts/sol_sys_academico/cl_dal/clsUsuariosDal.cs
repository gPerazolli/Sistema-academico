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
    public class clsUsuariosDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adaptador;
        private SqlDataReader _leitor;
        private DataTable _tabela;


        public void Inserir(clsUsuarios parLogin)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "insert into tbl_login (nome_usu, login_usu, senha_usu)" +
                                    "values (@nome_usu, @login_usu, @senha_usu);";
            _comandos.Parameters.Add("@nome_usu", SqlDbType.VarChar).Value = parLogin.Nome_usu;
            _comandos.Parameters.Add("@login_usu", SqlDbType.VarChar).Value = parLogin.Login_usu;
            _comandos.Parameters.Add("@senha_usu", SqlDbType.VarChar).Value = parLogin.Senha_usu;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public void Atualizar(clsUsuarios parLogin)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "update tbl_login" +
                                    " set nome_usu = @nome_usu," +
                                    " senha_usu = @senha_usu" +
                                    " where login_usu = @login_usu;";
            _comandos.Parameters.Add("@nome_usu", SqlDbType.VarChar).Value = parLogin.Nome_usu;
            _comandos.Parameters.Add("@login_usu", SqlDbType.VarChar).Value = parLogin.Login_usu;
            _comandos.Parameters.Add("@senha_usu", SqlDbType.VarChar).Value = parLogin.Senha_usu;

            _comandos.ExecuteNonQuery();

            _conexao.Close();
        }

        public void Excluir(string parLogin)
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "delete from tbl_login " +
                                    " where login_usu = @login_usu;";
            _comandos.Parameters.Add("@login_usu", SqlDbType.VarChar).Value = parLogin;

            _comandos.ExecuteNonQuery();

            clsConnection.fecharConexao();
        }

        public DataTable ListarTodos()
        {
            _conexao = clsConnection.obterConexao();

            _comandos = new SqlCommand();
            _comandos.Connection = _conexao;
            _comandos.CommandText = "select nome_usu, login_usu, senha_usu" +
                                    " from tbl_login" +
                                    " order by nome_usu asc;";

            _tabela = new DataTable();

            _adaptador = new SqlDataAdapter(_comandos);
            _adaptador.Fill(_tabela);

            return _tabela;
        }
    }
}
