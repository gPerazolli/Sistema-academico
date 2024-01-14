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
    public class clsPeriodosBll
    {

        public clsPeriodosDal periodosDal = new clsPeriodosDal();

        public void Inserir(clsPeriodos parPeriodos)
        {
            try
            {
                if(periodosDal.obterNumeroPeriodosSigla(parPeriodos.Per_sigla) > 0)
                {
                    throw new Exception("BLL: Já existe um periodo com a SIGLA informada!");
                }
                else
                {
                    periodosDal.Inserir(parPeriodos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(clsPeriodos parPeriodos)
        {
            periodosDal.Atualizar(parPeriodos);
        }

        public void Excluir(int parIdPeriodo)
        {
            periodosDal.Excluir(parIdPeriodo);
        }

        public DataTable ListarTodos()
        {
            return periodosDal.ListarTodos();
        }

    }
}
