using System;
using System.Collections.Concurrent;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Core.RegistryItem;

namespace ExceptionRerouter.Core.RegistryStore
{
    public static class ExceptionRegistrations
    {
        // Hide behind pusher/popper lazy collection
        private static readonly ConcurrentDictionary<Type, ExceptionRegistryItem> _registrations;

        public static void Add<T>(ExceptionRerouterRegistry<T> registry) where T : Exception
        {
            if (registry == null)
                throw new ArgumentNullException(nameof(registry));

            var typeKey = typeof(T);
            var registryItem = new ExceptionRegistryItem(registry, typeof(T));

            _registrations.TryAdd(typeKey, registryItem);
        }

        public static void Clear()
        {
            _registrations.Clear();
        }
    }
}