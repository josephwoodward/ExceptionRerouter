using System;

namespace ExceptionRerouter.Core.Registry
{
    /// <summary>
    /// Registry base class
    /// </summary>
    public class ExceptionRerouterRegistry<T> where T : Exception
    {
        public IRerouteAction OnException()
        {
            return new RerouteAction();
        }

        public IRerouteAction OnException(Action<T> onException)
        {
            return new RerouteAction();
        }
    }
}