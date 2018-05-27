using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "", Name = "ShippingData")]
    public class ShippingDataClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Gender { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime BirthDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public AddressClearSale Address { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Collection<PhonesClearSale> Phones { get; set; }
    }
}
