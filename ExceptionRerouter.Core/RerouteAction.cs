using System.Net;

namespace ExceptionRerouter.Core
{
    public class RerouteAction
    {
        public RouteExecute WithStatusCode(HttpStatusCode statusCode)
        {
            return new RouteExecute();
        }
    }

    public class RouteExecute
    {
    }
}