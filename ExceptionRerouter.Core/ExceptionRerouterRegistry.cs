using System;

namespace ExceptionRerouter.Core
{
    public abstract class ExceptionRerouterRegistry
    {
        protected ExceptionRerouterRule OnException<T>()
        {
            return new ExceptionRerouterRule();
        }
    }

    public abstract class ExceptionRerouterRegistry<T> where T : Exception
    {
        public abstract void OnException(ExceptionContext context);
    }
}
