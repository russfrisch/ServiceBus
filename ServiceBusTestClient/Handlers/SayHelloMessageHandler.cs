using ServiceBus;
using ServiceBusTestClient.Messages.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusTestClient.Handlers
{
    public class SayHelloMessageHandler : IHandleMessages<SayHelloCommand>
    {
        public SayHelloMessageHandler()
        {
        }

        public Task Handle(SayHelloCommand message)
        {
            Console.WriteLine($"Hello {message.Name}");
            return Task.CompletedTask;
        }
    }
}