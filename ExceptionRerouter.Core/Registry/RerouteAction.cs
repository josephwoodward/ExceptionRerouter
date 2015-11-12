using System;
using System.Net;

namespace ExceptionRerouter.Core.Registry
{
    public class RerouteAction : IRerouteAction
    {
        public RerouteSubAction RedirectTo(string actionName, Type controller)
        {
            return new RerouteSubAction();
        }

        public class RerouteSubAction
        {
            public ExceptionRerouterRule WithStatusCode(HttpStatusCode statusCode)
            {
                return new ExceptionRerouterRule();
            }
        }
    }
}