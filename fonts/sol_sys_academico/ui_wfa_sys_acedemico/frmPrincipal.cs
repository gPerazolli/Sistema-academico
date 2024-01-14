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
using Microsoft.VisualBasic;
using System.Globalization;

namespace ui_wfa_sys_acedemico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        public frmPrincipal(string nomeUsuario)
        {
            InitializeComponent();

            lbBemVindo.Text = $"Seja bem-vindo(a), {nomeUsuario}";
        }

        Thread nt;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;

            string dataPorExtenso = dataAtual.ToString("dddd, d 'de' MMMM 'de' yyyy ' - ' HH:mm", new CultureInfo("pt-BR"));

            // Converter a primeira letra do dia da semana e do mês em maiúsculas
            dataPorExtenso = char.ToUpper(dataPorExtenso[0]) + dataPorExtenso.Substring(1);
            int indexMes = dataPorExtenso.IndexOf(" de ");
            if (indexMes > 0 && indexMes + 4 < dataPorExtenso.Length)
            {
                dataPorExtenso = dataPorExtenso.Substring(0, indexMes + 4) + char.ToUpper(dataPorExtenso[indexMes + 4]) + dataPorExtenso.Substring(indexMes + 5);
            }

            lbData.Text = dataPorExtenso;

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplinas frmDisciplinas = new frmCadastroDisciplinas();
            frmDisciplinas.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPeriodos frmPeriodos = new frmCadastroPeriodos();
            frmPeriodos.ShowDialog();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCursos frmCursos = new frmCadastroCursos();
            frmCursos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(LogOff);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.AcceptButton = null;
        }

        private void LogOff()
        {
            Application.Run(new frmLogin());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbData_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;

            string dataPorExtenso = dataAtual.ToString("dddd, d 'de' MMMM 'de' yyyy ' - ' HH:mm", new CultureInfo("pt-BR"));

            // Converter a primeira letra do dia da semana e do mês em maiúsculas
            dataPorExtenso = char.ToUpper(dataPorExtenso[0]) + dataPorExtenso.Substring(1);
            int indexMes = dataPorExtenso.IndexOf(" de ");
            if (indexMes > 0 && indexMes + 4 < dataPorExtenso.Length)
            {
                dataPorExtenso = dataPorExtenso.Substring(0, indexMes + 4) + char.ToUpper(dataPorExtenso[indexMes + 4]) + dataPorExtenso.Substring(indexMes + 5);
            }

            lbData.Text = dataPorExtenso;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Encerrar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios frmUsuarios = new frmCadastroUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }
    }
}