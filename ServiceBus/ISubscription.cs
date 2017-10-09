using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBus
{
    internal interface ISubscription
    {
        void Notify(IMessage message);
    }
}
