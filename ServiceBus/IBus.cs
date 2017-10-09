using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus
{
    public interface IBus
    {
        Task SendAsync(ICommand message);
        Task PublishAsync(IEvent message);
    }
}
