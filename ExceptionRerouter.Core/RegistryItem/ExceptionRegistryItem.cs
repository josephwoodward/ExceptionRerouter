using System;

namespace ExceptionRerouter.Core.RegistryItem
{
    public class ExceptionRegistryItem
    {
        public object Registry { get; private set; }

        public Type ExceptionType { get; private set; }

        public ExceptionRegistryItem(object reg, Type exceptionType)
        {
            this.Registry = reg;
            this.ExceptionType = exceptionType;
        }
    }
}