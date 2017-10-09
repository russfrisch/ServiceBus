using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus
{

    public class Bus : IBus
    {
        private IEnumerable<ICommand> Commands { get; set; }
        private IEnumerable<IHandleMessages<ICommand>> CommandHandlers { get; set; }
        private Dictionary<Type, IList<Action<ICommand>>> CommandSubscriptions { get; set; }

        public Bus()
        {
            Console.WriteLine("Initialzing Service Bus...");

            Console.WriteLine("Loading Commands...");
            Commands = FindCommands();
            Console.WriteLine($"Found {Commands.Count()} Commands.");

            Console.WriteLine("Loading Command Handlers...");
            CommandHandlers = FindCommandHandlers();
            Console.WriteLine($"Found {CommandHandlers.Count()} Command Handlers.");
        }

        public void Subscribe(Type messageType, Action<ICommand> handler)
        {
            CommandSubscriptions[messageType].Add(handler);
        }

        public Task PublishAsync(IEvent message)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(ICommand message)
        {
            var handlers = CommandSubscriptions[message.GetType()];
            foreach (var handler in handlers)
            {
                handler.Invoke(message);
            }
            return Task.CompletedTask;
        }

        private IEnumerable<ICommand> FindCommands()
        {
            return from assembly in AppDomain.CurrentDomain.GetAssemblies()
                            from t in assembly.GetTypes()
                            where t.GetInterfaces().Contains(typeof(ICommand))
                            select t as ICommand;
        }

        private IEnumerable<IHandleMessages<ICommand>> FindCommandHandlers()
        {
            return from assembly in AppDomain.CurrentDomain.GetAssemblies()
                            from t in assembly.GetTypes()
                            where t.GetInterfaces().Contains(typeof(IHandleMessages<ICommand>))
                            select t as IHandleMessages<ICommand>;
        }
    }
}
