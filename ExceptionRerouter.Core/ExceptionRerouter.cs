using System;
using System.Web;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Core.RegistryStore;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouter
    {
        public static void Reset()
        {
            ExceptionRegistrations.Clear();
        }

        // Register
        public static void Register<T>(ExceptionRerouterRegistry<T> registry) where T : Exception
        {
            if (registry == null)
                throw new NullReferenceException(nameof(registry));

            ExceptionRegistrations.Add(registry);
        }

        // Handle
        public static void HandleException(HttpApplication application)
        {
        }
    }
}