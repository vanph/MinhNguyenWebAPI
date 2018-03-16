using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldWebApp.Models;
using Newtonsoft.Json;
using RestSharp;

namespace HelloWorldWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var url = "http://helloworldapi.com/api/product/GetProducts";//endpoint

            var client = new RestClient(url);
            var request = new RestRequest();
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var products = JsonConvert.DeserializeObject<List<Product>>(content);
           
            return View(products);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}