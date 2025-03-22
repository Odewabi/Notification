using System;

public class EmailNotification : INotifiable
{
    public string NotificationChannel { get; } = "Email";
    public string EmailAddress { get; set; }

    public EmailNotification(string emailAddress)
    {
        EmailAddress = emailAddress;
    }

    public void ReceiveNotification(string message)
    {
        Console.WriteLine("-------------");
        Console.WriteLine($"EMAIL NOTIFICATION");
        Console.WriteLine($"To: {EmailAddress}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Time: {DateTime.Now}");
        Console.WriteLine("-------------");
    }
}
