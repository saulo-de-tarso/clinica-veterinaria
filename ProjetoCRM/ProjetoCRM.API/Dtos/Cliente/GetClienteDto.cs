namespace ProjetoCRM.API.Dtos.Cliente
{
    public class GetClienteDto
    {
        //DTO para o GET de clientes do CRM, com suas propriedades Id, nome, cpf, endereço e e-mail
        public int Id { get; set; }
        public string Nome { get; set; } = "Saulo";
        public string Cpf { get; set; } = "081.307.556-45";
        public string Endereco { get; set; } = "Rua Ploomes, 1337, Pinheiros, São Paulo - SP";
        public string Email { get; set; } = "saulo@ploomes.com";
    }
}
