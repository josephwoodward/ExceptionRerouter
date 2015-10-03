using System.Net;
using ExceptionRerouter.Core;
using ExceptionRerouter.Demo.Controllers;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Demo
{
    public class DemoExceptionRerouterRegistry : ExceptionRerouterRegistry
    {
        public DemoExceptionRerouterRegistry()
        {
            OnException<ProductNotFoundException>().RedirectTo(ProductNotFound);
            OnException<PageNotFoundException>().RedirectTo(PageNotFound);
        }

        private static RouteExecute ProductNotFound(RerouteContext context)
        {
            return context.RerouteTo<ProductNotFoundController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
        }

        private static RouteExecute PageNotFound(RerouteContext context)
        {
            return context.RerouteTo<PageNotFoundController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}