﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.Domain.Conta
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
    }
}
