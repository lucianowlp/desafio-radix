using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.CreditCard
{
    [DataContract(Namespace = "")]
    public class CreditCardTransaction : BaseResponse
    {
        [DataMember]
        public Payment Payment { get; set; }
    }
}
