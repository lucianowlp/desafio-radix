using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "")]
    public class ItemsClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public int ProductId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ProductTitle { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double Price { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Category { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int Quantity { get; set; }
    }
}
