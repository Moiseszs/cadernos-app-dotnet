using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_ef.Models;
using Microsoft.EntityFrameworkCore;

namespace exercicio_ef.Controllers
{
    public class RegistroController
    {

        AppContext context;

        public RegistroController()
        {
            context = new AppContext();
        }


        public void AddRegistro(){
            Console.Write("Digite a data do registro: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o conteudo do registro: ");
            string conteudo = Console.ReadLine();
            Console.Write("Digite o Id do Caderno: ");
            int cadernoId = int.Parse(Console.ReadLine());
            Caderno caderno = context.cadernos.Find(cadernoId);
            Registro registro = new Registro(data, conteudo, caderno);
            context.Add(registro);
            context.SaveChanges();
        }

        public void ListarRegistros(){
            var registros = context.registros.Include(reg => reg.caderno);

            foreach(Registro registro in registros){
                Console.WriteLine($"Registro de [ {registro.data} ] no caderno [ {registro.caderno.nome} ] com conteudo: {registro.conteudo}");
            }
        }
    }
}