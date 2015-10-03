using System;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouterRule
    {
        public void RedirectTo(Action action)
        {
        }

        public void RedirectTo(Func<RerouteContext, RouteExecute> action)
        {
        }
    }
}