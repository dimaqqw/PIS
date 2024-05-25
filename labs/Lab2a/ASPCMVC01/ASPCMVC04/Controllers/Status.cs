using Microsoft.AspNetCore.Mvc;

namespace ASPCMVC04.Controllers
{
    public class Status : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult S200()
        {
            return StatusCode(new Random().Next(200,299));
        }

        public IActionResult S300()
        {
            return StatusCode(new Random().Next(300, 399));
        }

        public IActionResult S500()
        {

            return StatusCode(new Random().Next(500, 599));
        }
    }
}
