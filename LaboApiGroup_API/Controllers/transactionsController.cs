using LaboApiGroup_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LaboApiGroup_BL.Models;
using LaboApiGroup_API.Models;
using LaboApiGroup_API.Mapper;

namespace LaboApiGroup_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly IGlobalInterfaces<int, Transactions_BLL> _global;

        public TransactionsController(IGlobalInterfaces<int, Transactions_BLL> global)
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
        public IActionResult Insert([FromBody]Transactions_C transaction)
        {
            return Ok(_global.Insert(transaction.transactions_BL()));
        }
        [HttpPut]
        public IActionResult Update([FromBody]Transactions_C transaction)
        {
            return Ok(_global.Update(transaction.transactions_BL()));
        }
    }
}
