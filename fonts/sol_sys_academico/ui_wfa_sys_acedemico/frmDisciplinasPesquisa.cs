using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;
using cl_models;
using cl_bll;

namespace ui_wfa_sys_acedemico
{
    public partial class frmDisciplinasPesquisa : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmDisciplinasPesquisa()
        {
            InitializeComponent();


        }

        public clsDisciplinas disciplinas;
        public clsDisciplinasBll disciplinasBll;

        public void CarregarGrid()
        {
            disciplinasBll = new clsDisciplinasBll();
            gridDisciplinas.DataSource = disciplinasBll.ListarTodos();
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

        public void SelecionarItem()
        {
            Int32 i = 0;

            disciplinasBll = new clsDisciplinasBll();
            disciplinas = new clsDisciplinas();

            i = gridDisciplinas.CurrentRow.Index;
            disciplinas.Dis_id = int.Parse(gridDisciplinas[0, i].Value.ToString());
            disciplinas.Dis_nome = gridDisciplinas[1, i].Value.ToString();
            disciplinas.Dis_sigla = gridDisciplinas[2, i].Value.ToString();
            disciplinas.Dis_observacoes = gridDisciplinas[3, i].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void Buscar()
        {
            _conexao = clsConnection.obterConexao();

            if (rbNome.Checked)
            {

                var nome = "select * from tbl_disciplinas where dis_nome LIKE '%" + tbPesquisa.Text + "%'";

                _adptador = new SqlDataAdapter(nome, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);

                gridDisciplinas.DataSource = _tabela;
            }
            else if (rbId.Checked)
            {

                var id = "select * from tbl_disciplinas where dis_id = '" + tbPesquisa.Text + "'";

                _adptador = new SqlDataAdapter(id, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);

                gridDisciplinas.DataSource = _tabela;
            }
        }

        private void frmDisciplinasPesquisa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();

            btnBuscar.Enabled = false;
            tbPesquisa.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.disciplinas = new clsDisciplinas();

            this.disciplinas.Dis_id = 0;
            this.disciplinas.Dis_nome = "";
            this.disciplinas.Dis_sigla = "";
            this.disciplinas.Dis_observacoes = "";

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarItem();
            this.Close();
        }

        private void gbOpcoes_Enter(object sender, EventArgs e)
        {

        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                tbPesquisa.Enabled = true;
                btnBuscar.Enabled = true;
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbId.Checked)
            {
                tbPesquisa.Enabled = true;
                btnBuscar.Enabled = true;
            }
        }

        private void frmDisciplinasPesquisa_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmDisciplinasPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
