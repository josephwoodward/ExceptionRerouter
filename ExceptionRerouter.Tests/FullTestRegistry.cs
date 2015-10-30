using System.Net;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Demo.Controllers;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Tests
{
    public class FullTestRegistry : ExceptionRerouterRegistry
    {
        public FullTestRegistry()
        {
            OnException<PageNotFoundException>().RedirectTo(context => context.RerouteTo("Index", typeof(ProductNotFoundController)).WithStatusCode(HttpStatusCode.NotFound));
        }
    }
}