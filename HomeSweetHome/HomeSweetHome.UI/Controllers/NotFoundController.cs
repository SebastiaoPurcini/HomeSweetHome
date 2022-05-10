using Microsoft.AspNetCore.Mvc;

namespace HomeSweetHome.UI.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
