using BioPark.Data.Dtos.ApartamentoDto;
using BioPark.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace BioPark.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApartamentoController : ControllerBase
    {
        private readonly ApartamentoService _service;

        public ApartamentoController(ApartamentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CadastrarApartamento(CriarApartamentoDto apartamentoDto)
        {
            var cadastrar = _service.CadastrarApartamento(apartamentoDto);
            if (cadastrar.ToResult().IsFailed)
            {
                return BadRequest(cadastrar.ToResult().Errors);
            }
            return CreatedAtAction(nameof(PesquisaApartamentoPorDisponibilidade), new { disponibilidade = apartamentoDto.Disponibilidade}, apartamentoDto);
        }

        [HttpGet]
        public IActionResult PesquisaApartamentoPorDisponibilidade(bool disponibilidade)
        {
            var pesquisaApartamento = _service.PesquisaApartamentoPorDisponibilidade(disponibilidade);
            return Ok(pesquisaApartamento);
        }
    }
}
