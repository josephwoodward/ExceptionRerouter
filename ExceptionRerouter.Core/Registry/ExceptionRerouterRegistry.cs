using System;
using ExceptionRerouter.Core.Store;

namespace ExceptionRerouter.Core.Registry
{
    /// <summary>
    /// Registry base class
    /// </summary>
    public abstract class ExceptionRerouterRegistry
    {
        protected ExceptionRerouterRule OnException<T>() where T : Exception
        {
            // Register the exception that we can start adding the action configurations to
            Type t = typeof(T);
            ExceptionTypes.Add(t);

            return new ExceptionRerouterRule();
        }
    }

    /// <summary>
    /// Idea for registry base class - not sure if it's overkill
    /// </summary>
    public abstract class ExceptionRerouterRegistry<T> where T : Exception
    {
        public abstract RouteExecute OnException(RerouteContext context);
    }
}
