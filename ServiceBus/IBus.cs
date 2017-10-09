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
        void Subscribe<T>(Action<T> handler) where T : class, IMessage;
    }
}
