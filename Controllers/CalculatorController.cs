using LambdaBot.Clients;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace LambdaBot.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    // GET calculator/add/4/2/
    [HttpGet("add/{x}/{y}")]
    public int Add(int x, int y)
    {
        _logger.LogInformation($"{x} plus {y} is {x + y}");
        return x + y;
    }

    // GET calculator/substract/4/2/
    [HttpGet("subtract/{x}/{y}")]
    public int Subtract(int x, int y)
    {
        _logger.LogInformation($"{x} subtract {y} is {x - y}");
        return x - y;
    }

    // GET calculator/multiply/4/2/
    [HttpGet("multiply/{x}/{y}")]
    public int Multiply(int x, int y)
    {
        _logger.LogInformation($"{x} multiply {y} is {x * y}");
        return x * y;
    }

    // GET calculator/divide/4/2/
    [HttpGet("divide/{x}/{y}")]
    public int Divide(int x, int y)
    {
        _logger.LogInformation($"{x} divide {y} is {x / y}");
        return x / y;
    }

    [ApiController]
    [Route("api/[controller]")]
    public class BotController : ControllerBase
    {
        private readonly IUpdateService _updateService;

        public BotController(IUpdateService updateService)
        {
            _updateService = updateService;
        }

        [HttpPost]
        public async Task<IActionResult> HandleUpdate([FromBody] Update update, CancellationToken cancellationToken = default)
        {
            await _updateService.HandleUpdate(update, cancellationToken);
            return Ok();
        }
    }
}
