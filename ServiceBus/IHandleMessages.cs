using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus
{
    public interface IHandleMessages<T>
    {
        void Handle(T message);
    }
}
