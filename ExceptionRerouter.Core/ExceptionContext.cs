using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace ExceptionRerouter.Core
{
    public class ExceptionContext
    {
        public Exception Exception { get; set; }

        public RerouteAction RerouteTo<T>(Expression<Action<T>> controller) where T : Controller
        {
            return new RerouteAction();
        }
    }
}