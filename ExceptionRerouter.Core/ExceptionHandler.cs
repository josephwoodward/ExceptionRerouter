using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExceptionRerouter.Core
{
    public class ExceptionHandler
    {
        private readonly ExceptionContext exceptionContext;

        public ExceptionHandler(ExceptionContext exceptionContext)
        {
            this.exceptionContext = exceptionContext;
        }

        public void HandleException(Exception exception)
        {
            var routeData = new RouteData();


            //TODO: Update to generic type so we can create controller from this.
            Type controllerType = this.exceptionContext.ExecutionConfiguration.ControllerType;

            object errorsController = Activator.CreateInstance(controllerType);

            System.Web.Routing.RequestContext rc;
        }
    }
}