using System;
using System.Collections.Generic;
using ExceptionRerouter.Core.Registry;

namespace ExceptionRerouter.Core.RegistryStore
{
    public static class ExceptionRegistrations
    {

        public static void Add(ExceptionRerouterRegistry registry)
        {
            if (registry == null)
                throw new ArgumentNullException(nameof(registry));

            RegisteredRoutes.Add(registry);
        }

        public static void Clear()
        {
            RegisteredRoutes.Clear();
        }
    }
}