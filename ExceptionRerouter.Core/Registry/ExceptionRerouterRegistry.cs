using System;

namespace ExceptionRerouter.Core.Registry
{
    /// <summary>
    /// Registry base class
    /// </summary>
    public abstract class ExceptionRerouterRegistry<T> where T : Exception
    {
        public abstract ExceptionRerouterRule OnException(IRerouteAction actions);
    }
}