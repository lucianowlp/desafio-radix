using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.Cielo.CreditCard
{
    [DataContract(Namespace = "")]
    public class PaymentCielo
    {
        [DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int Installments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SoftDescriptor { get; set; }

        [DataMember]
        public CreditCardCielo CreditCard { get; set; }
    }
}
