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
    public partial class frmUsuariosPesquisa : Form
    {

        private SqlConnection _conexao;
        private SqlCommand _comandos;
        private SqlDataAdapter _adptador;
        private DataTable _tabela;

        public frmUsuariosPesquisa()
        {
            InitializeComponent();
        }

        public clsUsuarios usuario;
        public clsUsuariosDal usuarioDal;
        public clsUsuariosBll usuarioBll;

        private void CarregarGrid()
        {
            gridUsuarios.DataSource = usuarioBll.ListarTodos();
        }

        public void AtivarFormulario()
        {
            CarregarGrid();
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            gridUsuarios.ReadOnly = true;
            gridUsuarios.ScrollBars = ScrollBars.Both;
            gridUsuarios.Columns[0].HeaderText = "NOME";
            gridUsuarios.Columns[1].HeaderText = "LOGIN";
            gridUsuarios.Columns[2].HeaderText = "SENHA";

            gridUsuarios.Columns[0].Width = 200;
            gridUsuarios.Columns[1].Width = 150;
            gridUsuarios.Columns[2].Width = 80;
        }

        public void SelecionarItem()
        {
            Int32 i = 0;

            i = gridUsuarios.CurrentRow.Index;
            usuario.Nome_usu = gridUsuarios[0, i].Value.ToString();
            usuario.Login_usu = gridUsuarios[1, i].Value.ToString();
            usuario.Senha_usu = gridUsuarios[2, i].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCadastroUsuariosPesquisa_Load(object sender, EventArgs e)
        {
            usuario = new clsUsuarios();
            usuarioBll = new clsUsuariosBll();
            AtivarFormulario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.usuario.Nome_usu = "";
            this.usuario.Login_usu = "";
            this.usuario.Senha_usu = "";

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            this.SelecionarItem();
            this.Close();
        }
    }
}
