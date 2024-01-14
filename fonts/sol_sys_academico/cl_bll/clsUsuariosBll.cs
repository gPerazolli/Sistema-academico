using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cl_dal;
using cl_models;

namespace cl_bll
{
    public class clsUsuariosBll
    {
        public clsUsuariosDal usuariosDal = new clsUsuariosDal();

        public void Inserir(clsUsuarios parUsuarios)
        {
            usuariosDal.Inserir(parUsuarios);
        }

        public void Atualizar(clsUsuarios parUsuarios)
        {
            usuariosDal.Atualizar(parUsuarios);
        }

        public void Excluir(string parLogin)
        {
            usuariosDal.Excluir(parLogin);
        }

        public DataTable ListarTodos()
        {
            return usuariosDal.ListarTodos();
        }
    }
}
