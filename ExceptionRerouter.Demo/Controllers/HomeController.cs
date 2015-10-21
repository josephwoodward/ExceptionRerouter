using System.Web.Mvc;
using ExceptionRerouter.Demo.Exceptions;

namespace ExceptionRerouter.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new ProductNotFoundException();

            return View();
        }
    }
}