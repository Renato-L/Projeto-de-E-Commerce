using Microsoft.EntityFrameworkCore;
using PaginaLanches.Context;
using PaginaLanches.Models;
using PaginaLanches.Repositories.Interfaces;

namespace PaginaLanches.Repositories;

public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _contexto;

    public LancheRepository(AppDbContext contexto)
    {
        _contexto = contexto;
    }

    public IEnumerable<Lanche> Lanches => _contexto.Lanches.Include(c => c.Categoria);

    public IEnumerable<Lanche> LanchesPreferidos => _contexto.Lanches.Where(c => c.IsLanchePreferido).Include(c => c.Categoria);

    public Lanche GetLancheById(int lancheId)
    {
        return _contexto.Lanches.FirstOrDefault(c => c.LancheId == lancheId);
    }
}
