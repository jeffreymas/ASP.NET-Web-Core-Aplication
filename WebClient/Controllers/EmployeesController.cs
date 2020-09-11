using System;
using System.Collections.Generic;
using System.Linq;
using LearnNetCore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebClient.Controllers
{
    public class EmployeesController : Controller
    {
       
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44373/api/")
        };
        public IActionResult Index()
        {
            return View("~/Views/Employees/ViewEmp.cshtml");
        }


        public IActionResult LoadEmp()
        {
            IEnumerable<EmployeeVM> emp = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("employees");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<EmployeeVM>>();
                readTask.Wait();
                emp = readTask.Result;
            }
            else
            {
                emp = Enumerable.Empty<EmployeeVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(emp);

        }

        public IActionResult GetById(string Id)
        {
            EmployeeVM emp = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("employees/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                emp = JsonConvert.DeserializeObject<EmployeeVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(emp);
        }

        public IActionResult Delete(string id)
        {
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var result = client.DeleteAsync("employees/" + id).Result;
            return Json(result);
        }


    }
}