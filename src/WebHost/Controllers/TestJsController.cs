
namespace WebHost.Controllers
{
    using System.Web.Mvc;

    public class TestJsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIIS()
        {
            throw new System.Exception("Test de excepciones no gestionadas");
        }
    }
}