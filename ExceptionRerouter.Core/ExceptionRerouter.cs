﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionRerouter.Core
{
    public class ExceptionRerouter
    {
        // Routes encapsulated collection
        private static readonly ExceptionRegistrations RegisteredRegistrations = new ExceptionRegistrations();

        // Public collection of registrys
        public static IEnumerable<ExceptionRerouterRegistry> Routes => RegisteredRegistrations.Routes;

        // Register
        public static void Register(ExceptionRerouterRegistry registry)
        {
            if (registry == null)
            {
                throw new NullReferenceException("registry");
            }

            if (RegisteredRegistrations.Routes.Any(x => x.GetType() == registry.GetType()))
            {
                return;
            }

            RegisteredRegistrations.Add(registry);
        }

        // Handle
        public static void HandleException(Exception getLastError)
        {
        }
    }
}