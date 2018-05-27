using System.Runtime.Serialization;

namespace Radix.Gateway.Client.EnumTypes
{
    /// <summary>
    /// Status dos pagamentos
    /// </summary>
    [DataContract]
    public enum PaymentStatusType
    {
        /// <summary>
        /// Autorizado
        /// </summary>
        [EnumMember]
        Authorized = 1,

        /// <susmmary>
        /// Não autorizado
        /// </summary>
        [EnumMember]
        NotAuthorized = 2,
    }
}
