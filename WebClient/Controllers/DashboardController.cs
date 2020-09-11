using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LearnNetCore.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebClient.Controllers
{
    public class DashboardController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44373/api/")
        };

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("lvl") == "Sales" || HttpContext.Session.GetString("lvl")== "Admin")
            {
                if (HttpContext.Session.GetString("lvl") == "Admin")
                {
                    return View();
                }
                return Redirect("/dashboard/profile");
            }
            return Redirect("/Login");
        }


        public IActionResult Profile()
        {
            if (HttpContext.Session.GetString("lvl") == "Sales" || HttpContext.Session.GetString("lvl") == "Admin")
            {
                return View("~/Views/Dashboard/Profile.cshtml");
            }
            return Redirect("/Login");
        }

        public IActionResult LoadPie()
        {
            IEnumerable<PieChartVM> pie = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("charts/pie");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<PieChartVM>>();
                readTask.Wait();
                pie = readTask.Result;
            }
            else
            {
                pie = Enumerable.Empty<PieChartVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(pie);
        }

        public IActionResult LoadBar()
        {
            IEnumerable<PieChartVM> bar = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("charts/pie");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<PieChartVM>>();
                readTask.Wait();
                bar = readTask.Result;
            }
            else
            {
                bar = Enumerable.Empty<PieChartVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(bar);
        }
    }
}