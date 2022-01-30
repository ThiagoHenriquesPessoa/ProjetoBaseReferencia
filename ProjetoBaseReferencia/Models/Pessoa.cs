using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBaseReferencia.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int Idade { get; set; }
    }
}
