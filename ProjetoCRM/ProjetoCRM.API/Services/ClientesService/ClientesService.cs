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
        public async Task<ServiceResponse<List<GetClienteDto>>> AdicionarCliente(AddClienteDto novoCliente)
        {
            var serviceResponse = new ServiceResponse<List<GetClienteDto>>();
            clientes.Add(_mapper.Map<Clientes>(novoCliente));
            serviceResponse.Data = clientes.Select(c => _mapper.Map<GetClienteDto>(c)).ToList();
            return serviceResponse;
        }

        //método para buscar um cliente específico por seu id
        public async Task<ServiceResponse<GetClienteDto>> GetClientePorId(int id)
        {
            var serviceResponse = new ServiceResponse<GetClienteDto>();
            //busca o cliente com o Id
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetClienteDto>(cliente);
            return serviceResponse;
        }

        //método para buscar a lista de clientes
        public async Task<ServiceResponse<List<GetClienteDto>>> GetListaClientes()
        {
            var serviceResponse = new ServiceResponse<List<GetClienteDto>>();
            serviceResponse.Data = clientes.Select(c => _mapper.Map<GetClienteDto>(c)).ToList();
            return serviceResponse;
        }

        //método para atualizar cliente pelo id
        public async Task<ServiceResponse<GetClienteDto>> AtualizarCliente(UpdateClienteDto atualizarCliente)
        {
            var serviceResponse = new ServiceResponse<GetClienteDto>();
            //try-catch com exceções caso o id do cliente não seja encontrado
            try
            {
                
                var cliente = clientes.FirstOrDefault(c => c.Id == atualizarCliente.Id);
                if (cliente is null)
                    throw new Exception($"Cliente com Id {atualizarCliente.Id} não foi encontrado");

                cliente = _mapper.Map<Clientes>(atualizarCliente);
                
                serviceResponse.Data = _mapper.Map<GetClienteDto>(cliente);
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            
            return serviceResponse;
        }

        //método para deletar cliente pelo id
        public async Task<ServiceResponse<List<GetClienteDto>>> DeletarClientePorId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetClienteDto>>();
            //try-catch com exceções caso o id do cliente não seja encontrado
            try
            {

                var cliente = clientes.FirstOrDefault(c => c.Id == id);
                if (cliente is null)
                    throw new Exception($"Cliente com Id {id} não foi encontrado");

                clientes.Remove(cliente);

                serviceResponse.Data = clientes.Select(c => _mapper.Map<GetClienteDto>(c)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}
