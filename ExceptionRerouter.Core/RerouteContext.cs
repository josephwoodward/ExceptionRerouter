using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace ExceptionRerouter.Core
{
    public class RerouteContext
    {
        private readonly RerouteSettingContext ConfigurationContext;

        public RerouteContext(RerouteSettingContext configurationContext)
        {
            ConfigurationContext = configurationContext;
        }

        public RerouteAction RerouteTo<T>(Expression<Action<T>> controller) where T : Controller
        {
            ConfigurationContext.SetController(controller);

            return new RerouteAction(ConfigurationContext);
        }
    }
}
