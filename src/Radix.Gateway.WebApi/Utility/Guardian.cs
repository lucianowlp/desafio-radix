using System;

namespace Radix.Gateway.WebApi.Utility
{
    public class Guardian
    {
        public static void AgainstNull(object param, string name = null)
        {
            if (param == null)
            {
                throw new ArgumentNullException(name ?? "O argumento é nulo.");
            }
        }
    }
}
