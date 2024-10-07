using PaginaLanches.Models;

namespace PaginaLanches.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Lanche>? LanchesPreferidos { get; set; }
}
