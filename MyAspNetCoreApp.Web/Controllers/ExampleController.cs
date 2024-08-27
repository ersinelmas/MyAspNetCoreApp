﻿using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            var productList = new List<Product>
            {
                new Product { Id = 1, Name = "Pen" },
                new Product { Id = 2, Name = "Book" },
                new Product { Id = 3, Name = "Phone" }
            };

            return View(productList);
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Index3()
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
