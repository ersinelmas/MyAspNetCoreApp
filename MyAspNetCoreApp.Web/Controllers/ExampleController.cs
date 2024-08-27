using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return RedirectToAction("Index", "Example");
        }

        public IActionResult ParameterView(int id)
        {
            return RedirectToAction("JsonResultParameter", "Example", new { id = id });
        }

        public IActionResult JsonResultParameter(int id)
        {
            return Json(new { Id = id });
        }

        public IActionResult ContentResult()
        {
            return Content("Hello, World!");
        }

        public IActionResult JsonResult()
        {
            return Json(new { message = "Hello, World!" });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
