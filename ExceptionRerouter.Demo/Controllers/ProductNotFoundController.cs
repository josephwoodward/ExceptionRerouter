using System.Web.Mvc;

namespace ExceptionRerouter.Demo.Controllers
{
    public class ProductNotFoundController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}