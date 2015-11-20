# ExceptionRerouter - Work in progress
A simple global exception rerouting library for ASP.NET MVC.

**Usage Example:**

**Custom registry**
```csharp
public class DemoExceptionRerouterRegistry : ExceptionRerouterRegistry<ProductNotFoundException>
{
    public void OnException(object exception)
    {
        // Log exception details
    }

    public ExceptionRerouterRule Reroute(IRerouteAction actions)
    {
        return actions.RedirectTo("Index", typeof(ProductNotFoundController)).WithStatusCode(HttpStatusCode.NotFound);
    }
}
```

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

More information coming soon...
