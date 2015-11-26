using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using ExceptionRerouter.Core.RegistryItem;

namespace ExceptionRerouter.Core.Provider
{
    // Inspired by https://github.com/khalidabuhakmeh/MvcFlash because Khalid is awesome
    public class StaticRegistryService : IRegistryProvider
    {
        private readonly object _lock = new object();

        private IDictionary<Type, ExceptionRegistryItem> Messages { get; set; }

        public void Push(Type key, ExceptionRegistryItem registry)
        {
            lock (_lock)
            {
                Messages = new ConcurrentDictionary<Type, ExceptionRegistryItem>();

                if (Messages.ContainsKey(key))
                {
                    Messages[key] = registry;
                }
                else
                {
                    Messages.Add(key, registry);
                }
            }
        }

        public ExceptionRegistryItem Pop()
        {
            throw new NotImplementedException();
        }

        public ExceptionRegistryItem GetExceptionRegistryItem(Type type)
        {
            return Messages.First(x => x.Key == type).Value;
        }

        public ICollection<ExceptionRegistryItem> Select(Func<Type, bool> where)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return Messages.Count;
        }

        public void Clear()
        {
            Messages.Clear();
        }
    }
}