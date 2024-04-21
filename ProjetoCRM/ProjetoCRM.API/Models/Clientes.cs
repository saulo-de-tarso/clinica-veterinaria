namespace ProjetoCRM.API.Models
{
    public class Clientes
    {
        //Entidade de clientes do CRM, com suas propriedades Id, nome, cpf, endereço e e-mail
        public int Id { get; set; }
        public string Nome { get; set; } = "Saulo";
        public string Cpf { get; set; } = "081.307.556-45";
        public string Endereco { get; set; } = "Rua Ploomes, 1337, Pinheiros, São Paulo - SP";
        public string Email { get; set; } = "saulo@ploomes.com";
    }
}
