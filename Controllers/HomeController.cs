using Microsoft.AspNetCore.Mvc;
using System;


namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View("MyView");
        }

    }
}
