using Radix.Gateway.Client.EnumTypes;
using Radix.Gateway.Resource;
using System.Runtime.Serialization;

namespace Radix.Gateway.Client.DataContracts
{
    [DataContract(Name = "NotificationMessage", Namespace = "")]
    public class NotificationMessage
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Detail { get; set; }

        [IgnoreDataMember]
        public NotificationType Type { get; set; }

        [DataMember]
        public string TypeMessage { get; set; }

        [DataMember]
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
