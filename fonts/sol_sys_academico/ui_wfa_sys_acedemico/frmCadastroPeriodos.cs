using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

using cl_dal;
using cl_models;
using System.Data.SqlClient;
using cl_bll;

namespace ui_wfa_sys_acedemico
{
    public partial class frmCadastroPeriodos : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmCadastroPeriodos()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            tbId.Text = "";
            tbNome.Text = "";
            tbSigla.Text = "";
        }

        clsPeriodosBll periodosBll = new clsPeriodosBll();
        clsPeriodos periodos = new clsPeriodos();

        private void CarregarGrid()
        {
            gridPeriodos.DataSource = periodosBll.ListarTodos();
        }

        private void AtivarFormulario()
        {
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;

            CarregarGrid();
            FormatarGrid();
            AtualizarTela();

            tbNome.Enabled = false;
            tbSigla.Enabled = false;
        }

        private void FormatarGrid()
        {
            gridPeriodos.ReadOnly = true;
            gridPeriodos.ScrollBars = ScrollBars.Both;
            gridPeriodos.Columns[0].HeaderText = "ID";
            gridPeriodos.Columns[1].HeaderText = "NOME";
            gridPeriodos.Columns[2].HeaderText = "SIGLA";

            gridPeriodos.Columns[0].Width = 50;
            gridPeriodos.Columns[1].Width = 370;
            gridPeriodos.Columns[2].Width = 60;
        }

        private void AtualizarTela()
        {
            Int32 iCol;
            iCol = gridPeriodos.CurrentRow.Index;

            tbId.Text = gridPeriodos[0, iCol].Value.ToString();
            tbNome.Text = gridPeriodos[1, iCol].Value.ToString();
            tbSigla.Text = gridPeriodos[2, iCol].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            LimparCampos();

            tbNome.Enabled = true;
            tbSigla.Enabled = true;

            tbNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;

            tbNome.Enabled = true;
            tbSigla.Enabled = true;

            tbNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;

            LimparCampos();
            CarregarGrid();
            AtualizarTela();

            tbNome.Enabled = false;
            tbSigla.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;

            try
            {
                if (tbId.Text == "")
                {

                    periodos.Per_nome = tbNome.Text;
                    periodos.Per_sigla = tbSigla.Text;

                    periodosBll.Inserir(periodos);

                    MessageBox.Show("Dados Inseridos com Sucesso!");
                }
                else
                {
                    periodos.Per_id = Convert.ToInt32(tbId.Text);
                    periodos.Per_nome = tbNome.Text;
                    periodos.Per_sigla = tbSigla.Text;

                    periodosBll.Atualizar(periodos);

                    MessageBox.Show("Dados Atualizados com Sucesso!");
                }
            }
            catch (FormatException ex)
            {
                throw new Exception(ex.Message);
            }


            clsConnection.fecharConexao();
            CarregarGrid();
        }

        private void gridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmCadastroCursos_Load(object sender, EventArgs e)
        {
            AtivarFormulario();
        }

        private void gridCursos_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                periodos.Per_id = int.Parse(tbId.Text);

                periodosBll.Excluir(periodos.Per_id);

                MessageBox.Show("Dados Excluidos com Sucesso!");

                CarregarGrid();
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPeriodosPesquisa periodosPesquisa = new frmPeriodosPesquisa();

            if (periodosPesquisa.ShowDialog() == DialogResult.OK)
            {
                tbId.Text = periodosPesquisa.periodos.Per_id.ToString();
                tbNome.Text = periodosPesquisa.periodos.Per_nome.ToString();
                tbSigla.Text = periodosPesquisa.periodos.Per_sigla.ToString();
            }
        }
    }
}
