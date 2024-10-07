using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaginaLanches.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho maximo eh 100 caracteres")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [Display(Name = "Nome")]
    public string? CategoriaNome { get; set; }

    [StringLength(200, ErrorMessage = "O tamanho maximo eh 200 caracteres")]
    [Required(ErrorMessage = "Informe a descricao da categoria")]
    [Display(Name = "Descricao")]
    public string? Descricao { get; set; }

    public List<Lanche>? Lanches { get; set; }
}
