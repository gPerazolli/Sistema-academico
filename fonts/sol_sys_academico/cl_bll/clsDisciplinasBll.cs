using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cl_dal;
using cl_models;

namespace cl_bll
{
    public class clsDisciplinasBll
    {
        public  clsDisciplinasDal disciplinasDal = new clsDisciplinasDal();

        public void Inserir(clsDisciplinas parDisciplinas)
        {
            try
            {
                if(disciplinasDal.obterNumeroDisciplinasSigla(parDisciplinas.Dis_sigla) > 0)
                {
                    throw new Exception("BLL: Já existe uma disciplinas com a SIGLA informada!");
                }
                else
                {
                    disciplinasDal.Inserir(parDisciplinas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public void Atualizar(clsDisciplinas parDisciplinas)
        {
            disciplinasDal.Atualizar(parDisciplinas);
        }

        public void Excluir(int parIdDisciplinas)
        {
            disciplinasDal.Excluir(parIdDisciplinas);
        }

        public DataTable ListarTodos()
        {
            return disciplinasDal.ListarTodos();
        }

    }
}
