using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoFormulário
{
    class Estado
    {
        public string sigla { get; set; }
        public string nome { get; set; }

        public Estado(string sigla, string nome)
        {
            this.sigla = sigla;
            this.nome = nome; 
        }
    }
}
