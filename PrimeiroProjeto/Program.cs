using System;
using System.Linq.Expressions;
Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
listaDeBandas.Add("LinkParking", new List<int> { 1, 2, 3 });
listaDeBandas.Add("The Beatles", new List<int> ());

void ExibirLogo()
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
void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.WriteLine("Digite um nome de uma banda: ");
    string nomeBanda = Convert.ToString(Console.ReadLine()!);
    listaDeBandas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"O nome da banda: {nomeBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloOpcao(string mensagem)
{
    int qtde = mensagem.Length;
    string asterisco = String.Concat(Enumerable.Repeat<string>("*", qtde));
    Console.WriteLine(asterisco);
    Console.WriteLine(mensagem);
    Console.WriteLine(String.Concat(asterisco, "\n"));
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in listaDeBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar as bandas");
    Console.Write("Digite a banda que deseja avaliar: ");
    string banda = Console.ReadLine()!;

    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        try
        {
            if (listaDeBandas.ContainsKey(banda))
            {
                Console.WriteLine("Digite uma nota para a banda: ");
                int nota = Convert.ToInt32(Console.ReadLine()!);
                listaDeBandas[banda].Add(nota);
                Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {banda}");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
            else {
                Console.WriteLine($"A banda {banda} não foi encontrada.");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Banda não encontrada: {ex.Message}");
        }
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
            RegistrarBandas();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBandas();
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

ExibirLogo();
ExibirOpcoesDoMenu();
