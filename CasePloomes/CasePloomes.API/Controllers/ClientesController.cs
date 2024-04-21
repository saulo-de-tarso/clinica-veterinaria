using CasePloomes.API.DTOs;
using CasePloomes.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CasePloomes.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace CasePloomes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly CasePloomesDbContext _dbContext;

        public ClientesController(CasePloomesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public static ClientesEntity MapToClientesEntity(CriarClienteDto criarClienteDto)
        {
            return new ClientesEntity
            {
                Nome = criarClienteDto.Nome,
                Telefone = criarClienteDto.Telefone,
                CPF = criarClienteDto.CPF,
                Endereco = criarClienteDto.Endereco,
                Email = criarClienteDto.Email
            };
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CriarCliente([FromBody] CriarClienteDto criarClienteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ClientesEntity cliente = new ClientesEntity {
                Nome = criarClienteDto.Nome,
                Telefone = criarClienteDto.Telefone,
                CPF = criarClienteDto.CPF,
                Endereco = criarClienteDto.Endereco,
                Email = criarClienteDto.Email
            };

            _dbContext.Clientes.Add(cliente);

            try
            {
                // Save changes to the database
                await _dbContext.SaveChangesAsync();

                // Return a success response
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., database errors)
                return StatusCode(500, $"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
