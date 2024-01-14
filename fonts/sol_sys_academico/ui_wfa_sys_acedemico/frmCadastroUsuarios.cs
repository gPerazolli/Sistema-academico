using cl_dal;
using cl_models;
using cl_bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace ui_wfa_sys_acedemico
{
    public partial class frmCadastroUsuarios : Form
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        clsUsuariosBll usuariosBll = new clsUsuariosBll();
        clsUsuarios usuarios = new clsUsuarios();

        private void LimparCampos()
        {
            tbNome.Text = "";
            tbLogin.Text = "";
            tbSenha.Text = "";
            tbConfirmarSenha.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;

            if (tbLogin.Text != "" && tbSenha.Text == tbConfirmarSenha.Text)
            {
                usuarios.Nome_usu = tbNome.Text;
                usuarios.Login_usu = tbLogin.Text;
                usuarios.Senha_usu = tbSenha.Text;

                usuariosBll.Inserir(usuarios);

                MessageBox.Show("Dados Inseridos com Sucesso!");
                LimparCampos();
            }
            else if (tbSenha.Text != tbConfirmarSenha.Text)
            {
                MessageBox.Show("Senha Inválida!");

                tbSenha.Text = "";
                tbConfirmarSenha.Text = "";

                tbSenha.Focus();
            }
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmUsuariosPesquisa usuariosPesquisa = new frmUsuariosPesquisa();

            if (usuariosPesquisa.ShowDialog() == DialogResult.OK)
            {
                tbNome.Text = usuariosPesquisa.usuario.Nome_usu.ToString();
                tbLogin.Text = usuariosPesquisa.usuario.Login_usu.ToString();
                tbSenha.Text = usuariosPesquisa.usuario.Senha_usu.ToString();
                tbConfirmarSenha.Text = usuariosPesquisa.usuario.Senha_usu.ToString();
            }

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                usuarios.Login_usu = tbLogin.Text;
                usuariosBll.Excluir(usuarios.Login_usu);

                MessageBox.Show("Dados Excluidos com Sucesso!");
            }
            LimparCampos();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            LimparCampos();
            tbNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            usuarios.Nome_usu = tbNome.Text;
            usuarios.Login_usu = tbLogin.Text;
            usuarios.Senha_usu = tbSenha.Text;

            usuariosBll.Atualizar(usuarios);

            MessageBox.Show("Dados Atualizados com Sucesso!");
            LimparCampos();

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;
        }
    }
}
