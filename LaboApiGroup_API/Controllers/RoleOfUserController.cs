using LaboApiGroup_API.Mapper;
using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleOfUserController:ControllerBase
    {
        private readonly IRoleOfUserService _RoleOfUser_service;

        public RoleOfUserController(IRoleOfUserService roleofuserservice)
        {
            _RoleOfUser_service = roleofuserservice;

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return Ok(_RoleOfUser_service.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_RoleOfUser_service.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(RoleOfUser_C RoleOfUser)
        {
            return Ok(_RoleOfUser_service.Insert(RoleOfUser.ClientToRoleOfUserBL()));
        }

        [HttpPut]
        public IActionResult Update(RoleOfUser_C RoleOfUser)
        {
            return Ok(_RoleOfUser_service.Update(RoleOfUser.ClientToRoleOfUserBL()));
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            RoleOfUser_C rou = new();
            rou.Id = id;
            return Ok(_RoleOfUser_service.Delete(rou.ClientToRoleOfUserBL()));
        }

    }
}
