using System;
using System.Collections.Generic;
using ExceptionRerouter.Core.Registry;

namespace ExceptionRerouter.Core.Store
{
    /// <summary>
    /// Store for all registrations
    /// </summary>
    public static class ExceptionRegistrations
    {
        internal static readonly IList<ExceptionRerouterRegistry> RegisteredRoutes = new List<ExceptionRerouterRegistry>();

        public static IEnumerable<ExceptionRerouterRegistry> Routes = RegisteredRoutes;

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