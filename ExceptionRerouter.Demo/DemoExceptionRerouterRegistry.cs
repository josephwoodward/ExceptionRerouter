using System.Net;
using ExceptionRerouter.Core;
using ExceptionRerouter.Demo.Controllers;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Demo
{
    public class DemoExceptionRerouterRegistry : ExceptionRerouterRegistry
    {
        public DemoExceptionRerouterRegistry() : base()
        {
            OnException<ProductNotFoundException>().RedirectTo(ProductNotFound);
        }

        private static RouteExecute ProductNotFound(RerouteContext context)
        {
            return context.RerouteTo<ProductNotFoundController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}