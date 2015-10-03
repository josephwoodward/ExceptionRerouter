using System.Web.Mvc;

namespace ExceptionRerouter.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}