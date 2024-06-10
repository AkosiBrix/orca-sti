using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyMVCController : Controller
    {
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
