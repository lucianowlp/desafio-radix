using Newtonsoft.Json;
using Radix.Gateway.Client.DataContracts.AntiFraud;
using System;
using System.Linq;
using System.Net;
using System.Text;

namespace Radix.Gateway.WebApi.Service
{
    public class AntiFraudAPIService
    {
        public bool IsApproved(AntiFraudClearSale data)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    var statusAntiFraud = string.Empty;

                    webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    webClient.Encoding = Encoding.UTF8;

                    var uri = new Uri("https://sandbox.clearsale.com.br/api/order/send");

                    var response = webClient.UploadStringTaskAsync(uri, WebRequestMethods.Http.Post, JsonConvert.SerializeObject(data));

                    //Cenário para testes.
                    //Somente pedidos com endereço de entrega para o pais do comprador são validados.
                    if (data.Orders.All(s => s.ShippingData.Address.Country == data.AnalysisLocation))
                    {
                        statusAntiFraud = "APA";
                    }
                    else
                    {
                        statusAntiFraud = "RPP";
                    }

                    return statusAntiFraud.Equals("APA");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
