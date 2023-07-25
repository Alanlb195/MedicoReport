using System.Web.Mvc;

namespace MedicoReport.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medicos
        public ActionResult Index()
        {
            return View();
        }
    }
}