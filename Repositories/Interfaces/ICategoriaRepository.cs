using PaginaLanches.Models;

namespace PaginaLanches.Repositories.Interfaces;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}
