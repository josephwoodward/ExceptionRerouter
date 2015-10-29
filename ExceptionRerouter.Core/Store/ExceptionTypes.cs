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

        public static IReadOnlyCollection<ExceptionContext> Exceptions = (IReadOnlyCollection<ExceptionContext>) RegisteredExceptions;

        public static void Add(Type exceptionType, RerouteSettingContext rerouteConfiguration)
        {
            if (exceptionType == null)
                throw new ArgumentNullException(nameof(exceptionType));
            if (rerouteConfiguration == null)
                throw new ArgumentNullException(nameof(rerouteConfiguration));

            var exception = new ExceptionContext(exceptionType, rerouteConfiguration)
            {
                FullName = exceptionType.FullName,
                AssemblyQualifiedName = exceptionType.AssemblyQualifiedName
            };

            //TODO: Check to see if it's unique
            if (RegisteredExceptions.All(x => x.AssemblyQualifiedName != exception.AssemblyQualifiedName))
            {
                RegisteredExceptions.Add(exception);
            }
        }
    }
}