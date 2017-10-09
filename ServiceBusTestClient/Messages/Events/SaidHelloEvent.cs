using ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBusTestClient.Messages.Events
{
    public class SaidHelloEvent : IEvent
    {
        public string Name { get; internal set; }
    }
}
