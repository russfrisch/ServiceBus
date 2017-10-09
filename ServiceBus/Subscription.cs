using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBus
{
    internal class Subscription<T> : ISubscription where T : class, IMessage
    {
        private readonly Action<T> _action;

        public Subscription(Action<T> action)
        {
            _action = action;
        }

        public void Notify(IMessage message)
        {
            _action.Invoke(message as T);
        }
    }
}
