using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_API.Mapper;

namespace LaboApiGroup_API.Controllers
{
    public class ProjectController : ControllerBase
    {
        private readonly IGlobalInterfaces<int, Project_BLL> _global;

        public ProjectController(IGlobalInterfaces<int, Project_BLL> global)
        {
            _global = global;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_global.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_global.GetAll());
        }      

        [HttpPost]
        public IActionResult Insert(Project_C project)
        {            
            return Ok(_global.Insert(project.ClientToProjectBL()));
        }

        [HttpPut]
        public IActionResult Update(Project_C project)
        {
            return Ok(_global.Update(project.ClientToProjectBL()));
        }
    }
}
