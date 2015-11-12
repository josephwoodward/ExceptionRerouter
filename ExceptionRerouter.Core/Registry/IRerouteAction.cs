using System;

namespace ExceptionRerouter.Core.Registry
{
    public interface IRerouteAction
    {
        RerouteAction.RerouteSubAction RedirectTo(string actionName, Type controller);
    }
}