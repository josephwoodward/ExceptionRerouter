using System;
using System.Web.Routing;

namespace ExceptionRerouter.Core
{
    public class RerouteContext
    {
        private readonly RerouteSettingContext ConfigurationContext;
        public readonly Type ExceptionType;

        public RerouteContext(RerouteSettingContext configurationContext)
        {
            ConfigurationContext = configurationContext;
            ExceptionType = configurationContext.ExceptionType;
        }

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
            if (string.IsNullOrEmpty(actionName)) 
                throw new ArgumentNullException(nameof(actionName));
            if (string.IsNullOrEmpty(controllerName)) 
                throw new ArgumentNullException(nameof(controllerName));

            ConfigurationContext.ControllerName = controllerName;
            ConfigurationContext.ActionName = actionName;
            ConfigurationContext.RouteValues = routeValues;

            return new RerouteAction(ConfigurationContext);
        }
    }
}