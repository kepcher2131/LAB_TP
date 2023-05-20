using laba_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laba_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calc cal, string name)
        {
            byte a = Convert.ToByte(cal.operand1);
            byte b = Convert.ToByte(cal.operand2);
            float result = Convert.ToSingle(cal.result);

            switch (cal.calulate)
            {
                case "-":
                    result = a - b;
                    cal.exception = "";
                    break;
                case "+":
                    result = a + b;
                    cal.exception = "";
                    break;
                case "*":
                    result = a * b;
                    cal.exception = "";
                    break;
                case "/":
                    if (b == 0)
                    {
                        cal.exception = "На ноль делить нельзя";
                    }
                    else
                    {
                        result = a / b;
                        cal.exception = "";
                    }
                    break;
            }

            if (name == "delete")
            {
                cal.operand1 = "";
                cal.operand2 = "";
                cal.result = "";
                cal.exception = "";
            }

            ViewData["result"] = result;
            ViewData["exception"] = cal.exception;

            if (ViewBag.result == 5)
            {
                ViewBag.exception = "Вычисленный результат равен заданному значению";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Duplication(string operand1, string calulate, string operand2, string result)
        {
            string Operand1 = Request.Query["operand1"];
            string Calulate = Request.Query["calulate"];
            string Operand2 = Request.Query["operand2"];
            string Result = Request.Query["result"];
            return $"{operand1} {calulate} {operand2} {result}";
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}