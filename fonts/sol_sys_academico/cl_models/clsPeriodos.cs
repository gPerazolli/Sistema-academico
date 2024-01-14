using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsPeriodos
    {
        private int _per_id;
        private string _per_nome;
        private string _per_sigla;

        public int Per_id
        {
            get { return _per_id; }
            set { _per_id = value; }
        }

        public string Per_nome
        {
            get { return _per_nome; }
            set { _per_nome = value; }
        }

        public string Per_sigla
        {
            get { return _per_sigla; }
            set { _per_sigla = value; }
        }
    }
}
