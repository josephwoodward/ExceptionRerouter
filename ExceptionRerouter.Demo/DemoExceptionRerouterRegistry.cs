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
            OnException<ProductNotFoundException>().Go(GoToProductNotFound);
            OnException<PageNotFoundException>().Go(GoToPageNotFound);
        }

        private static RouteExecute GoToProductNotFound(ExceptionContext context)
        {
            return context.RerouteTo<HomeController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
        }

        private static RouteExecute GoToPageNotFound(ExceptionContext context)
        {
            return context.RerouteTo<HomeController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}