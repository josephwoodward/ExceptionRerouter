using System;

namespace ExceptionRerouter.Core
{
    public class ExceptionContext
    {
        public ExceptionContext(Type exception)
        {
            ExceptionType = exception;
        }

        public Type ExceptionType { get; set; }

        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }
    }
}