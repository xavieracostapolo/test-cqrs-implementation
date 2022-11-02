using System.Diagnostics;
using MediatR;

namespace Test.Cqrs.WebApi.Models.Notification;

public class Ping : INotification
{
    public int MyProperty { get; set; }
}

public class Pong1 : INotificationHandler<Ping>
{
    public Task Handle(Ping notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Pong 1 - {notification.MyProperty}");
        return Task.CompletedTask;
    }
}

public class Pong2 : INotificationHandler<Ping>
{
    public Task Handle(Ping notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Pong 2 - {notification.MyProperty}");
        return Task.CompletedTask;
    }
}