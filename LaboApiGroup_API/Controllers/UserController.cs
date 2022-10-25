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

        [HttpPost]
        [Route("SwitchUserStatus")]
        public IActionResult SwitchStatus([FromBody] SwitchUser su)
        {
            return Ok(_userService.SwitchStatus(su.SwtichUserToBll()));
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult GetAll()
        {
            if (_userService.GetAll() == null) return BadRequest("Empty");
            return Ok(_userService.GetAll());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Users_C c = _userService.Get(id).ToClient();
            if (c is null) return BadRequest("Empty");
            else
                return Ok(c);
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
            if (u is null || !ModelState.IsValid) return BadRequest();
            else
                return Ok(_userService.Insert(u.ToBll()));
        }



        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_userService.Delete(new Users_BLL() { Id = id })) return new ForbidResult();
            else 
                return Ok();
        }
    }
}
