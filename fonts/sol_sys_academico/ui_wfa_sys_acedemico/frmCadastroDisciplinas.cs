using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;
using cl_models;
using System.Data.SqlClient;
using cl_bll;

namespace ui_wfa_sys_acedemico
{
    public partial class frmCadastroDisciplinas : Form
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;
        public frmCadastroDisciplinas()
        {
            InitializeComponent();
        }

        clsDisciplinasBll disciplinasBll = new clsDisciplinasBll();
        clsDisciplinas disciplinas = new clsDisciplinas();

        private void LimparCampos()
        {
            tbId.Text = "";
            tbNome.Text = "";
            tbSigla.Text = "";
            tbObs.Text = "";

        }

        private void CarregarGrid()
        {
            gridDisciplinas.DataSource = disciplinasBll.ListarTodos();
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
        }

        private void FormatarGrid()
        {
            gridDisciplinas.ReadOnly = true;
            gridDisciplinas.ScrollBars = ScrollBars.Both;
            gridDisciplinas.Columns[0].HeaderText = "ID";
            gridDisciplinas.Columns[1].HeaderText = "NOME";
            gridDisciplinas.Columns[2].HeaderText = "SIGLA";
            gridDisciplinas.Columns[3].HeaderText = "OBSERVAÇÕES";

            gridDisciplinas.Columns[0].Width = 50;
            gridDisciplinas.Columns[1].Width = 200;
            gridDisciplinas.Columns[2].Width = 60;
            gridDisciplinas.Columns[3].Width = 400;

        }

        private void AtualizarTela()
        {
            Int32 iCol;
            iCol = gridDisciplinas.CurrentRow.Index;

            tbId.Text = gridDisciplinas[0, iCol].Value.ToString();
            tbNome.Text = gridDisciplinas[1, iCol].Value.ToString();
            tbSigla.Text = gridDisciplinas[2, iCol].Value.ToString();
            tbObs.Text = gridDisciplinas[3, iCol].Value.ToString();

        }

        private void frmCadastroDisciplinas_Load(object sender, EventArgs e)
        {
            AtivarFormulario();

            tbNome.Enabled = false;
            tbSigla.Enabled = false;
            tbObs.Enabled = false;
        }

        private void gridDisciplinas_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTela();
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
            tbObs.Enabled = true;

            tbNome.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;

            if (tbId.Text == "")
            {
                disciplinas.Dis_nome = tbNome.Text;
                disciplinas.Dis_sigla = tbSigla.Text;
                disciplinas.Dis_observacoes = tbObs.Text;

                disciplinasBll.Inserir(disciplinas);

                MessageBox.Show("Dados Inseridos com Sucesso!");
            }
            else
            {
                disciplinas.Dis_id = Int32.Parse(tbId.Text);
                disciplinas.Dis_nome = tbNome.Text;
                disciplinas.Dis_sigla = tbSigla.Text;
                disciplinas.Dis_observacoes = tbObs.Text;

                disciplinasBll.Atualizar(disciplinas);

                MessageBox.Show("Dados Atualizados com Sucesso!");
            }

            CarregarGrid();
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
            tbObs.Enabled = false;

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
            tbObs.Enabled = true;

            tbNome.Focus();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                disciplinas.Dis_id = int.Parse(tbId.Text);

                disciplinasBll.Excluir(disciplinas.Dis_id);

                MessageBox.Show("Dados Excluidos com Sucesso!");

                CarregarGrid();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmDisciplinasPesquisa disciplinasPesquisa = new frmDisciplinasPesquisa();

            if (disciplinasPesquisa.ShowDialog() == DialogResult.OK)
            {
                tbId.Text = disciplinasPesquisa.disciplinas.Dis_id.ToString();
                tbNome.Text = disciplinasPesquisa.disciplinas.Dis_nome.ToString();
                tbSigla.Text = disciplinasPesquisa.disciplinas.Dis_sigla.ToString();
                tbObs.Text = disciplinasPesquisa.disciplinas.Dis_observacoes.ToString();
            }
        }
    }
}
