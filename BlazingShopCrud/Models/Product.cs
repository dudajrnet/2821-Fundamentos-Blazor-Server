using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Product
{
    [Key]
    [Required(ErrorMessage = "Id é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título é obrigatório")]
    [MaxLength(150, ErrorMessage = "O título deve ter no máximo 150 caracteres")]
    [MinLength(5, ErrorMessage = "O título deve ter no mínimo 5 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "O preço é obrigatório.")]
    [DataType(DataType.Currency)]
    [Range(1, 9999, ErrorMessage = "O preço deve estar entre 1 e 9999")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "A Categoria é obrigatória")]
    [Range(1, 9999, ErrorMessage = "A Categoria deve estar entre 1 e 9999")]
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
}