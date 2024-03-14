using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using thuyettrinh_nhom2.Models;

namespace thuyettrinh_nhom2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Phần Login
        public IActionResult Login(string user, string password)
        {
            //Check DB
            BanHang_TestEntities db = new BanHang_TestEntities();
            int demTaiKhoan = db.TaiKhoan.Count(m=>m.Username.ToLower == user.ToLower() && m.Password == password);
            if (demTaiKhoan == 1)
            {
                //Mở giao diện admin
                return View();
            }
            else
            {
                //Mở Sidebar
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
