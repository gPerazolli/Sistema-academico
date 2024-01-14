using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsCursos
    {
        private int _cur_id;
        private string _cur_nome;
        private string _cur_sigla;
        private string _cur_observacoes;
        
        public int Cur_id
        {
            get { return _cur_id; }
            set { _cur_id = value; }
        }

        public string Cur_nome
        {
            get { return _cur_nome; }
            set { _cur_nome = value; }
        }

        public string Cur_sigla
        {
            get { return _cur_sigla;}
            set { _cur_sigla = value;}
        }

        public string Cur_observacoes
        {
            get { return _cur_observacoes; }
            set { _cur_observacoes = value; }
        }
    }

}
