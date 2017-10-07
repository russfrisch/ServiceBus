using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus
{
    public interface IBus
    {
        Task Send(ICommand message);
        Task Publish(IEvent message);
    }
}
