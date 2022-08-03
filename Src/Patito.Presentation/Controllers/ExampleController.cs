using Microsoft.AspNetCore.Mvc;

namespace Patito.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{

    private readonly ILogger<ExampleController> _logger;

    public ExampleController(ILogger<ExampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        return Ok("Hi!!");
    }
}
