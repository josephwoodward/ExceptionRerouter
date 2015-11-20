# ExceptionRerouter
A simple exception rerouting library for ASP.NET MVC.

Example:
```csharp
public class DemoExceptionRerouterRegistry : ExceptionRerouterRegistry<ProductNotFoundException>
{
    public ExceptionRerouterRule OnException(IRerouteAction actions)
    {
        return actions.RedirectTo("Index", typeof(ProductNotFoundController)).WithStatusCode(HttpStatusCode.NotFound);
    }
}
```

More information coming soon...
