namespace SOLID.DIP
{
    public class NotificationSender
    {
        private readonly INotificationService _notificationService;

        public NotificationSender(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification(string message)
        {
            _notificationService.Send(message);
        }
    }

}
