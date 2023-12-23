using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_ef.Models
{
    public class Caderno
    {

        public Caderno()
        {

        }


        public Caderno(string Nome)
        {
            nome = Nome;
        }

        public int id {get; set;}

        public string nome {get;set;}

        public ICollection<Registro>? registros {get;}
    }
}