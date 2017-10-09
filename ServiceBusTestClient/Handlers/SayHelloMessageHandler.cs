using ServiceBus;
using ServiceBusTestClient.Messages.Commands;
using ServiceBusTestClient.Messages.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceBusTestClient.Handlers
{
    public class SayHelloMessageHandler : IHandleMessages<SaidHelloEvent>
    {
        public SayHelloMessageHandler()
        {
        }

        public Task Handle(SaidHelloEvent message)
        {
            Console.WriteLine($"Starting SayHelloMessageHandler on thread id {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Hello {message.Name}");

            return Task.CompletedTask;
        }
    }
}