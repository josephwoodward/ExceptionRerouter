using System;
using System.Net;

namespace ExceptionRerouter.Core
{
    public class RerouteAction
    {
        private readonly RerouteSettingContext configuration;

        public RerouteAction(RerouteSettingContext configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            this.configuration = configuration;
        }

        public RouteExecute WithStatusCode(HttpStatusCode statusCode)
        {
            configuration.StatusCode = statusCode;

            // Execute the rerouting based on configuration
            return new RouteExecute(configuration);
        }
    }

    public class RouteExecute
    {
        public RouteExecute(RerouteSettingContext configuration)
        {
            
        }
    }
}