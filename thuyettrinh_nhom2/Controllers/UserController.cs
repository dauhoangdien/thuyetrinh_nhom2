using Microsoft.AspNetCore.Mvc;

namespace thuyettrinh_nhom2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
