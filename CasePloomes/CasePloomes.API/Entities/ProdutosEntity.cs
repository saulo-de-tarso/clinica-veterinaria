using System.ComponentModel.DataAnnotations;

namespace CasePloomes.API.Entities
{
    public class ProdutosEntity
    {
        [Key]
        [Required(ErrorMessage = "O código é obrigatório.")]
        [StringLength(50, ErrorMessage = "O código deve ter no máximo {1} caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(255, ErrorMessage = "O nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O grupo é obrigatório.")]
        [StringLength(100, ErrorMessage = "O grupo deve ter no máximo {1} caracteres.")]
        public string Grupo { get; set; }

        [Required(ErrorMessage = "O valor unitário é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor unitário deve ser maior que zero.")]
        public decimal ValorUnitario { get; set; }
    }
}
