using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "", Name = "Address")]
    public class AddressClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public string Street { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string City { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Comp { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Country { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Number { get; set; }
    }
}
