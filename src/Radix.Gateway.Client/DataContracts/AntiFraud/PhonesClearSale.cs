using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "")]
    public class PhonesClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public int Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int CountryCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int AreaCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Number { get; set; }
    }
}
