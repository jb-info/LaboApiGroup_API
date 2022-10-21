using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_API.Models;
using LaboApiGroup_API.Mapper;

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_roleService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_roleService.GetAll());  
        }
        [HttpPost]
        public IActionResult Insert(Role_C role)
        {
            return Ok(_roleService.Insert(role.ClientToRoleBL()));
        }
        [HttpPut]
        public IActionResult Update(Role_C role) 
        {
            return Ok(_roleService.Update(role.ClientToRoleBL()));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Role_C r = new Role_C() { Id = id };

            return Ok(_roleService.Delete(r.ClientToRoleBL()));
        }
    }
}
