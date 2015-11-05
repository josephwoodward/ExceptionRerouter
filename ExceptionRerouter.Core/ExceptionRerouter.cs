using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
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
        public static void HandleException(HttpApplication application)
        {
            // Need to flesh out
            Exception exception = application.Server.GetLastError();
            ExceptionContext context = ExceptionTypes.RegisteredExceptions.FirstOrDefault(x => x.ExceptionType == exception.GetType());
            if (context != null)
            {
                application.Response.Clear();
                application.Server.ClearError();

                var handler = new ExceptionHandler(context, application);
                handler.HandleException(exception);
            }
        }
    }
}