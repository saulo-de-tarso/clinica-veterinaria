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
        public List<Clientes> AdicionarCliente(Clientes novoCliente)
        {
            clientes.Add(novoCliente);
            return clientes;
        }

        //método para buscar um cliente específico por seu id
        public Clientes GetClientePorId(int id)
        {
            //busca o cliente com o Id
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            //se o cliente não for nulo, retorna o cliente
            if (cliente is not null)
                return cliente;
            //se o id do cliente não existir, retorna uma exceção de cliente não encontrado.
            throw new Exception("Cliente não encontrado.");
        }

        //método para buscar a lista de clientes
        public List<Clientes> GetListaClientes()
        {
            return clientes;
        }
    }
}
