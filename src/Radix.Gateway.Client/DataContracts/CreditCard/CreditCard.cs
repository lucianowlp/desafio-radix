using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts.CreditCard
{
    [DataContract(Namespace = "")]
    public class CreditCard
    {
        /// <summary>
        /// Número do cartão de crédito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Nome impresso no cartão
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string PrintedName { get; set; }

        /// <summary>
        /// Mês de expiração do cartão de crédito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int ExpMonth { get; set; }

        /// <summary>
        /// Ano de expiração do cartão de crédito
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int ExpYear { get; set; }

        /// <summary>
        /// Código de segurança - CVV
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string SecurityCode { get; set; }


    }
}
