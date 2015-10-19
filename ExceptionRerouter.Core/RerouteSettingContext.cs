using System;
using System.Linq.Expressions;
using System.Net;
using System.Web.Mvc;

namespace ExceptionRerouter.Core
{
    public class RerouteSettingContext
    {
        public HttpStatusCode StatusCode { get; set; }

        public void SetController<T>(Expression<Action<T>> controller) where T : Controller
        {
            throw new NotImplementedException();
        }
    }
}