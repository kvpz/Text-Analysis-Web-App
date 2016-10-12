using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TextAnalysisWithAssociativeContainer.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld/
        public IActionResult Index() // a controller method
        {
            return View();
        }

        // Get: /HelloWorld/Welcome/<integer>?name=<string>
        // alternative ../Welcome?name=<string>&numtimes=<integer> where numtimes letter case and argument order don't matter
        public IActionResult Welcome(string name, int numTimes = 1) 
        {
            // This Encode method protects the app from malicious input
            //return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}"); // returns string
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View(); // View() will be defined once Welcome.cshtml (the view) is created
        }

        /*
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}
