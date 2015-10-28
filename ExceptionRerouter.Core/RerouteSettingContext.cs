using System.Net;
using System.Web.Routing;

namespace ExceptionRerouter.Core
{
    public class RerouteSettingContext
    {
        public HttpStatusCode StatusCode { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public RouteValueDictionary RouteValues { get; set; }
    }
}