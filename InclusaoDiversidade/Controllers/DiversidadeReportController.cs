using InclusaoDiversidade.Application.DTO;
using InclusaoDiversidade.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InclusaoDiversidade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiversidadeReportController : ControllerBase
    {
        private readonly IDiversidadeReportService _service;

        public DiversidadeReportController(IDiversidadeReportService service)
        {
            _service = service;
        }

        // GET api/DiversidadeReport/gerar
        [HttpGet("gerar")]
        public async Task<IActionResult> GerarRelatorio()
        {
            var resultado = await _service.GerarRelatorioAsync();
            return Ok(resultado);
        }

        // GET api/DiversidadeReport/historico
        [HttpGet("historico")]
        public async Task<IActionResult> ObterHistorico()
        {
            var lista = await _service.ObterHistoricoAsync();
            return Ok(lista);
        }
    }
}

