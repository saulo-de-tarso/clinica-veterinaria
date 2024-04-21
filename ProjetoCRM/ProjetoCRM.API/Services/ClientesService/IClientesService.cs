using ProjetoCRM.API.Models;
namespace ProjetoCRM.API.Services.ClientesService
{
    //interface para o serviço de clientes
    public interface IClientesService
    {
        //método para buscar a lista de clientes
        Task<ServiceResponse<List<Clientes>>> GetListaClientes();

        //método para buscar um cliente específico por seu id
        Task<ServiceResponse<Clientes>> GetClientePorId(int id);

        //método para adicionar cliente
        Task<ServiceResponse<List<Clientes>>> AdicionarCliente(Clientes novoCliente);

    }
}
