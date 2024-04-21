namespace ProjetoCRM.API.Dtos.Cliente
{
    public class AddClienteDto
    {
        //DTO para o POST de clientes do CRM, com suas propriedades Nome, cpf, endereço e e-mail. Id não é necessário, pois vai ser gerado pelo SQL server.
        public string Nome { get; set; } = "Saulo";
        public string Cpf { get; set; } = "081.307.556-45";
        public string Endereco { get; set; } = "Rua Ploomes, 1337, Pinheiros, São Paulo - SP";
        public string Email { get; set; } = "saulo@ploomes.com";
    }
}
