using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cl_models
{
    public class clsUsuarios
    {
        private string _nome_usu;
        private string _login_usu;
        private string _senha_usu;

        public string Nome_usu
        {
            get { return _nome_usu; }
            set { _nome_usu = value; }
        }

        public string Login_usu
        {
            get { return _login_usu; }
            set { _login_usu = value; }
        }

        public string Senha_usu
        {
            get { return _senha_usu; }
            set { _senha_usu = value; }
        }
    }
}
