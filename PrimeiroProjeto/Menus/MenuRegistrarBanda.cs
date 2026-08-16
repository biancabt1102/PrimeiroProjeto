using PrimeiroProjeto.Models;

namespace PrimeiroProjeto.Menus;

internal class MenuRegistrarBanda: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.Equals(nomeDaBanda))
        {
            Console.WriteLine($"A banda {nomeDaBanda} já foi registrada.");
        }
        else
        {
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
