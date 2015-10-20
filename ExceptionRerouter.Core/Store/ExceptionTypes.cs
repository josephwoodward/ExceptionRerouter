using System;
using System.Collections.Generic;

namespace ExceptionRerouter.Core.Store
{
    /// <summary>
    /// Store for all exceptions registered
    /// </summary>
    public class ExceptionTypes
    {
        internal static readonly IList<ExceptionContext> RegisteredExceptions = new List<ExceptionContext>();

        public IEnumerable<ExceptionContext> Exceptions = RegisteredExceptions;

        public void Add<T>(T exceptionType)
        {
            if (exceptionType == null)
            {
                throw new ArgumentNullException(nameof(exceptionType));
            }

            var exception = new ExceptionContext(typeof(T));

            //TODO: Check to see if it's unique
            RegisteredExceptions.Add(exception);
        }
    }
}