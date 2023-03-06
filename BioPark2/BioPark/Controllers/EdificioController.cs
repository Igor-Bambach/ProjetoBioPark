using BioPark.Data.Dtos.EdificioDto;
using BioPark.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace BioPark.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EdificioController : ControllerBase
    {
        private readonly EdificioService _service;

        public EdificioController(EdificioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CadastrarEdificio(CriarEdificioDto criarDto)
        {
            Result cadastrar = _service.CadastrarEdificio(criarDto);
            if (cadastrar.ToResult().IsFailed)
            {
                return BadRequest(cadastrar.ToResult().Errors);
            }
            return Ok();
        }
    }
}
