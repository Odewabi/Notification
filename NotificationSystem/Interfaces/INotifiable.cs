public interface INotifiable
{
    string NotificationChannel { get; }
    void ReceiveNotification(string message);
}
