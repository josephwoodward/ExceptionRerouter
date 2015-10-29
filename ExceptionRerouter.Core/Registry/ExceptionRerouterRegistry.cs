using System;

namespace ExceptionRerouter.Core.Registry
{
    /// <summary>
    /// Registry base class
    /// </summary>
    public abstract class ExceptionRerouterRegistry
    {
        protected ExceptionRerouterRule OnException<T>() where T : Exception
        {
            return new ExceptionRerouterRule(typeof(T));
        }
    }

    /// <summary>
    /// Idea for registry base class - not sure if it's overkill
    /// </summary>
    public abstract class ExceptionRerouterRegistry<T> where T : Exception
    {
        public abstract ExceptionRerouterRule OnException(RerouteContext context);
    }
}
