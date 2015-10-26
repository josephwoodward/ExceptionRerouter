using System;
using System.Collections.Generic;
using System.Linq;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Core.Store;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouter
    {
        // Routes encapsulated collection

        // Public collection of registrys
        public static IEnumerable<ExceptionRerouterRegistry> Routes = ExceptionRegistrations.Routes;

        public static void Reset()
        {
            ExceptionRegistrations.Clear();
        }

        // Register
        public static void Register(ExceptionRerouterRegistry registry)
        {
            if (registry == null)
            {
                throw new NullReferenceException("registry");
            }

            if (ExceptionRegistrations.Routes.Any(x => x.GetType() == registry.GetType()))
            {
                return;
            }

            ExceptionRegistrations.Add(registry);
        }

        // Handle
        public static void HandleException(Exception getLastError)
        {
            // Need to flesh out
            Type exceptionType = getLastError.GetType();
            ExceptionContext context = ExceptionTypes.RegisteredExceptions.FirstOrDefault(x => x.ExceptionType == exceptionType);
            if (context != null)
            {
                // Execute redirect
            }
        }
    }
}