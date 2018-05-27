using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.Cielo.CreditCard
{
    [DataContract(Namespace = "")]
    public class CreditCardTransactionCielo : BaseResponse
    {
        [DataMember(EmitDefaultValue = false)]
        public string MerchantOrderId { get; set; }

        [DataMember]
        public PaymentCielo Payment { get; set; }
    }
}
