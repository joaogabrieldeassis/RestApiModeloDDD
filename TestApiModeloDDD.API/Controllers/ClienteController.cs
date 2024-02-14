using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;

namespace TestApiModeloDDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente _serviceCliente;

        public ClienteController(IApplicationServiceCliente serviceCliente)
        {
            _serviceCliente = serviceCliente;
        }

        [HttpGet("buscar-todos-os-clientes")]
        public ActionResult<IEnumerable<ClienteDto>> GetAllClients()
        {
            return Ok(_serviceCliente.GetAll());
        }

        [HttpGet("buscar-cliente-pelo-id/{id}")]
        public ActionResult<ClienteDto> GetClientId(Guid id)
        {
            return _serviceCliente.GetByID(id);
        }


        [HttpDelete("deletar-cliente/{id}")]
        public ActionResult DeleteClientId(Guid id)
        {
            var cliente = _serviceCliente.GetByID(id);
            if(cliente == null) return NotFound("Cliente não encontrado na base de dados");

            _serviceCliente.Delete(cliente);

            return Ok("Cliente deletado com sucesso");
        }

        [HttpPost("Criar-cliente")]
        public ActionResult<ClienteDto> CreateClient(ClienteDto cliente) 
        {
            if (!ModelState.IsValid) return BadRequest("O cliente não está valido");

            _serviceCliente.Add(cliente);
            return Ok(cliente);
        }

        [HttpPut("Atualizar-cliente")]
        public ActionResult<ClienteDto> UpdateClient(ClienteDto cliente) 
        {
            if (!ModelState.IsValid) return BadRequest("O cliente não está valido");

            _serviceCliente.Update(cliente);
            return Ok(cliente);
        }
    }
}