using System;
using System.Net;

namespace ExceptionRerouter.Core
{
    public class RerouteAction
    {
        private readonly RerouteSettingContext configuration;

        public RerouteAction(RerouteSettingContext configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            this.configuration = configuration;
        }

        public RerouteSettingContext WithStatusCode(HttpStatusCode statusCode)
        {
            configuration.StatusCode = statusCode;
            return configuration;
        }
    }
}