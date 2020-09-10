using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("lvl") == "Sales" || HttpContext.Session.GetString("lvl") == "Admin")
            {
                return View();
            }
            return Redirect("/error");
        }

        [Route ("error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
