using ProjetoCRM.API.Dtos.Cliente;
using ProjetoCRM.API.Models;
namespace ProjetoCRM.API.Services.ClientesService
{
    //interface para o serviço de clientes
    public interface IClientesService
    {
        //método para buscar a lista de clientes
        Task<ServiceResponse<List<GetClientesDto>>> GetListaClientes();

        //método para buscar um cliente específico por seu id
        Task<ServiceResponse<GetClientesDto>> GetClientePorId(int id);

        //método para adicionar cliente
        Task<ServiceResponse<List<GetClientesDto>>> AdicionarCliente(AddClientesDto novoCliente);

    }
}
