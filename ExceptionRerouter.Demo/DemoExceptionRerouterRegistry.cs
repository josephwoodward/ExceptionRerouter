using System.Net;
using ExceptionRerouter.Core;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Demo
{
    public class DemoExceptionRerouterRegistry : ExceptionRerouterRegistry
    {
        public DemoExceptionRerouterRegistry()
        {
            OnException<ProductNotFoundException>().RedirectTo(ProductNotFound);
        }

        private static RouteExecute ProductNotFound(RerouteContext context)
        {
            RerouteAction rerouteAction = context.RerouteTo("Index", "ProductNotFound");
            return rerouteAction.WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}