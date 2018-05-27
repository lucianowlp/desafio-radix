using Radix.Gateway.Client.DataContracts.AntiFraud;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.CreditCard
{
    [DataContract(Namespace = "")]
    public partial class CreditCardTransaction : BaseResponse
    {
        [DataMember(EmitDefaultValue = false)]
        public string MerchantOrderId { get; set; }

        [DataMember]
        public Payment Payment { get; set; }

        [DataMember]
        public AntiFraudClearSale AntiFraud { get; set; }
    }
}
