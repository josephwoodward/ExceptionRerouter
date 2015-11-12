using System.Net;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Demo.Controllers;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Demo
{
    public class ProductNotFoundExceptionRegistry : ExceptionRerouterRegistry<ProductNotFoundException>
    {
        public override ExceptionRerouterRule OnException(IRerouteAction actions)
        {
            return actions.RedirectTo("Index", typeof(ProductNotFoundController)).WithStatusCode(HttpStatusCode.NotFound);
        }
    }
}