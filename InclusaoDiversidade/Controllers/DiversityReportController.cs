using InclusaoDiversidade.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace InclusaoDiversidade.Controllers
{
    [ApiController]
    [Route("diversity-report")]
    public class DiversityReportController : ControllerBase
    {
        private readonly IDiversityReportService _service;

        public DiversityReportController(IDiversityReportService service)
        {
            _service = service;
        }

        [HttpGet("generate")]
        public async Task<IActionResult> Generate()
        {
            var result = await _service.GenerateReportAsync();
            return Ok(result);
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetHistory([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var result = await _service.GetHistoryAsync(page, pageSize);
            return Ok(result);
        }
    }
}
