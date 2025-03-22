using System;

public class SMSNotification : INotifiable
{
    public string NotificationChannel { get; } = "SMS";
    public string PhoneNumber { get; set; }

    public SMSNotification(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void ReceiveNotification(string message)
    {
        Console.WriteLine("-------------");
        Console.WriteLine($"SMS NOTIFICATION");
        Console.WriteLine($"To: {PhoneNumber}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Time: {DateTime.Now}");
        Console.WriteLine("-------------");
    }
}
