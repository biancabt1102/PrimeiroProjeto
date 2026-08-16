using PrimeiroProjeto.Menus;
using PrimeiroProjeto.Models;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string,Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau!");
    }
}