using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_ef.Models
{
    public class Registro
    {

        public Registro()
        {
            
        }

        public Registro(DateTime Data, string Conteudo, Caderno Caderno)
        {
            data = Data;
            conteudo = Conteudo;
            caderno = Caderno;
        }

        public int id {get; set;}

        public DateTime data {get; set;}

        public string? conteudo {get; set;}

        public Caderno caderno {get;set;}

        public int cadernoId {get; set;}
    }
}