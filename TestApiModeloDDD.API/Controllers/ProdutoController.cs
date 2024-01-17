using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;

namespace TestApiModeloDDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _serviceProduto;

        public ProdutoController(IApplicationServiceProduto serviceProduto)
        {
            _serviceProduto = serviceProduto;
        }

        [HttpGet("buscar-todos-os-produtos")]
        public ActionResult<IEnumerable<ProdutoDto>> GetAllClients()
        {
            return Ok(_serviceProduto.GetAll());
        }

        [HttpGet("buscar-produto-pelo-id/{id}")]
        public ActionResult<ProdutoDto> GetClientId(Guid id)
        {
            return _serviceProduto.GetByID(id);
        }


        [HttpDelete("deletar-cliente/{id}")]
        public ActionResult DeleteClientId(Guid id)
        {
            var produto = _serviceProduto.GetByID(id);
            if (produto == null) return NotFound("Cliente não encontrado na base de dados");

            _serviceProduto.Delete(produto);

            return Ok("Cliente deletado com sucesso");
        }

        [HttpPost("Criar-cliente")]
        public ActionResult<ProdutoDto> CreateClient(ProdutoDto produto)
        {
            if (!ModelState.IsValid) return BadRequest("O cliente não está valido");

            _serviceProduto.Add(produto);
            return Ok(produto);
        }

        [HttpPut("Atualizar-cliente")]
        public ActionResult<ProdutoDto> UpdateClient(ProdutoDto produto)
        {
            if (!ModelState.IsValid) return BadRequest("O cliente não está valido");

            _serviceProduto.Update(produto);
            return Ok(produto);
        }
    }
}
