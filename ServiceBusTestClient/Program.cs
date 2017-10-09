using ServiceBus;
using ServiceBusTestClient.Handlers;
using ServiceBusTestClient.Messages.Commands;
using ServiceBusTestClient.Messages.Events;
using System;

namespace ServiceBusTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new Bus();
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.Subscribe<SaidHelloEvent>(new SayHelloMessageHandler().Handle);
            bus.PublishAsync(new SaidHelloEvent() { Name = "Russ" }).Wait();


            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
