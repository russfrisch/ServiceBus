using ServiceBus;
using ServiceBusTestClient.Messages.Commands;
using System;

namespace ServiceBusTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new Bus();
            bus.Send(new SayHelloCommand() { Name = "Russ" }).Wait();


            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
