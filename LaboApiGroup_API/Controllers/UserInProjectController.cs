using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Services;
using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_API.Mapper;

namespace LaboApiGroup_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserInProjectController : ControllerBase
    {
        private readonly UserInProject_Service _userInProjectService;

        public UserInProjectController(UserInProject_Service userInProjectService)
        {
            _userInProjectService = userInProjectService;
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userInProjectService.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userInProjectService.GetAll());
        }
        [HttpPost]
        public IActionResult Insert(UserInProject_C userInProject)
        {
            return Ok(_userInProjectService.Insert(userInProject.ToBLL()));
        }

        [HttpPut]
        public IActionResult Update(UserInProject_C userInProject)
        {
            return Ok(_userInProjectService.Update(userInProject.ToBLL()));
        }
    }
}
