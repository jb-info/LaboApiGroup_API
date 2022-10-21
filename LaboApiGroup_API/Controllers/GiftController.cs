using LaboApiGroup_API.Mapper;
using LaboApiGroup_API.Models;
using LaboApiGroup_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaboApiGroup_API.Controllers
{
    public class GiftController: ControllerBase
    {
        private readonly IGiftService  _gift_service;

        public GiftController(IGiftService giftservice)
        {
            _gift_service = giftservice;

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
     
            return Ok(_gift_service.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_gift_service.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Gift_C Gift)
        {
            return Ok(_gift_service.Insert(Gift.ClientToGiftBl()));
        }

        [HttpPut]
        public IActionResult Update(Gift_C Gift)
        {
            return Ok(_gift_service.Update(Gift.ClientToGiftBl()));
        }

        

    }
    
        

}