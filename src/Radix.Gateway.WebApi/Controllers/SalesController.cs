using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Radix.Gateway.Client.DataContracts.Cielo.CreditCard;
using Radix.Gateway.Client.DataContracts.CreditCard;
using Radix.Gateway.Domain;
using Radix.Gateway.WebApi.Service;

namespace Radix.Gateway.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Sales")]
    public class SalesController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IUserRepository userRepository;

        public SalesController(IConfiguration configuration, IUserRepository userRepository)
        {
            this.configuration = configuration;
            this.userRepository = userRepository;
        }

        // POST: api/Sales
        [HttpPost]
        public IActionResult Post([FromBody]CreditCardTransaction creditCardTransaction)
        {
            var radixMerchantKey = Request.Headers["merchantkey"];
            var user = userRepository.FindByMerchantKey(radixMerchantKey);

            var acquirerConfig = new AcquirerConfiguration(configuration).FindAcquirerConfig(user);

            var data = (CreditCardTransactionCielo)creditCardTransaction;
            var response = APIService.GetApi(acquirerConfig.urlApi, data, acquirerConfig.headers);

            return Ok(new
            {
                success = true,
                data = response
            });
        }
    }
}
