namespace SOLID.DIP
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email with message: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS with message: {message}");
        }
    }

}
