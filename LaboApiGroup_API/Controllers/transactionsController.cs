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
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_transactionService.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_transactionService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert([FromBody]Transactions_C transaction)
        {
            return Ok(_transactionService.Insert(transaction.transactions_BL()));
        }
        [HttpPut]
        public IActionResult Update([FromBody]Transactions_C transaction)
        {
            return Ok(_transactionService.Update(transaction.transactions_BL()));
        }
    }
}
