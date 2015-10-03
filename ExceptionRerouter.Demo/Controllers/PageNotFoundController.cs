using System.Web.Mvc;

namespace ExceptionRerouter.Demo.Controllers
{
    public class PageNotFoundController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}