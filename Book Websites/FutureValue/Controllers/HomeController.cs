using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.FutureValue = model.CalculateFutureValue();
                return View(model);
            }
            else
                ViewBag.FutureValue = 0;

            return View(model);
        }
    }
}
