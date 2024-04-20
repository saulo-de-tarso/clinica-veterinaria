using System.ComponentModel.DataAnnotations;

namespace CasePloomes.API.Entities
{
    public class ClientesEntity
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [RegularExpression(@"^\(\d{2}\) \d{5}-\d{4}$", ErrorMessage = "O telefone deve estar no formato (xx) xxxxx-xxxx.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato xxx.xxx.xxx-xx.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(255, ErrorMessage = "O endereço deve ter no máximo {1} caracteres.")]
        public string Endereco { get; set; }

        [EmailAddress(ErrorMessage = "O email não está em um formato válido.")]
        [StringLength(255, ErrorMessage = "O email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
