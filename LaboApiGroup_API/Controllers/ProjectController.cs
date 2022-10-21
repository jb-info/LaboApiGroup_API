using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Models;
using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_API.Mapper;

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_projectService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_projectService.GetAll());
        }      

        [HttpPost]
        public IActionResult Insert(Project_C project)
        {            
            return Ok(_projectService.Insert(project.ClientToProjectBL()));
        }

        [HttpPut]
        public IActionResult Update(Project_C project)
        {
            return Ok(_projectService.Update(project.ClientToProjectBL()));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Project_C p = new();
            p.Id = id;
            return Ok(_projectService.Delete(p.ClientToProjectBL()));
        }
    }
}
