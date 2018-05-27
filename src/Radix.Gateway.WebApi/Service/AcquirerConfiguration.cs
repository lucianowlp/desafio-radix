using Microsoft.Extensions.Configuration;
using Radix.Gateway.Domain;
using System.Collections.Generic;

namespace Radix.Gateway.WebApi.Service
{
    public class AcquirerConfiguration
    {
        #region Constants
        private const string PURCHASERS = "Purchasers";
        private const string MERCHANT_ID = "MerchantId";
        private const string CIELO = "Cielo";
        private const string MERCHANT_KEY = "MerchantKey";
        private const string CONTENT_TYPE = "Content-Type";
        private const string END_POINTS = "EndPoints";
        private const string SANDBOX = "Sandbox";
        #endregion constants

        private readonly IConfiguration configuration;

        public AcquirerConfiguration(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public (string urlApi, Dictionary<string, string> headers) FindAcquirerConfig(User user)
        {
            var cielo = configuration.GetSection(PURCHASERS).GetSection(CIELO);
            var merchantid = cielo.GetValue<string>(MERCHANT_ID);
            var merchantkey = cielo.GetValue<string>(MERCHANT_KEY);
            var contentType = cielo.GetValue<string>(CONTENT_TYPE);
            var urlApi = cielo.GetSection(END_POINTS).GetValue<string>(SANDBOX);

            var headers = new Dictionary<string, string>();

            AddHeaders(headers, "merchantid", merchantid);
            AddHeaders(headers, "merchantkey", merchantkey);
            AddHeaders(headers, "Content-Type", contentType);

            return (urlApi, headers);
        }

        private void AddHeaders(Dictionary<string, string> headers, string key, string value)
        {
            if (value != null)
            {
                headers.Add(key, value);
            }
        }
    }
}
