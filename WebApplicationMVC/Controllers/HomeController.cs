using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserDaoLibrary;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UserDetail(int id)
        {
            ViewBag.Id = id;

            SqliteUserDao dao = new SqliteUserDao();

            User user = dao.GetUser(id);

            dao.Close();
            ViewBag.User = user;
            return View();
        }
        public IActionResult UserList()
        {
            SqliteUserDao dao = new SqliteUserDao();

            var users = dao.GetUsers();

            dao.Close();

            string[] names = { "Alice", "Bob", "Carol" };
            ViewBag.Title = "The User List";
            ViewBag.Names = names;
            ViewBag.Users = users;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}