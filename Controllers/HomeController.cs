using _70999_BankingApp.Models;
using _70999_BankingApp.MyData;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _70999_BankingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;


        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var User = new User
            {
                Name = "Juan",
                Email = "fff0",
                Password = "ffdddd"

            };
            _dataContext.Users.Add(User);
            _dataContext.SaveChanges();


            return View();
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
