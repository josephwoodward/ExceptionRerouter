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

        private static RerouteSettingContext ProductNotFound(RerouteContext context)
        {
            return context.RerouteTo("Index", "ProductNotFound").WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}