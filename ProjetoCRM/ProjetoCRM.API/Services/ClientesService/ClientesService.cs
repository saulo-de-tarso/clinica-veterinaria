using AutoMapper;
using ProjetoCRM.API.Dtos.Cliente;
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

        //cria um atributo privado para o automapper, para mapear os serviço pelos Dtos
        private readonly IMapper _mapper;

        //construtor para o serviço de clientes, utilizando o Imapper como parâmetro
        public ClientesService(IMapper mapper)
        {
            _mapper = mapper;
        }

        //método para adicionar cliente
        public async Task<ServiceResponse<List<GetClientesDto>>> AdicionarCliente(AddClientesDto novoCliente)
        {
            var serviceResponse = new ServiceResponse<List<GetClientesDto>>();
            clientes.Add(_mapper.Map<Clientes>(novoCliente));
            serviceResponse.Data = clientes.Select(c => _mapper.Map<GetClientesDto>(c)).ToList();
            return serviceResponse;
        }

        //método para buscar um cliente específico por seu id
        public async Task<ServiceResponse<GetClientesDto>> GetClientePorId(int id)
        {
            var serviceResponse = new ServiceResponse<GetClientesDto>();
            //busca o cliente com o Id
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetClientesDto>(cliente);
            return serviceResponse;
        }

        //método para buscar a lista de clientes
        public async Task<ServiceResponse<List<GetClientesDto>>> GetListaClientes()
        {
            var serviceResponse = new ServiceResponse<List<GetClientesDto>>();
            serviceResponse.Data = clientes.Select(c => _mapper.Map<GetClientesDto>(c)).ToList();
            return serviceResponse;
        }
    }
}
