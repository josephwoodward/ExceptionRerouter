using System;
using ExceptionRerouter.Core.Store;

namespace ExceptionRerouter.Core.Registry
{
    /// <summary>
    /// Registry base class
    /// </summary>
    public abstract class ExceptionRerouterRegistry
    {
        private readonly ExceptionTypes Exceptions = new ExceptionTypes();

        protected ExceptionRerouterRule OnException<T>() where T : Exception
        {
            // Register the exception that we can start adding the action configurations to
            Type t = typeof(T);
            var name = t.FullName;
            string fullName = t.AssemblyQualifiedName;

            Exceptions.Add(t);

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
