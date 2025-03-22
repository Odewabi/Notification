using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Notification System Demo ===");

        // Create notification receivers
        EmailNotification email = new EmailNotification("john@email.com");
        SMSNotification sms = new SMSNotification("+1234567890");

        // Create notification center
        NotificationCenter center = new NotificationCenter();

        // Subscribe to notifications
        center.Subscribe(email);
        center.Subscribe(sms);

        // Send notifications
        center.SendNotification("System maintenance scheduled for tomorrow");
        center.SendNotification("Update completed successfully");

        // Show notification log
        center.ShowLog();

        Console.WriteLine("=== End of Notification Demo ===");
    }
}
