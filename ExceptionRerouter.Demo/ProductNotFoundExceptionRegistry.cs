using System;
using System.Net;
using ExceptionRerouter.Core.Registry;
using ExceptionRerouter.Demo.Controllers;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Demo
{
    public class ProductNotFoundExceptionRegistry : ExceptionRerouterRegistry<ProductNotFoundException>
    {
        public ProductNotFoundExceptionRegistry()
        {
            this.OnException(Exception).RedirectTo("Index", typeof(ProductNotFoundController)).WithStatusCode(HttpStatusCode.NotFound);
        }

        public void Exception(Exception exception)
        {
            
        }
    }
}