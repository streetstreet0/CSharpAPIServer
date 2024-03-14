using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CSharpAPIServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginAuthentication : ControllerBase
    {
        private readonly ILogger<RandomMessageController> _logger;

        public LoginAuthentication(ILogger<RandomMessageController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetAuthenticationToken")]
        public IActionResult Post([FromBody] LoginAuthenticationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            LoginAuthenticator authentication = LoginAuthenticator.AuthenticateUser(request.Username, request.Password);

            return Ok(authentication);
        }
    }

    /**
     * Request to authenticate a user
     */
    public class LoginAuthenticationRequest
    {
        [JsonRequired] public String Username { get; set; }
        [JsonRequired] public String Password { get; set; }
    }
}