using System;
using System.Collections.Generic;

namespace ExceptionRerouter.Core
{
    public abstract class ExceptionRerouterRegistry
    {
        private IList<object> RegisteredExceptions { get; } = new List<object>();

        protected ExceptionRerouterRule OnException<T>() where T: Exception
        {
            RegisteredExceptions.Add(typeof(T));

            return new ExceptionRerouterRule();
        }
    }

    public abstract class ExceptionRerouterRegistry<T> where T : Exception
    {
        public abstract RouteExecute OnException(RerouteContext context);
    }
}
