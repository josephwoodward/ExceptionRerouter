using System;

namespace ExceptionRerouter.Core
{
    public class ExceptionContext
    {
        public ExceptionContext(Type exception, RerouteSettingContext rerouteConfiguration)
        {
            ExecutionConfiguration = rerouteConfiguration;
            ExceptionType = exception;
        }

        public Type ExceptionType { get; set; }

        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }

        public RerouteSettingContext ExecutionConfiguration { get; set; }
    }
}