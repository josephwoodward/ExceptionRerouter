using System;
using ExceptionRerouter.Core.Store;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouterRule
    {
        private readonly Type type;

        public ExceptionRerouterRule(Type type)
        {
            this.type = type;
        }

        public void RedirectTo(Func<RerouteContext, RouteExecute> action)
        {
            var config = new RerouteSettingContext();

            // Store this delegate in exception context
            RouteExecute execute = action(new RerouteContext(config));

            // HERE
            ExceptionTypes.Add(type, action);
        }
    }
}