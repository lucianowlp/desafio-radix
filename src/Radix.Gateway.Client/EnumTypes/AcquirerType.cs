using System.Runtime.Serialization;

namespace Radix.Gateway.Client.EnumTypes
{
    /// <summary>
    /// Adquirentes implementados
    /// </summary>
    public enum AcquirerType
    {
        /// <summary>
        /// Somente autorizar
        /// </summary>
        [EnumMember]
        Stone = 1,

        /// <summary>
        /// Autorizar e capturar
        /// </summary>
        [EnumMember]
        Cielo = 2,
    }
}
