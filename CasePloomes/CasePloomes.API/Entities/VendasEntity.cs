using System.ComponentModel.DataAnnotations;

namespace CasePloomes.API.Entities
{
    public class VendasEntity
    {
        [Key]
        [Required(ErrorMessage = "O ID do cliente é obrigatório.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O valor deve ser um número inteiro.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a 1.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O código do produto é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo {1} caracteres.")]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O valor deve ser um número inteiro.")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a 1.")]
        public int Quantidade { get; set; }

    }
}
