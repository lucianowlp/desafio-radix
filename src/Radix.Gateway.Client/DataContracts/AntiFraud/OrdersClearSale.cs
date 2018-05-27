using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "", Name = "Orders")]
    public class OrdersClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int TotalItems { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int TotalOrder { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int TotalShipping { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string IP { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Currency { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Collection<PaymentsClearSale> Payments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public BillingDataClearSale BillingData { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ShippingDataClearSale ShippingData { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Collection<ItemsClearSale> Items { get; set; }
    }
}