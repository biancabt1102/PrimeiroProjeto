using PrimeiroProjeto.Models;

namespace PrimeiroProjeto.Interfaces;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
