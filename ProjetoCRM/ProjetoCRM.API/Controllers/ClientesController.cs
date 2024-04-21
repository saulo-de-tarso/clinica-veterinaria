using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCRM.API.Dtos.Cliente;
using ProjetoCRM.API.Models;
using ProjetoCRM.API.Services.ClientesService;

namespace ProjetoCRM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //cria um atributo privado para o serviço de clientes
        private readonly IClientesService _clientesService;

        //construtor para o controlador de clientes, utilizando o serviço de clientes como parâmetro
        public ClientesController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        //GET para buscar a lista de clientes, utilizando o método implantado no serviço de clientes
        [HttpGet("ListaClientes")]
        public async Task<ActionResult<ServiceResponse<List<GetClienteDto>>>> GetListaClientes()
        {
            return Ok(await _clientesService.GetListaClientes());
        }

        //GET para buscar a cliente por id, utilizando o método implantado no serviço de clientes
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetClienteDto>>> GetClientePorId(int id)
        {
            return Ok(await _clientesService.GetClientePorId(id));
        }

        //POST para adicionar novos clientes, utilizando o método implantado no serviço de clientes
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetClienteDto>>>> AdicionarCliente(AddClienteDto novoCliente)
        {
            return Ok(await _clientesService.AdicionarCliente(novoCliente));
        }

        //PUT para atualizar clientes, utilizando o método implantado no serviço de clientes
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetClienteDto>>> AtualizarCliente(UpdateClienteDto atualizarCliente)
        {
            var response = await _clientesService.AtualizarCliente(atualizarCliente);
            if (response.Data is null)
                return NotFound(response);
            return Ok(await _clientesService.AtualizarCliente(atualizarCliente));
        }
    }
}
