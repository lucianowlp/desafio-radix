using Radix.Gateway.Domain.EnumTypes;
using Radix.Gateway.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Radix.Gateway.WebApi.Utility
{
    public static class NotificationExtensions
    {
        public static Boolean HasErrors(this List<NotificationMessage> messages)
        {
            return messages.Count(m => m.Type == NotificationType.Error) > 0;
        }
    }
}
