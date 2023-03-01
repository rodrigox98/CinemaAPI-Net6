using CinemaAPI.Models.DTO.Endereco;
using CinemaAPI.Service;
using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private EnderecoService _service;

        public EnderecoController([FromBody] EnderecoService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult CriarEndereco(CreateEnderecoDTO enderecoDTO)
        {
            ReadEnderecoDTO endereco = _service.CriarEndereco(enderecoDTO);
            return Ok();
        }

        [HttpGet] 
        public IActionResult RecuperarEnderecos()
        {
            List<ReadEnderecoDTO> enderecos = _service.ReceberEnderecos();
            return Ok(enderecos);
        }

    }
}
