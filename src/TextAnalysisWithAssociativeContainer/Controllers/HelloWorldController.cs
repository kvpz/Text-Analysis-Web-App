using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TextAnalysisLibrary;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TextAnalysisWithAssociativeContainer.Controllers
{

    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld/
        [HttpGet]
        public async Task<IActionResult> Index() // a controller method
        {
            WordBench t = new WordBench();
            Task<string> teststring = null;
            //Parallel.Invoke(() => t.ReadText("big.txt"));
            try
            {
                teststring = t.ReadText("big.txt");
            }
            catch (Exception)
            {
                await Task.WhenAll(teststring);
                await Response.WriteAsync("OMG an error");
            }
            finally
            {
                await Task.WhenAll(teststring);
                await Response.WriteAsync(teststring.Result);
            }
            //await Response.WriteAsync(tempStr);
                //await Response.WriteAsync(tempStr).ConfigureAwait(false);
            
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
            Response.WriteAsync("This is not Console.Writeline()...");
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
