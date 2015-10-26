using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionRerouter.Core.Store
{
    /// <summary>
    /// Store for all exceptions registered
    /// </summary>
    public static class ExceptionTypes
    {
        internal static readonly IList<ExceptionContext> RegisteredExceptions = new List<ExceptionContext>();

        public static IEnumerable<ExceptionContext> Exceptions = RegisteredExceptions;

        public static void Add(Type exceptionType)
        {
            if (exceptionType == null)
            {
                throw new ArgumentNullException(nameof(exceptionType));
            }

            string fullName = exceptionType.AssemblyQualifiedName;

            var exception = new ExceptionContext(exceptionType)
            {
                FullName = exceptionType.FullName,
                AssemblyQualifiedName = fullName
            };

            //TODO: Check to see if it's unique
            if (RegisteredExceptions.All(x => x.AssemblyQualifiedName != fullName))
            {
                RegisteredExceptions.Add(exception);
            }
        }
    }
}