using System;
using ExceptionRerouter.Core.Provider;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Core.RegistryItem;

namespace ExceptionRerouter.Core.RegistryStore
{
    public static class ExceptionRegistrations
    {
        private static readonly IRegistryProvider _provider = new StaticRegistryService();

        public static void Add<T>(ExceptionRerouterRegistry<T> registry) where T : Exception
        {
            if (registry == null)
                throw new ArgumentNullException(nameof(registry));

            var typeKey = typeof (T);
            var registryItem = new ExceptionRegistryItem(registry, typeKey);

            //_registrations.TryAdd(typeKey, registryItem);
            _provider.Push(typeKey, registryItem);
        }

        public static void Clear()
        {
        }

        public static void Get(Exception finalException)
        {
            ExceptionRegistryItem res = _provider.GetExceptionRegistryItem(finalException.GetType());

            object res2 = res.Registry;
        }
    }
}