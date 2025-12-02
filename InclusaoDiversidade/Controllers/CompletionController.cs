[ApiController]
[Route("api/[controller]")]
public class CompletionController : ControllerBase
{
private readonly CompletionService _service;


public CompletionController(CompletionService service)
{
_service = service;
}


[HttpGet]
public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
{
var result = await _service.GetAllAsync(page, pageSize);
return Ok(result);
}


[HttpPost]
public async Task<IActionResult> Register([FromBody] CreateCompletionViewModel model)
{
if (!ModelState.IsValid) return BadRequest(ModelState);


var ok = await _service.RegisterCompletionAsync(model);
if (!ok) return NotFound("Enrollment not found");


return Ok(new { message = "Completion registered" });
}


[HttpPost("process-expired")]
public async Task<IActionResult> ProcessExpired()
{
var count = await _service.ProcessExpiredTrainingsAsync();
return Ok(new { processed = count });
}
}