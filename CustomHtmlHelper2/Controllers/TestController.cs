using CustomHtmlHelper2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomHtmlHelper2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestViewModel();
            model.Name = "Test";
            return View(model);
        }
    }
}