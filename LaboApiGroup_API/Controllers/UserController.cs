using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_API.Mapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
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

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] Users_C u)
        {
            return Ok(_userService.Insert(u.ClientToUserBL()));
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
