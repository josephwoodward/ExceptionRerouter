using System;
using ExceptionRerouter.Core.RegistryItem;

namespace ExceptionRerouter.Core.Provider
{
    public interface IRegistryPusher
    {
        void Push(Type key, ExceptionRegistryItem registry);
    }
}