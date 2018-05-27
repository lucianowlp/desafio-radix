using Radix.Gateway.Client.EnumTypes;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.CreditCard
{
    [DataContract(Namespace = "")]
    public class Payment
    {
        [DataMember(EmitDefaultValue = false)]
        public string PaymentId { get; set; }

        [DataMember]
        public PaymentOperationType Operation { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public int Installments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Descriptor { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ReceivedDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PaymentStatusType Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Country { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Currency { get; set; }

        [DataMember]
        public CreditCard CreditCard { get; set; }
    }
}
