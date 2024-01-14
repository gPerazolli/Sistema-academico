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
    public partial class frmCursosPesquisa : Form
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmCursosPesquisa()
        {
            InitializeComponent();
        }

        public clsCursos cursos;
        public clsCursosBll cursosBll;

        private void CarregarGrid()
        {
            cursosBll = new clsCursosBll();
            gridCursos.DataSource = cursosBll.ListarTodos();

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

        private void SelecionarItem()
        {
            Int32 i = 0;

            cursosBll = new clsCursosBll();
            cursos = new clsCursos();

            i = gridCursos.CurrentRow.Index;
            cursos.Cur_id = int.Parse(gridCursos[0, i].Value.ToString());
            cursos.Cur_nome = gridCursos[1, i].Value.ToString();
            cursos.Cur_sigla = gridCursos[2, i].Value.ToString();
            cursos.Cur_observacoes = gridCursos[3, i].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void Buscar()
        {
            _conexao = clsConnection.obterConexao();


            if (rbNome.Checked)
            {
                var nome = "select * from tbl_cursos where cur_nome LIKE '%" + tbPesquisa.Text + "%'";

                _adptador = new SqlDataAdapter(nome, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);

                gridCursos.DataSource = _tabela;

            }
            else if (rbId.Checked)
            {
                var id = "select * from tbl_cursos where cur_id = '" + tbPesquisa.Text + "'";

                _adptador = new SqlDataAdapter(id, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);

                gridCursos.DataSource = _tabela;
            }

        }

        private void frmCursosPesquisa_Load(object sender, EventArgs e)
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
            this.cursos = new clsCursos();

            this.cursos.Cur_id = 0;
            this.cursos.Cur_nome = "";
            this.cursos.Cur_sigla = "";
            this.cursos.Cur_observacoes = "";

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarItem();
            this.Close();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                btnBuscar.Enabled = true;
                tbPesquisa.Enabled = true;
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbId.Checked)
            {
                btnBuscar.Enabled = true;
                tbPesquisa.Enabled = true;
            }
        }
    }
}
