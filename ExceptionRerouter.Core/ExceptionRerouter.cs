using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Core.Store;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouter
    {
        // Public collection of registrys
        public static IReadOnlyCollection<ExceptionRerouterRegistry> Routes = (IReadOnlyCollection<ExceptionRerouterRegistry>) ExceptionRegistrations.Routes;

        public static void Reset()
        {
            ExceptionRegistrations.Clear();
        }

        // Register
        public static void Register(ExceptionRerouterRegistry registry)
        {
            if (registry == null)
                throw new NullReferenceException(nameof(registry));

            if (ExceptionRegistrations.Routes.Any(x => x.GetType() == registry.GetType()))
                return;

            ExceptionRegistrations.Add(registry);
        }

        // Handle
        public static void HandleException(MvcApplication exception)
        {
            // Need to flesh out
            Type exceptionType = exception.GetType();
            ExceptionContext context = ExceptionTypes.RegisteredExceptions.FirstOrDefault(x => x.ExceptionType == exceptionType);
            if (context != null)
            {
                var handler = new ExceptionHandler(context);
                handler.Handle(exception);
            }
        }
    }
}