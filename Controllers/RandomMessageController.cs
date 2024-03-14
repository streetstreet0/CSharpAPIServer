using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CSharpAPIServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomMessageController : ControllerBase
    {
        private readonly ILogger<RandomMessageController> _logger;

        public RandomMessageController(ILogger<RandomMessageController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRandomMessage")]
        public IActionResult Get()
        {
            int minLength = 8;
            int maxLength = 16;

            RandomMessage message = RandomMessage.generateRandomMessage(minLength, maxLength);

            return Ok(message);
        }
    }
}