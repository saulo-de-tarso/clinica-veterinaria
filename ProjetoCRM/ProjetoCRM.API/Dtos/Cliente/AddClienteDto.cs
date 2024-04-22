namespace ProjetoCRM.API.Dtos.Cliente
{
    public class AddClienteDto
    {
        //DTO para o POST de clientes do CRM, com suas propriedades Nome, cpf, endereço e e-mail. Id não é necessário, pois vai ser gerado pelo SQL server.
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Endereco { get; set; }
        public string? Email { get; set; }
    }
}
