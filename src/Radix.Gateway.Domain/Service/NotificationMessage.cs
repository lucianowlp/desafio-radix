using Radix.Gateway.Domain.EnumTypes;
using Radix.Gateway.Resource;

namespace Radix.Gateway.Domain.Service
{
    public class NotificationMessage
    {
        public string Message { get; set; }
        public string Detail { get; set; }
        public NotificationType Type { get; set; }
        public string TypeMessage { get; set; }
        public int ErrorLevel { get; set; }
        public NotificationMessage() { }

        public NotificationMessage(string message, NotificationType type)
        {
            Message = message;
            Type = type;
            ErrorLevel = (int)type;
            AssignTypeMessage(type);
        }

        private void AssignTypeMessage(NotificationType type)
        {
            switch (type)
            {
                case NotificationType.Error:
                    TypeMessage = NotificationMessageResource.Error;
                    break;
                case NotificationType.Warning:
                    TypeMessage = NotificationMessageResource.Warning;
                    break;
                case NotificationType.Message:
                    TypeMessage = NotificationMessageResource.Message;
                    break;
                default:
                    break;
            }
        }
    }
}
