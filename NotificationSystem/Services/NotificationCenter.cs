using System;
using System.Collections.Generic;

public class NotificationCenter
{
    public event EventHandler<string> NotificationSent = delegate { };
    private List<INotifiable> _subscribers = new List<INotifiable>();
    private List<string> _log = new List<string>();

    public void Subscribe(INotifiable subscriber)
    {
        _subscribers.Add(subscriber);
        Console.WriteLine($"Added {subscriber.NotificationChannel} Subscriber");
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending Notification: \"{message}\"");
        foreach (var subscriber in _subscribers)
        {
            subscriber.ReceiveNotification(message);
            LogNotification(subscriber.NotificationChannel, message);
            NotificationSent?.Invoke(this, $"Notification sent via {subscriber.NotificationChannel}");
        }
    }

    private void LogNotification(string channel, string message)
    {
        string logEntry = $"{DateTime.Now:HH:mm:ss} - {channel} sent to {message}";
        _log.Add(logEntry);
    }

    public void ShowLog()
    {
        Console.WriteLine("\nNotification Log:");
        foreach (var log in _log)
        {
            Console.WriteLine(log);
        }
    }
}
