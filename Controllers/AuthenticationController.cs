using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Core.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FightDocManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILoginManager _loginManager;
        public IConfiguration _configuration;
        public AuthenticationController(IConfiguration configuration, ILoginManager loginManager)
        {
            _configuration = configuration;
            _loginManager = loginManager;
        }
       
        // GET: api/<AuthenticationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Authentication/login
        [HttpPost("login")]
        public async Task<IActionResult> LogIn([FromBody] LoginDTO login)
        {
            try
            {
                if (await _loginManager.LoginAsync(login.Email, login.Password))
                {
                    var token = new JwtSecurityToken(
                        expires: DateTime.UtcNow.AddMinutes(60));                    
                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
                }
                return BadRequest(new
                {
                    message = "Username or password incorrect"
                });
            }
            catch
            {
                return BadRequest(new
                {
                    message = "Username or password incorrect"
                });
            }
        }

        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
