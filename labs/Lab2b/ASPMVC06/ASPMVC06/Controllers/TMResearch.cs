using Microsoft.AspNetCore.Mvc;

namespace ASPMVC06.Controllers
{
    public class TMResearch : Controller
    {
        // GET:M01
        public ActionResult M01(string id = null)
        {
            if (id == "1")
            {
                return Content("GET:M01");
            }
            else
            {
                return Content(id ?? "GET:M01");
            }
        }

        // GET:M02
        public ActionResult M02(string id = null)
        {
            return Content("GET:M02");
        }

        // GET:M03
        public ActionResult M03(string id = null)
        {
            return Content("GET:M03");
        }

        // GET:MXX
        public ActionResult MXX(string id = null)
        {
            return Content("GET:MXX");
        }
    }
}
