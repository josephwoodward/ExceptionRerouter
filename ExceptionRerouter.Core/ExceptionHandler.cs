using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExceptionRerouter.Core
{
    public class ExceptionHandler
    {
        private readonly ExceptionContext exceptionContext;
        private readonly HttpApplication application;

        public ExceptionHandler(ExceptionContext exceptionContext, HttpApplication application)
        {
            this.exceptionContext = exceptionContext;
            this.application = application;
        }

        public void HandleException(Exception exception)
        {
            // Better way? http://stackoverflow.com/questions/6033681/how-to-override-httperrors-section-in-web-config-asp-net-mvc3
            System.Web.Routing.RequestContext rc;

            //TODO: Clean this up
            Type controllerType = this.exceptionContext.ExecutionConfiguration.ControllerType;
            IController errorsController = (IController)Activator.CreateInstance(controllerType);

            

            var routeData = new RouteData();
            routeData.Values["action"] = exceptionContext.ExecutionConfiguration.ActionName;

            // TODO: Get name of controller
            routeData.Values["controller"] = "PageNotFound";

            rc = new System.Web.Routing.RequestContext(new HttpContextWrapper(application.Context), routeData);
            rc.HttpContext.Response.TrySkipIisCustomErrors = true;

            HttpStatusCode statusCode = exceptionContext.ExecutionConfiguration.StatusCode;
            if (exceptionContext.ExecutionConfiguration.StatusCode != 0)
            {
                rc.HttpContext.Response.StatusCode = (int)statusCode;
                rc.HttpContext.Response.ContentType = "text/html";
            }

            errorsController.Execute(rc);
            rc.HttpContext.Response.End();
        }
    }
}