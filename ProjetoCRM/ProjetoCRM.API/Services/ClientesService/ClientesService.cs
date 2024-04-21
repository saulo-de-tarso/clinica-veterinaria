using ProjetoCRM.API.Models;

namespace ProjetoCRM.API.Services.ClientesService
{
    public class ClientesService : IClientesService
    {
        //método para gerar uma lista de clientes
        private static List<Clientes> clientes = new List<Clientes>
        {
            new Clientes(),
            new Clientes { Id = 1, Nome = "Paulo"}
        };

        
        //método para adicionar cliente
        public async Task<ServiceResponse<List<Clientes>>> AdicionarCliente(Clientes novoCliente)
        {
            var serviceResponse = new ServiceResponse<List<Clientes>>();
            clientes.Add(novoCliente);
            serviceResponse.Data = clientes;
            return serviceResponse;
        }

        //método para buscar um cliente específico por seu id
        public async Task<ServiceResponse<Clientes>> GetClientePorId(int id)
        {
            var serviceResponse = new ServiceResponse<Clientes>();
            //busca o cliente com o Id
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = cliente;
            return serviceResponse;
        }

        //método para buscar a lista de clientes
        public async Task<ServiceResponse<List<Clientes>>> GetListaClientes()
        {
            var serviceResponse = new ServiceResponse<List<Clientes>>();
            serviceResponse.Data = clientes;
            return serviceResponse;
        }
    }
}
