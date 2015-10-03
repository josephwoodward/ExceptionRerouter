using System;
using System.Collections.Generic;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouter
    {
        private static readonly IList<ExceptionRerouterRegistry> Routes = new List<ExceptionRerouterRegistry>();

        public static void Register(ExceptionRerouterRegistry registry)
        {
            if (Routes.Contains(registry))
            {
                return;
            }

            Routes.Add(registry);
        }

        public static void HandleException(Exception getLastError)
        {
            throw new NotImplementedException();
        }
    }
}