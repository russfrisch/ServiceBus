using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus
{
    internal interface ISubscription
    {
        Task NotifyAsync(IMessage message);
    }
}
