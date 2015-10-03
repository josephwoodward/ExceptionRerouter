# ExceptionRerouter
A simple exception rerouting library for ASP.NET MVC.

Example:
```csharp
public class DemoExceptionRerouterRegistry : ExceptionRerouterRegistry
{
    public DemoExceptionRerouterRegistry()
    {
        OnException<ProductNotFoundException>().RedirectTo(ProductNotFound);
        OnException<PageNotFoundException>().RedirectTo(GoToPageNotFound);
    }

    private static RouteExecute GoToProductNotFound(RerouteContext context)
    {
        return context.RerouteTo<ProductNotFoundController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
    }

    private static RouteExecute GoToPageNotFound(RerouteContext context)
    {
        return context.RerouteTo<PageNotFoundController>(x => x.Index()).WithStatusCode(HttpStatusCode.NotFound);
    }
}
```

More information coming soon...
