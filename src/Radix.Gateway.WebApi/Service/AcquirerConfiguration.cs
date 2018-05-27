using Microsoft.Extensions.Configuration;
using Radix.Gateway.Domain;
using System.Collections.Generic;

namespace Radix.Gateway.WebApi.Service
{
    public class AcquirerConfiguration
    {
        private readonly IConfiguration configuration;

        public AcquirerConfiguration(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public (string urlApi, Dictionary<string, string> headers) FindAcquirerConfig(User user)
        {
            var cielo = configuration.GetSection("Purchasers").GetSection("Cielo");
            var merchantid = cielo.GetValue<string>("MerchantId");
            var merchantkey = cielo.GetValue<string>("MerchantKey");
            var contentType = cielo.GetValue<string>("Content-Type");

            var urlApi = cielo.GetSection("EndPoints").GetValue<string>("Sandbox");
            var headers = new Dictionary<string, string>();
            headers.Add("merchantid", merchantid);
            headers.Add("merchantkey", merchantkey);
            headers.Add("Content-Type", contentType);

            return (urlApi, headers);
        }
    }
}
