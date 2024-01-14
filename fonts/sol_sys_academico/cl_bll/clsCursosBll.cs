using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using cl_models;
using cl_dal;

namespace cl_bll
{
    public class clsCursosBll
    {

        public clsCursosDal cursosDal = new clsCursosDal();

        public void Inserir(clsCursos parCursos)
        {
            try
            {
                if(cursosDal.obterNumeroCursosSigla(parCursos.Cur_sigla) > 0)
                {
                    throw new Exception("BLL: Já existe um curso com a SIGLA informada!");
                }
                else
                {
                    cursosDal.Inserir(parCursos);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsCursos parCursos)
        {
            cursosDal.Atualizar(parCursos);
        }

        public void Excluir(int parIdCursos)
        {
            cursosDal.Excluir(parIdCursos);
        }

        public DataTable ListarTodos()
        {
            return cursosDal.ListarTodos();
        }
    }
}