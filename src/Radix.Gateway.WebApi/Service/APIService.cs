using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Radix.Gateway.WebApi.Service
{
    public class APIService
    {
        public static async Task<string> GetApi(String urlApi, Object data, IDictionary<string, string> headers)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    foreach (var item in headers)
                    {
                        webClient.Headers[item.Key] = item.Value;
                    }
                    webClient.Encoding = Encoding.UTF8;
                    var uri = new Uri($"{urlApi}/1/sales");

                    var response = await webClient.UploadStringTaskAsync(uri, WebRequestMethods.Http.Post,
                        JsonConvert.SerializeObject(data));

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
