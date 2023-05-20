using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using laba_2.Models;

namespace laba_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id, string Fullname, DateTime data, uint number, string adress_sender, string adress_recipient, string weight, string delivery_method)
        {
            string authData = $"ID: {id}  Name: {Fullname}  Delivery_date: {data}  Phone: {number}  Adress_sender: {adress_sender}  Adress_recipient: {adress_recipient}  Weight: {weight}  Method: {Convert.ToString(delivery_method)}";
            return Content(authData);
        }
        public IActionResult details()
        {
            return View(User);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}