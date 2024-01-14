using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsDisciplinas
    {
        private int _dis_id;
        private string _dis_nome;
        private string _dis_sigla;
        private string _dis_observacoes;


        public int Dis_id
        {
            get { return _dis_id; }
            set { _dis_id = value; }
        }

        public string Dis_nome
        {
            get { return _dis_nome; }
            set { _dis_nome = value; }
        }

        public string Dis_sigla
        {
            get { return _dis_sigla;}
            set { _dis_sigla = value;}
        }

        public string Dis_observacoes
        {
            get { return _dis_observacoes; }
            set { _dis_observacoes = value; }
        }
    }
}
