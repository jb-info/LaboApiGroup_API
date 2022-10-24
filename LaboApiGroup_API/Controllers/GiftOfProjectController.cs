using LaboApiGroup_API.Mapper;
using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftOfProjectController : ControllerBase
    {
        public readonly IGiftOfProjectService _giftofproject_service;

        public GiftOfProjectController(IGiftOfProjectService giftofprojectservice)
        {
            _giftofproject_service = giftofprojectservice;
        }

        [HttpGet("id")]

        public IActionResult Get(int id)
        {
            return Ok(_giftofproject_service.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_giftofproject_service.GetAll());
        }
        [HttpPost]
        public IActionResult Insert(GiftOfProject_C GiftOfProject)
        {
            return Ok(_giftofproject_service.Insert(GiftOfProject.ClientToGiftOfProjectBL()));
        }

        [HttpPut]
        public IActionResult Update(GiftOfProject_C GiftOfProject)
        {
            return Ok(_giftofproject_service.Update(GiftOfProject.ClientToGiftOfProjectBL()));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            GiftOfProject_C gop = new();
            gop.Id = id;
            return Ok(_giftofproject_service.Delete(gop.ClientToGiftOfProjectBL()));

        }
    }
}
