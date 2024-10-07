using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace PaginaLanches.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descricao do lanche deve ser informada")]
    [Display(Name = "Descricao do Lanche")]
    [MinLength(20, ErrorMessage = "A descricao do lanche deve ter no minimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "A descricao do lanche deve ter no maximo {1} caracteres")]
    public string? DescricaoCurta { get; set; }

    [Required(ErrorMessage = "A descricao detalhada do lanche deve ser informada")]
    [Display(Name = "Descricao Detalhada do Lanche")]
    [MinLength(20, ErrorMessage = "A descricao do lanche deve ter no minimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "A descricao do lanche deve ter no maximo {1} caracteres")]
    public string? DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "Informe o preco do lanche")]
    [Display(Name = "Preco do Lanche")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1, 999.99, ErrorMessage = "O preco deve estar entre 1 e 999.99")]
    public decimal Preco { get; set; }

    [Display(Name = "Caminho imagem normal")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
    public string? ImageUrl { get; set; }

    [Display(Name = "Caminho imagem miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
    public string? ImageThumbnailUrl { get; set; }

    [Display(Name = "Preferido?")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria? Categoria { get; set; }
}
