using System;
List<string> listaDeBandas = new List<string>(); 

void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Boas vindas ao Screen Sound!");
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Digite um nome de uma banda: ");
    string nomeBanda = Convert.ToString(Console.ReadLine()!);
    listaDeBandas.Add(nomeBanda);
    Console.WriteLine($"O nome da banda: {nomeBanda}");
    Console.Clear();
}

void MostrarBandas()
{
    Console.Clear();
    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine($"Nome da banda {i}: {listaDeBandas[i]}");
    }
    Console.Clear();
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine()!);
    
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a opção " + opcao);
            RegistrarBanda();
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcao);
            MostrarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcao);
            break;
        case -1:
            break;
        default: 
            Console.WriteLine("Opção inválida"); 
            break;
    }
}

ExibirMensagem();
ExibirOpcoesDoMenu();
