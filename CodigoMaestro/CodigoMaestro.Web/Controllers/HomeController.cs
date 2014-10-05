using System.Web.Mvc;

namespace CodigoMaestro.Web.Controllers
{
    public class HomeController : CodigoMaestroControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}