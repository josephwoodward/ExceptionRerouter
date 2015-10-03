using System;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouterRule
    {
        public void Go(Action action)
        {
        }

        public void Go(Func<ExceptionContext, RouteExecute> action)
        {
        }
    }
}