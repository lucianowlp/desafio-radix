using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.Cielo.CreditCard
{
    [DataContract(Namespace = "")]
    public class CreditCardCielo
    {
        /// <summary>
        /// Número do cartão de crédito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Nome completo escrito no cartão de crédito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Holder { get; set; }

        /// <summary>
        /// Data de expiração - MM/YYYY
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Código de segurança - CVV
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Bandeira do cartão de crédito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Brand { get; set; }
    }
}
