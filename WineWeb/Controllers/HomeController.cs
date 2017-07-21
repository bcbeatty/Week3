using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;

namespace WineWeb.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://wineapi/");
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                var response = await client.GetAsync("/api/wines");
                var stringData = await response.Content.ReadAsStringAsync();
                var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(stringData);
                ViewData["Message"] = "Wines are: " + string.Join(",", list);

            }

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
