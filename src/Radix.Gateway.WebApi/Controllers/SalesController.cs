using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Radix.Gateway.Client.DataContracts.Cielo.CreditCard;
using Radix.Gateway.Client.DataContracts.CreditCard;
using Radix.Gateway.Domain;
using Radix.Gateway.Domain.EnumTypes;
using Radix.Gateway.Domain.Service;
using Radix.Gateway.Resource;
using Radix.Gateway.WebApi.Service;
using Radix.Gateway.WebApi.Utility;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radix.Gateway.WebApi.Controllers
{
    /// <summary>
    /// Serviço responsável pelas transações com cartão de crédito
    /// Todas as transações podem ou não ter o serviço de antifraude habilitado, definido no cadastro do lojista.
    /// </summary>
    [Produces("application/json")]
    [Route("api/Sales")]
    public class SalesController : Controller
    {
        #region Constants
        private const string MERCHANT_KEY = "merchantkey";
        #endregion constants

        private readonly IConfiguration configuration;
        private readonly IUserRepository userRepository;
        public List<NotificationMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="userRepository"></param>
        public SalesController(IConfiguration configuration, IUserRepository userRepository)
        {
            Guardian.AgainstNull(configuration);
            Guardian.AgainstNull(userRepository);
            this.configuration = configuration;
            this.userRepository = userRepository;

            Messages = new List<NotificationMessage>();
        }

        // POST: api/Sales
        /// <summary>
        /// Realiza uma transação com cartão de crédito
        /// </summary>
        /// <param name="creditCardTransaction"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]CreditCardTransaction creditCardTransaction)
        {
            var radixMerchantKey = Request.Headers[MERCHANT_KEY];
            var user = userRepository.FindByMerchantKey(radixMerchantKey);
            Task<string> response = Task.FromResult(string.Empty);

            if (user == null)
            {
                Messages.Add(new NotificationMessage(SalesResource.MerchantKeyInvalid, NotificationType.Error));
            }

            if (!Messages.HasErrors())
            {
                if (user != null && user.AntiFraudSystem)
                {
                    if (creditCardTransaction.AntiFraud == null)
                    {
                        Messages.Add(new NotificationMessage(SalesResource.AndiFraudNull, NotificationType.Error));
                    }
                    else
                    {
                        var antiFraudSystem = new AntiFraudAPIService();
                        if (!antiFraudSystem.IsApproved(creditCardTransaction.AntiFraud))
                        {
                            Messages.Add(new NotificationMessage(SalesResource.TransactionDenied, NotificationType.Error));
                        }
                    }
                }
            }

            if (!Messages.HasErrors())
            {
                response = SendSale(creditCardTransaction, user);

                return Ok(new
                {
                    success = true,
                    data = response
                });
            }

            return BadRequest(new
            {
                success = true,
                data = Messages
            });
        }

        private Task<string> SendSale(CreditCardTransaction creditCardTransaction, User user)
        {
            var acquirerConfig = new AcquirerConfiguration(configuration).FindAcquirerConfig(user);
            var data = (CreditCardTransactionCielo)creditCardTransaction;
            var response = APIService.GetApi(acquirerConfig.urlApi, data, acquirerConfig.headers);
            return response;
        }
    }
}
