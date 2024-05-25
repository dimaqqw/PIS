using ASPCMVC07.Models;
using ASPCMVC07.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPCMVC07.Controllers
{
    public class CalcController : Controller
    {
        private readonly ILogger<CalcController> _logger;

        public CalcController(ILogger<CalcController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? press, float? x, float? y)
        {
            ViewBag.press = press;
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.z = 0;
            return View();
        }


        public IActionResult Sum(float? x, float? y)
        {
            float? z = x + y;
            if (x == null && y == null)
            {
                x = 0; y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (y == null)
            {
                y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (x == null)
            {
                x = 0; z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            ViewBag.press = "+";
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.z = z;
            return View("Index");
        }

        public IActionResult Sub(float? x, float? y)
        {
            float? z = x - y;
            if (x == null && y == null)
            {
                x = 0; y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (y == null)
            {
                y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (x == null)
            {
                x = 0; z = 0;
                ViewBag.Error = "Error";
            }
            ViewBag.press = "-";
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.z = z;
            return View("Index");
        }

        public IActionResult Mul(float? x, float? y)
        {
            float? z = x * y;
            if (x == null && y == null)
            {
                x = 0; y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (y == null)
            {
                y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (x == null)
            {
                x = 0; z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            ViewBag.press = "*";
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.z = z;
            return View("Index");
        }

        public IActionResult Div(float? x, float? y)
        {
            float? z = x / y;
            if (x == null && y == null || y == 0)
            {
                x = 0; y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (y == null)
            {
                y = 0;
                z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            else if (x == null)
            {
                x = 0; z = 0;
                ViewBag.Error = "-- ERROR --";
            }
            ViewBag.press = "/";
            ViewBag.x = x;
            ViewBag.y = y;
            ViewBag.z = z;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
