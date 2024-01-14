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
using cl_bll;
using System.Data.SqlClient;


namespace ui_wfa_sys_acedemico
{
    public partial class frmCadastroCursos : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmCadastroCursos()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbId.Text = "";
            tbNome.Text = "";
            tbSigla.Text = "";
            tbObs.Text = "";

        }

        clsCursosBll cursosBll = new clsCursosBll();
        clsCursos cursos = new clsCursos();

        private void CarregarGrid()
        {
            gridCursos.DataSource = cursosBll.ListarTodos();
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
            tbObs.Enabled = false;

        }

        private void FormatarGrid()
        {
            gridCursos.ReadOnly = true;
            gridCursos.ScrollBars = ScrollBars.Both;
            gridCursos.Columns[0].HeaderText = "ID";
            gridCursos.Columns[1].HeaderText = "NOME";
            gridCursos.Columns[2].HeaderText = "SIGLA";
            gridCursos.Columns[3].HeaderText = "OBSERVAÇÕES";

            gridCursos.Columns[0].Width = 50;
            gridCursos.Columns[1].Width = 200;
            gridCursos.Columns[2].Width = 60;
            gridCursos.Columns[3].Width = 400;
        }

        private void AtualizarTela()
        {
            Int32 iCol;
            iCol = gridCursos.CurrentRow.Index;

            tbId.Text = gridCursos[0, iCol].Value?.ToString();
            tbNome.Text = gridCursos[1, iCol].Value?.ToString();
            tbSigla.Text = gridCursos[2, iCol].Value?.ToString();
            tbObs.Text = gridCursos[3, iCol].Value?.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroCursos_Load(object sender, EventArgs e)
        {
            AtivarFormulario();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;


            if (tbId.Text.Trim() == "")
            {
                cursos.Cur_nome = tbNome.Text;
                cursos.Cur_sigla = tbSigla.Text;
                cursos.Cur_observacoes = tbObs.Text;

                cursosBll.Inserir(cursos);

                MessageBox.Show("Dados Inseridos com Sucesso!");
            }
            else
            {
                cursos.Cur_id = Int32.Parse(tbId.Text);
                cursos.Cur_nome = tbNome.Text;
                cursos.Cur_sigla = tbSigla.Text;
                cursos.Cur_observacoes = tbObs.Text;

                cursosBll.Atualizar(cursos);

                MessageBox.Show("Dados Atualizados com Sucesso!");
            }

            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cursos.Cur_id = int.Parse(tbId.Text);

                cursosBll.Excluir(cursos.Cur_id);

                MessageBox.Show("Dados Excluidos com Sucesso!");

                CarregarGrid();
            }
        }

        private void gridCursos_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmCursosPesquisa cursosPesquisa = new frmCursosPesquisa();

            if (cursosPesquisa.ShowDialog() == DialogResult.OK)
            {
                tbId.Text = cursosPesquisa.cursos.Cur_id.ToString();
                tbNome.Text = cursosPesquisa.cursos.Cur_nome.ToString();
                tbSigla.Text = cursosPesquisa.cursos.Cur_sigla.ToString();
                tbObs.Text = cursosPesquisa.cursos.Cur_observacoes.ToString();
            }
        }
    }
}
