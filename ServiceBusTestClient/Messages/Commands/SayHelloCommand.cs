using ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBusTestClient.Messages.Commands
{
    public class SayHelloCommand : ICommand
    {
        public string Name { get; internal set; }
    }
}
