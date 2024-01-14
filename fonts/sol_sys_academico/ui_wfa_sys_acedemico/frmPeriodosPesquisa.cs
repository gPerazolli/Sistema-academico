using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cl_dal;
using cl_models;
using cl_bll;

namespace ui_wfa_sys_acedemico
{
    public partial class frmPeriodosPesquisa : Form
    {
        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmPeriodosPesquisa()
        {
            InitializeComponent();
        }

        public clsPeriodos periodos;
        public clsPeriodosBll periodosBll;

        public void CarregarGrid()
        {
            periodosBll = new clsPeriodosBll();
            gridPeriodos.DataSource = periodosBll.ListarTodos();
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

        private void SelecionarItem()
        {
            Int32 i = 0;

            periodosBll = new clsPeriodosBll();
            periodos = new clsPeriodos();

            i = gridPeriodos.CurrentRow.Index;
            periodos.Per_id = int.Parse(gridPeriodos[0, i].Value.ToString());
            periodos.Per_nome = gridPeriodos[1, i].Value.ToString();
            periodos.Per_sigla = gridPeriodos[2, i].Value.ToString();

            this.DialogResult = DialogResult.OK;

        }

        private void Buscar()
        {
            _conexao = clsConnection.obterConexao();


            if (rbNome.Checked)
            {
                var nome = "select * from tbl_periodos where per_nome LIKE '%" + tbPesquisa.Text + "%'";

                _adptador = new SqlDataAdapter(nome, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);

                gridPeriodos.DataSource = _tabela;
            }
            else if (rbId.Checked)
            {
                var id = "select * from tbl_periodos where per_id = '" + tbPesquisa.Text + "'";

                _adptador = new SqlDataAdapter(id, _conexao);

                _tabela = new DataTable();

                _adptador.Fill(_tabela);

                gridPeriodos.DataSource = _tabela;
            }
        }

        private void frmPeriodosPesquisa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();

            tbPesquisa.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.periodos = new clsPeriodos();

            this.periodos.Per_id = 0;
            this.periodos.Per_nome = "";
            this.periodos.Per_sigla = "";

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
    }
}
