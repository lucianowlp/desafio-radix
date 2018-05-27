using System;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "")]
    public class PaymentsClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CardHolderName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CardExpirationDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int PaymentTypeID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int CardType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CardBin { get; set; }
    }
}
