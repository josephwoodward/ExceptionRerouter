using System;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouterRule
    {
        public void RedirectTo(Func<RerouteContext, RouteExecute> action)
        {
            var config = new RerouteSettingContext();

            action(new RerouteContext(config));
        }
    }
}