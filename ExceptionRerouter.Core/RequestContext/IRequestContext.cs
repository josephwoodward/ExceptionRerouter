using System;
using System.Web;

namespace ExceptionRerouter.Core.RequestContext
{
    public interface IRequestContext
    {
        string IpAddress { get; }

        Uri ReferrerUrl { get; }

        HttpRequestBase HttpRequest { get; }
    }
}