using System;
using ExceptionRerouter.Core.Store;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouterRule
    {
        private readonly Type exceptionType;

        public ExceptionRerouterRule(Type exceptionType)
        {
            this.exceptionType = exceptionType;
        }

        public void RedirectTo(Func<RerouteContext, RerouteSettingContext> action)
        {
            var config = new RerouteSettingContext
            {
                ExceptionType = exceptionType
            };

            // Store this delegate in exception context
            RerouteSettingContext execute = action(new RerouteContext(config));

            // HERE
            ExceptionTypes.Add(exceptionType, execute);
        }
    }
}