using System.Runtime.Serialization;

namespace Radix.Gateway.Client.EnumTypes
{
    /// <summary>
    /// Tipo de operação de cartão de crédito
    /// </summary>
    [DataContract]
    public enum PaymentOperationType
    {
        /// <summary>
        /// Somente autorizar
        /// </summary>
        [EnumMember]
        AuthOnly = 1,

        /// <summary>
        /// Autorizar e capturar
        /// </summary>
        [EnumMember]
        AuthAndCapture = 2,
    }
}
