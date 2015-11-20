using System;
using System.Collections.Generic;
using ExceptionRerouter.Core.RegistryItem;

namespace ExceptionRerouter.Core.Provider
{
    public interface IRegistryPopper
    {
        ExceptionRegistryItem Pop();

        ICollection<ExceptionRegistryItem> Select(Func<Type, bool> where);

        ExceptionRegistryItem GetExceptionRegistryItem(Type type);

        int Count();

        void Clear();
    }
}