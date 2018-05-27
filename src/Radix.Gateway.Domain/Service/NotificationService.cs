using Radix.Gateway.Domain.EnumTypes;
using System;
using System.Collections.Generic;

namespace Radix.Gateway.Domain.Service
{
    public class NotificationService
    {
        public List<NotificationMessage> Messages { get; set; }

        public NotificationService()
        {
            Messages = new List<NotificationMessage>();
        }

        protected void AddNotification(String message, NotificationType notificationType)
        {
            Messages.Add(new NotificationMessage(message, notificationType));
        }
    }
}
