using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts
{
    [DataContract(Namespace = "")]
    public abstract class BaseResponse
    {
        /// <summary>
        /// Colecao de mensagens de erros
        /// </summary>
        [DataMember]
        public Collection<NotificationMessage> NotificationMessageCollection { get; set; }

        /// <summary>
        /// Chave da loja, utilizada para identificar a loja dentro da API
        /// </summary>
        [DataMember]
        public Guid MerchantKey { get; set; }
    }
}
