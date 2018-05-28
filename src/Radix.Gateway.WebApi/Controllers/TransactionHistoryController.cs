using Microsoft.AspNetCore.Mvc;
using Radix.Gateway.Domain.Repository;
using System.Linq;

namespace Radix.Gateway.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/TransactionHistory")]
    public class TransactionHistoryController : Controller
    {
        private ITransactionHistoryRepository transactionHistoryRepository;

        public TransactionHistoryController(ITransactionHistoryRepository transactionHistoryRepository)
        {
            this.transactionHistoryRepository = transactionHistoryRepository;
        }

        // GET: api/TransactionHistory/7FA24257-587D-4709-9179-6E81B004E9C4
        [HttpGet("{MerchantKey}", Name = "Get")]
        public IActionResult Get(string merchantkey)
        {
            var transactionHistory = transactionHistoryRepository.FindAll().Where(w => w.MerchantKey == merchantkey);

            return Ok(new
            {
                success = true,
                data = transactionHistory
            });
        }
    }
}
