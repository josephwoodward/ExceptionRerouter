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

        public Action<Exception> MyExceptionHandler { get; set; }

        public Type ExceptionType { get; set; }

        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }

        public RerouteSettingContext ExecutionConfiguration { get; set; }
    }
}