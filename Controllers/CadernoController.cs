using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_ef.Models;

namespace exercicio_ef.Controllers
{
    public class CadernoController
    {
        AppContext context;


        public CadernoController()
        {
            context = new AppContext();
        }

        public async void AddCaderno(){
            Console.Write("Digite o nome para o novo caderno: ");
            string Nome = "";
            Nome = Console.ReadLine();
            Caderno caderno = new Caderno(Nome);
            Console.Write("Adicionando...");
            context.Add(caderno);
            context.SaveChanges(); 
        }

        public void ListaCadernos(){
            var cadernos = context.cadernos;

            if(cadernos.Any()){
                Console.WriteLine("Cadernos: ");
                foreach(Caderno caderno in cadernos){
                    Console.WriteLine($"{caderno.id} - {caderno.nome}");
                }
            }
            else{
                Console.WriteLine("Não nenhum caderno adicionado.");
            }
        }
    }
}