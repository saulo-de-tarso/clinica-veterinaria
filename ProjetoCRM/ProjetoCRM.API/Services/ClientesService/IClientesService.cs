using ProjetoCRM.API.Models;
namespace ProjetoCRM.API.Services.ClientesService
{
    //interface para o serviço de clientes
    public interface IClientesService
    {
        //método para buscar a lista de clientes
        List<Clientes> GetListaClientes();

        //método para buscar um cliente específico por seu id
        Clientes GetClientePorId(int id);

        //método para adicionar cliente
        List<Clientes> AdicionarCliente(Clientes novoCliente);

    }
}
