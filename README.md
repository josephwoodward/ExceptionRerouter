# ExceptionRerouter
A simple exception rerouting library for ASP.NET MVC.

Example:

**Global.asax.cs**
```csharp
protected void Application_Start()
{
    ...
    ExceptionRerouter.Register(new ProductNotFoundExceptionRegistry());
    ...
}

protected void Application_Error(object sender, EventArgs e)
{
    ExceptionRerouter.HandleException(this);
}
```

**Custom registry**
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
