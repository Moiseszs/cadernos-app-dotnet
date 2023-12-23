using System.Timers;
using exercicio_ef.Controllers;


CadernoController cadernoController = new CadernoController();

RegistroController registroController = new RegistroController();

void RodaOpcoes(){
    Console.Clear();

    Console.WriteLine("Opções");
    Console.WriteLine("1 - Inserir novo caderno");
    Console.WriteLine("2 - Inserir novo registro");
    Console.WriteLine("3 - Listar Cadernos");
    Console.WriteLine("4 - Listar registros");
    Console.WriteLine("5 - Sair");
    Console.Write("Qual sua opção? ");

    int opcao;

    if(int.TryParse(Console.ReadLine(), out opcao))
    {
        switch(opcao){
            case 1:
                cadernoController.AddCaderno();
                RodaOpcoes();
                break;
            case 2:
                registroController.AddRegistro();
                RodaOpcoes();
                break;
            case 3:
                cadernoController.ListaCadernos();
                Console.Write("Continuar? ");
                Console.ReadLine();
                RodaOpcoes();
                break;
            case 4:
                registroController.ListarRegistros();
                Console.Write("Continuar? ");
                Console.ReadLine();
                RodaOpcoes();
                break;
            case 5:
                break;
            default:
                RodaOpcoes();
                break;
    }
    }
    else
    {
        RodaOpcoes();
    }

}

RodaOpcoes();