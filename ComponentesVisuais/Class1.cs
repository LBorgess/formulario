﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentesVisuais
{
    public class Estado
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public Estado(string Sigla, string Nome)
        {
            this.Sigla = Sigla;
            this.Nome = Nome;
        }


    }
}
