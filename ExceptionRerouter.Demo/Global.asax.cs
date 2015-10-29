using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExceptionRerouter.Demo
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Core.ExceptionRerouter.Register(new DemoExceptionRerouterRegistry());
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Core.ExceptionRerouter.HandleException(this);
            /*
                        var routeData = new RouteData();
                        routeData.Values["action"] = "Index";
                        routeData.Values["controller"] = "Error";
                        RequestContext requestContext = new RequestContext(new HttpContextWrapper(Context), routeData);
                        requestContext.HttpContext.Response.ContentType = "text/html";
                        requestContext.HttpContext.Response.StatusCode = 404;
                        IController errorController = new ErrorController();
                        errorController.Execute(requestContext);
                        requestContext.HttpContext.Response.End();
                        // TaskRunner<IRunOnEachRequest>();
            */
        }
    }
}
