using Microsoft.AspNetCore.Mvc;
using Patito.Application.Services.Abstractions;

namespace Patito.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{

    private readonly ILogger<ExampleController> _logger;
    private readonly IExampleHelloWorldService _helloWorldService;

    public ExampleController(ILogger<ExampleController> logger, IExampleHelloWorldService helloWorldService)
    {
        _logger = logger;
        _helloWorldService = helloWorldService;
    }

    [HttpGet(Name = "GetExample")]
    public async Task<IActionResult> GetHelloWorld()
    {
        return this.Ok(await _helloWorldService.GetHelloWorldServiceExample());
    }
}
