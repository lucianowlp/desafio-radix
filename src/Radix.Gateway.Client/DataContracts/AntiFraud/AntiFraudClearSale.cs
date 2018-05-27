using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.AntiFraud
{
    [DataContract(Namespace = "", Name = "AntiFraud")]
    public class AntiFraudClearSale
    {
        [DataMember(EmitDefaultValue = false)]
        public string ApiKey { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LoginToken { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AnalysisLocation { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Reanalysis { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Collection<OrdersClearSale> Orders { get; set; }
    }
}
