using System;
using System.Collections.Generic;

namespace ExceptionRerouter.Core
{
    public class ExceptionRoutes
    {
        internal static readonly IList<ExceptionRerouterRegistry> RegisteredRoutes = new List<ExceptionRerouterRegistry>();

        public IEnumerable<ExceptionRerouterRegistry> Routes => RegisteredRoutes;

        public void Add(ExceptionRerouterRegistry registry)
        {
            if (registry == null)
            {
                throw new ArgumentNullException("registry");
            }

            RegisteredRoutes.Add(registry);
        }

        public void Clear()
        {
            RegisteredRoutes.Clear();
        }
    }
}