using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_API.Mapper;
using LaboApiGroup_BL.Models;
using LaboApiGroup_API.JwtToken;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtTokenManager _TokenManager;

        public UserController(IUserService userService, JwtTokenManager jwtTokenManager)
        {
            _userService = userService;
            _TokenManager = jwtTokenManager;
        }


        // GET: api/<UserController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_userService.Get(id));
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] Login_User u)
        {
            if (u is null || !ModelState.IsValid)
                return BadRequest();

            var userApp = _userService.Login(u.LoginToBll());

            if (userApp is null)
                return new ForbidResult();

            // Generate Token
            return Ok(new UserWithToken
            {
                Guid    = userApp.Id,
                IsAdmin = userApp.IsAdmin,
                Token   = _TokenManager.GenerateToken(userApp.ToClient())
            });
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] Users_C u)
        {
            return Ok(_userService.Insert(u.ToBll()));
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
