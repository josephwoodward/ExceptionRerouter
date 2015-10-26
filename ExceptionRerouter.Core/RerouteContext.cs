using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

namespace ExceptionRerouter.Core
{
    public class RerouteContext
    {
        private readonly RerouteSettingContext ConfigurationContext;

        public RerouteContext(RerouteSettingContext configurationContext)
        {
            ConfigurationContext = configurationContext;
        }

        /*
        // Coming soon
        public RerouteAction RerouteTo<T>(Expression<Action<T>> controller) where T : Controller
        {
            ConfigurationContext.SetController(controller);

            return new RerouteAction(ConfigurationContext);
        }*/

        public RerouteAction RerouteTo(string actionName, string controllerName)
        {
            return this.RerouteTo(actionName, controllerName, null);
        }
        
        public RerouteAction RerouteTo(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            if (routeValues == null) routeValues = new RouteValueDictionary();

            return this.SetRerouteProperties(actionName, controllerName, routeValues);
        }

        private RerouteAction SetRerouteProperties(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            if (string.IsNullOrEmpty(actionName)) throw new ArgumentNullException(nameof(actionName));
            if (string.IsNullOrEmpty(controllerName)) throw new ArgumentNullException(nameof(controllerName));

            ConfigurationContext.ControllerName = controllerName;
            ConfigurationContext.ActionName = actionName;
            ConfigurationContext.RouteValues = routeValues;

            return new RerouteAction(ConfigurationContext);
        }
    }
}
