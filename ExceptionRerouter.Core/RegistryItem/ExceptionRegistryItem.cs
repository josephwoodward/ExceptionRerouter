using System;

namespace ExceptionRerouter.Core.RegistryItem
{
    public class ExceptionRegistryItem
    {
        public Type Registry { get; private set; }

        public Type ExceptionType { get; private set; }

        public ExceptionRegistryItem(Type reg, Type exceptionType)
        {
            this.Registry = reg;
            this.ExceptionType = exceptionType;
        }
    }
}