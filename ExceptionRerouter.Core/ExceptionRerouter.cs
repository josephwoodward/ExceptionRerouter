using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouter
    {
        public static ExceptionRoutes RegisteredRoutes = new ExceptionRoutes();

        public static void Register(ExceptionRerouterRegistry registry)
        {
            if (registry == null)
            {
                throw new NullReferenceException("registry");
            }

            if (RegisteredRoutes.Routes.Contains(registry))
            {
                return;
            }

            RegisteredRoutes.Add(registry);
        }

        public static IEnumerable<ExceptionRerouterRegistry> Routes => RegisteredRoutes.Routes;

        public static void HandleException(Exception getLastError)
        {
        }
    }
}