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

            var typeKey = typeof(T);
            var registryItem = new ExceptionRegistryItem(registry.GetType(), typeKey);

            _provider.Push(typeKey, registryItem);
        }

        public static void Clear()
        {
        }

        public static void Get(Exception finalException)
        {
            ExceptionRegistryItem res = _provider.GetExceptionRegistryItem(finalException.GetType());


            /*var type = Type.GetType(res.Registry.AssemblyQualifiedName);
            var myObject = (ExceptionRerouterRegistry<Exception>)Activator.CreateInstance(type);*/

            var d1 = Type.GetType(res.Registry.AssemblyQualifiedName); // GenericTest was my namespace, add yours
            Type[] typeArgs = { typeof(Item) };
            var makeme = d1.MakeGenericType(typeArgs);
            object o = Activator.CreateInstance(makeme);

            //var res2 = Activator.CreateInstance(typeof(T));
        }
    }
}