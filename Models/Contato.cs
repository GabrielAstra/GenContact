using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Numero { get; set; }

        public string? Apelido { get; set; }


        public Contato()
        {

            Nome = string.Empty;
        }
    }
}