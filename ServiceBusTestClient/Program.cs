using ServiceBus;
using ServiceBusTestClient.Handlers;
using ServiceBusTestClient.Messages.Commands;
using System;

namespace ServiceBusTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new Bus();
            bus.Subscribe(typeof(SayHelloCommand), new Action(new SayHelloMessageHandler().Handle)); 
            bus.SendAsync(new SayHelloCommand() { Name = "Russ" }).Wait();


            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
