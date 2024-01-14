using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;

using System.Data.SqlClient;

namespace ui_wfa_sys_acedemico
{
    public partial class frmLogin : Form
    {
        Thread nt;
        public frmLogin()
        {
            InitializeComponent();
        }

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataReader _reader;

        public string nomeusuario = "";
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            string usuario, senha;

            string login = "select login_usu, senha_usu from tbl_login where login_usu='" + tbLogin.Text + "' and senha_usu='" + tbSenha.Text + "'";
            _comandos = new SqlCommand(login, _conexao);
            _comandos.CommandType = CommandType.Text;

            try
            {
                _conexao = clsConnection.obterConexao();
                _reader = _comandos.ExecuteReader();

                if (_reader.Read())
                {
                    usuario = _reader[0].ToString();
                    senha = _reader[1].ToString();

                    _conexao.Close();

                    if (usuario == tbLogin.Text && senha == tbSenha.Text)
                    {
                        nomeusuario = tbLogin.Text;

                        this.Close();
                        nt = new Thread(Logado);
                        nt.SetApartmentState(ApartmentState.STA);
                        nt.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Login e/ou senha invalidos");
                    tbLogin.Text = "";
                    tbSenha.Text = "";
                    tbLogin.Focus();
                    _conexao.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Logado()
        {
            Application.Run(new frmPrincipal(nomeusuario));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
