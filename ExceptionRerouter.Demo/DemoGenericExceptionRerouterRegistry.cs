using System.Net;
using ExceptionRerouter.Core;
using ExceptionRerouter.Core.Registry;
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

        private static RerouteSettingContext ProductNotFound(RerouteContext context)
        {
            context.SetException((exception) =>
            {
                if (exception is ProductNotFoundException)
                {
                    // further handling
                }
            });

            return context.RerouteTo("Index", typeof(ProductNotFoundController)).WithStatusCode(HttpStatusCode.NotFound);
        }

        private static RerouteSettingContext PageNotFound(RerouteContext context)
        {
            return context.RerouteTo("Index", typeof(PageNotFoundController)).WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}