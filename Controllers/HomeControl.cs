using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SDEVTest.Controllers
{
    public class HomeControl : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
